using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using MailKit.Net.Smtp;
using MimeKit;
using System.Configuration;
using HotelManagementSystem.Business.Staff;
using HotelManagementSystem.Business.Clients;
using Org.BouncyCastle.Cms;
using HotelManagementSystem.Data;

namespace HotelManagementSystem.Business
{
    internal class ReportControl
    {
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUsername;
        private readonly string _smtpPassword;
        private StaffControll _sc = new StaffControll();

        public ReportControl()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            _smtpServer = ConfigurationManager.AppSettings["SmtpServer"];
            _smtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
            _smtpUsername = ConfigurationManager.AppSettings["SmtpUsername"];
            _smtpPassword = ConfigurationManager.AppSettings["SmtpPassword"];
        }

        public void GenerateReport(string title, string desc, string bt, string linechart, string lct, string barchart, string apt, string agent_piechart, string tpt, string type_piechart, DateTime date, string empID)
        {

            Document.Create(container =>
            {
                //Report cover page
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Content()
                        .AlignCenter()
                        .AlignMiddle()
                        .Column(x =>
                        {
                            x.Spacing(20);
                            x.Item().Text(title)
                                .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);
                            x.Item().Text($"Date generated: {date.ToShortDateString()}")
                                .SemiBold().FontSize(24).FontColor(Colors.Black);
                            x.Item().Text(desc).FontSize(12).FontColor(Colors.Black);
                        });
                });


                container.Page(page =>
                {
                    page.Content()
                        .PaddingVertical(4, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);
                            x.Item().Text(bt).FontSize(12).FontColor(Colors.Black).SemiBold().AlignCenter();
                            x.Item().Image(linechart);
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();
                        });
                });

                container.Page(page =>
                {
                    page.Content()
                        .PaddingVertical(4, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);
                            x.Item().Text(bt).FontSize(12).FontColor(Colors.Black).SemiBold().AlignCenter();
                            x.Item().Image(barchart);
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();
                        });
                });


                container.Page(page =>
                {
                    page.Content()
                        .PaddingVertical(4, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);
                            x.Item().Text(apt).FontSize(12).FontColor(Colors.Black).SemiBold().AlignCenter();
                            x.Item().Image(agent_piechart);
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();
                        });
                });


                container.Page(page =>
                {
                    page.Content()
                        .PaddingVertical(4, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Item().Text(tpt).FontSize(12).FontColor(Colors.Black).SemiBold().AlignCenter();
                            x.Item().Image(type_piechart);
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();
                        });
                });


            })
        .GeneratePdf($"report.pdf");
            SendReport(title, desc, empID);
        }

        public async void SendReport(string title, string desc, string emp)
        {
            string staffName ="";
            Dictionary<string, string> recipients = new Dictionary<string, string>();
            foreach (var s in _sc.allStaff)
            {
                if (s.role == 2 || s.role == 3)
                {
                    recipients.Add($"{s.fName} {s.sName}", s.email);
                }
                if (s.empID == emp)
                {
                    staffName = $"{s.fName} {s.sName}";
                }
            }

            //recipients.Add("Geoff1", "gsnaude@gmail.com");
            //recipients.Add("Geoff2", "ndxgeo002@myuct.ac.za");
            string subject = title;
            string body = desc;
            string pdfPath = "report.pdf";
            await SendEmailAsync(recipients, subject, body, pdfPath, staffName);

        }
        public async Task SendEmailAsync(Dictionary<string, string> recipients, string subject, string body, string pdfFilePath, string staff)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(staff, _smtpUsername));

            foreach (var recipient in recipients)
            {
                email.To.Add(new MailboxAddress(recipient.Key, recipient.Value));
            }

            email.Subject = subject;

            var builder = new BodyBuilder { TextBody = body };

            if (File.Exists(pdfFilePath))
            {
                builder.Attachments.Add(pdfFilePath);
            }

            email.Body = builder.ToMessageBody();

            using (var smtp = new SmtpClient())
            {
                await smtp.ConnectAsync(_smtpServer, _smtpPort, MailKit.Security.SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(_smtpUsername, _smtpPassword);
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
            }

            if (File.Exists(pdfFilePath))
            {
                File.Delete(pdfFilePath);
            }
        }

        public async Task SendConfirmationEmailGuest(string staff, Guest guest, IProgress<int> progress, int total, int count, string subject, string body)
        {
            string staffName = staff;

            int percentComplete = (count * 100 / total);
            progress.Report(percentComplete);

            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(staffName, _smtpUsername));
            email.To.Add(new MailboxAddress($"{guest.fName} {guest.sName}", guest.email));
            
            email.Subject = subject;
            
            var builder = new BodyBuilder { TextBody = body };
            email.Body = builder.ToMessageBody();
            using (var smtp = new SmtpClient())
            {
                await smtp.ConnectAsync(_smtpServer, _smtpPort, MailKit.Security.SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(_smtpUsername, _smtpPassword);
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
            }
            return;
        }

        public async Task SendConfirmationEmailAgent(string staff, Agent agent, IProgress<int> progress, int total, int count,string subject, string body)
        {
            string staffName = staff;
           
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(staffName, _smtpUsername));
            email.To.Add(new MailboxAddress($"{agent.company}", agent.email));

            int percentComplete = (count * 100 / total);
            progress.Report(percentComplete);

            email.Subject = subject;
           
            var builder = new BodyBuilder { TextBody = body };
            email.Body = builder.ToMessageBody();
            using (var smtp = new SmtpClient())
            {
                await smtp.ConnectAsync(_smtpServer, _smtpPort, MailKit.Security.SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(_smtpUsername, _smtpPassword);
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
            }
            return;
        }
    }
}


