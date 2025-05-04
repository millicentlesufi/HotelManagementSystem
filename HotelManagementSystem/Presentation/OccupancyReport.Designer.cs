namespace HotelManagementSystem.Presentation
{
    partial class OccupancyReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gb_Report_options = new System.Windows.Forms.GroupBox();
            this.btn_Generate_report = new System.Windows.Forms.Button();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.lbl_End_Date = new System.Windows.Forms.Label();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.chrt_bookings = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gb_Charts = new System.Windows.Forms.GroupBox();
            this.gb_Report_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_bookings)).BeginInit();
            this.gb_Charts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Report_options
            // 
            this.gb_Report_options.Controls.Add(this.btn_Generate_report);
            this.gb_Report_options.Controls.Add(this.dtp_End);
            this.gb_Report_options.Controls.Add(this.dtp_Start);
            this.gb_Report_options.Controls.Add(this.lbl_End_Date);
            this.gb_Report_options.Controls.Add(this.lbl_Start);
            this.gb_Report_options.Location = new System.Drawing.Point(398, 12);
            this.gb_Report_options.Name = "gb_Report_options";
            this.gb_Report_options.Size = new System.Drawing.Size(291, 101);
            this.gb_Report_options.TabIndex = 3;
            this.gb_Report_options.TabStop = false;
            this.gb_Report_options.Text = "Report Options";
            // 
            // btn_Generate_report
            // 
            this.btn_Generate_report.Location = new System.Drawing.Point(83, 66);
            this.btn_Generate_report.Name = "btn_Generate_report";
            this.btn_Generate_report.Size = new System.Drawing.Size(117, 29);
            this.btn_Generate_report.TabIndex = 4;
            this.btn_Generate_report.Text = "Generate Report";
            this.btn_Generate_report.UseVisualStyleBackColor = true;
            this.btn_Generate_report.Click += new System.EventHandler(this.btn_Generate_report_Click);
            // 
            // dtp_End
            // 
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_End.Location = new System.Drawing.Point(154, 38);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(117, 22);
            this.dtp_End.TabIndex = 3;
            // 
            // dtp_Start
            // 
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Start.Location = new System.Drawing.Point(6, 38);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(117, 22);
            this.dtp_Start.TabIndex = 2;
            // 
            // lbl_End_Date
            // 
            this.lbl_End_Date.AutoSize = true;
            this.lbl_End_Date.Location = new System.Drawing.Point(177, 18);
            this.lbl_End_Date.Name = "lbl_End_Date";
            this.lbl_End_Date.Size = new System.Drawing.Size(63, 16);
            this.lbl_End_Date.TabIndex = 1;
            this.lbl_End_Date.Text = "End Date";
            // 
            // lbl_Start
            // 
            this.lbl_Start.AutoSize = true;
            this.lbl_Start.Location = new System.Drawing.Point(27, 18);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Size = new System.Drawing.Size(66, 16);
            this.lbl_Start.TabIndex = 0;
            this.lbl_Start.Text = "Start Date";
            // 
            // chrt_bookings
            // 
            chartArea2.Name = "ChartArea1";
            this.chrt_bookings.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrt_bookings.Legends.Add(legend2);
            this.chrt_bookings.Location = new System.Drawing.Point(15, 26);
            this.chrt_bookings.Name = "chrt_bookings";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrt_bookings.Series.Add(series2);
            this.chrt_bookings.Size = new System.Drawing.Size(821, 557);
            this.chrt_bookings.TabIndex = 4;
            this.chrt_bookings.Text = "chart1";
            // 
            // gb_Charts
            // 
            this.gb_Charts.Controls.Add(this.chrt_bookings);
            this.gb_Charts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Charts.Location = new System.Drawing.Point(95, 119);
            this.gb_Charts.Name = "gb_Charts";
            this.gb_Charts.Size = new System.Drawing.Size(842, 605);
            this.gb_Charts.TabIndex = 5;
            this.gb_Charts.TabStop = false;
            this.gb_Charts.Text = "groupBox1";
            this.gb_Charts.Visible = false;
            // 
            // OccupancyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 700);
            this.Controls.Add(this.gb_Charts);
            this.Controls.Add(this.gb_Report_options);
            this.Name = "OccupancyReport";
            this.Text = "Occupancy Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OccupancyReport_FormClosing);
            this.Load += new System.EventHandler(this.OccupancyReport_Load);
            this.gb_Report_options.ResumeLayout(false);
            this.gb_Report_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_bookings)).EndInit();
            this.gb_Charts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Report_options;
        private System.Windows.Forms.Button btn_Generate_report;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.Label lbl_End_Date;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_bookings;
        private System.Windows.Forms.GroupBox gb_Charts;
    }
}