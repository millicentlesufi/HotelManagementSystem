namespace HotelManagementSystem.Presentation
{
    partial class OpperationReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpperationReport));
            this.chrt_occGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gb_Report_options = new System.Windows.Forms.GroupBox();
            this.btn_Generate_report = new System.Windows.Forms.Button();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.lbl_End_Date = new System.Windows.Forms.Label();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.tc_Report_tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chrt_Pie_Bookings = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chrt_agent_pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gb_Oc_report = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chrt_Income = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_occGraph)).BeginInit();
            this.gb_Report_options.SuspendLayout();
            this.tc_Report_tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Pie_Bookings)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_agent_pie)).BeginInit();
            this.gb_Oc_report.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Income)).BeginInit();
            this.SuspendLayout();
            // 
            // chrt_occGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_occGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_occGraph.Legends.Add(legend1);
            this.chrt_occGraph.Location = new System.Drawing.Point(3, 6);
            this.chrt_occGraph.Name = "chrt_occGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrt_occGraph.Series.Add(series1);
            this.chrt_occGraph.Size = new System.Drawing.Size(1221, 451);
            this.chrt_occGraph.TabIndex = 0;
            this.chrt_occGraph.Text = "chart1";
            // 
            // gb_Report_options
            // 
            this.gb_Report_options.Controls.Add(this.btn_Generate_report);
            this.gb_Report_options.Controls.Add(this.dtp_End);
            this.gb_Report_options.Controls.Add(this.dtp_Start);
            this.gb_Report_options.Controls.Add(this.lbl_End_Date);
            this.gb_Report_options.Controls.Add(this.lbl_Start);
            this.gb_Report_options.Location = new System.Drawing.Point(475, 12);
            this.gb_Report_options.Name = "gb_Report_options";
            this.gb_Report_options.Size = new System.Drawing.Size(291, 101);
            this.gb_Report_options.TabIndex = 2;
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
            // tc_Report_tabs
            // 
            this.tc_Report_tabs.Controls.Add(this.tabPage1);
            this.tc_Report_tabs.Controls.Add(this.tabPage4);
            this.tc_Report_tabs.Controls.Add(this.tabPage2);
            this.tc_Report_tabs.Controls.Add(this.tabPage3);
            this.tc_Report_tabs.Location = new System.Drawing.Point(6, 21);
            this.tc_Report_tabs.Name = "tc_Report_tabs";
            this.tc_Report_tabs.SelectedIndex = 0;
            this.tc_Report_tabs.Size = new System.Drawing.Size(1238, 497);
            this.tc_Report_tabs.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chrt_occGraph);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1230, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Occupancy per day";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chrt_Pie_Bookings);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1230, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bookings by Type";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chrt_Pie_Bookings
            // 
            chartArea3.Name = "ChartArea1";
            this.chrt_Pie_Bookings.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrt_Pie_Bookings.Legends.Add(legend3);
            this.chrt_Pie_Bookings.Location = new System.Drawing.Point(20, 21);
            this.chrt_Pie_Bookings.Name = "chrt_Pie_Bookings";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrt_Pie_Bookings.Series.Add(series3);
            this.chrt_Pie_Bookings.Size = new System.Drawing.Size(1204, 441);
            this.chrt_Pie_Bookings.TabIndex = 0;
            this.chrt_Pie_Bookings.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chrt_agent_pie);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1230, 468);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bookings by Agents";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chrt_agent_pie
            // 
            chartArea4.Name = "ChartArea1";
            this.chrt_agent_pie.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrt_agent_pie.Legends.Add(legend4);
            this.chrt_agent_pie.Location = new System.Drawing.Point(3, 3);
            this.chrt_agent_pie.Name = "chrt_agent_pie";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chrt_agent_pie.Series.Add(series4);
            this.chrt_agent_pie.Size = new System.Drawing.Size(1224, 490);
            this.chrt_agent_pie.TabIndex = 0;
            this.chrt_agent_pie.Text = "chart1";
            // 
            // gb_Oc_report
            // 
            this.gb_Oc_report.Controls.Add(this.btn_Cancel);
            this.gb_Oc_report.Controls.Add(this.btn_Export);
            this.gb_Oc_report.Controls.Add(this.tc_Report_tabs);
            this.gb_Oc_report.Location = new System.Drawing.Point(12, 119);
            this.gb_Oc_report.Name = "gb_Oc_report";
            this.gb_Oc_report.Size = new System.Drawing.Size(1250, 611);
            this.gb_Oc_report.TabIndex = 4;
            this.gb_Oc_report.TabStop = false;
            this.gb_Oc_report.Text = "groupBox1";
            this.gb_Oc_report.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(1123, 548);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(121, 32);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Close";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(996, 548);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(121, 32);
            this.btn_Export.TabIndex = 4;
            this.btn_Export.Text = "Send Report";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chrt_Income);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1230, 468);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Income Report";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chrt_Income
            // 
            chartArea2.Name = "ChartArea1";
            this.chrt_Income.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrt_Income.Legends.Add(legend2);
            this.chrt_Income.Location = new System.Drawing.Point(3, 3);
            this.chrt_Income.Name = "chrt_Income";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrt_Income.Series.Add(series2);
            this.chrt_Income.Size = new System.Drawing.Size(1224, 462);
            this.chrt_Income.TabIndex = 0;
            this.chrt_Income.Text = "chart1";
            // 
            // OpperationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 711);
            this.Controls.Add(this.gb_Oc_report);
            this.Controls.Add(this.gb_Report_options);
            this.DoubleBuffered = true;
            this.Name = "OpperationReport";
            this.Text = "Performance Report";
            this.Activated += new System.EventHandler(this.OpperationReport_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpperationReport_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_occGraph)).EndInit();
            this.gb_Report_options.ResumeLayout(false);
            this.gb_Report_options.PerformLayout();
            this.tc_Report_tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Pie_Bookings)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_agent_pie)).EndInit();
            this.gb_Oc_report.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Income)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_occGraph;
        private System.Windows.Forms.GroupBox gb_Report_options;
        private System.Windows.Forms.Label lbl_End_Date;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.Button btn_Generate_report;
        private System.Windows.Forms.TabControl tc_Report_tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gb_Oc_report;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_Pie_Bookings;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_agent_pie;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_Income;
    }
}