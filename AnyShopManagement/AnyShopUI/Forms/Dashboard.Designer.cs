namespace AnyShopUI.Forms
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DashboardChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonStock = new System.Windows.Forms.Button();
            this.ButtonDailyBook = new System.Windows.Forms.Button();
            this.ButtonInvoice = new System.Windows.Forms.Button();
            this.ButtonCustomer = new System.Windows.Forms.Button();
            this.Vendor = new System.Windows.Forms.Button();
            this.ButtonReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardChart)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardChart
            // 
            chartArea6.Name = "ChartArea1";
            this.DashboardChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.DashboardChart.Legends.Add(legend6);
            this.DashboardChart.Location = new System.Drawing.Point(565, 63);
            this.DashboardChart.Name = "DashboardChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.DashboardChart.Series.Add(series6);
            this.DashboardChart.Size = new System.Drawing.Size(400, 307);
            this.DashboardChart.TabIndex = 0;
            this.DashboardChart.Text = "Sales Chart";
            // 
            // ButtonStock
            // 
            this.ButtonStock.BackColor = System.Drawing.Color.White;
            this.ButtonStock.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStock.Location = new System.Drawing.Point(56, 62);
            this.ButtonStock.Name = "ButtonStock";
            this.ButtonStock.Size = new System.Drawing.Size(150, 150);
            this.ButtonStock.TabIndex = 1;
            this.ButtonStock.Text = "Stock";
            this.ButtonStock.UseVisualStyleBackColor = false;
            this.ButtonStock.Click += new System.EventHandler(this.ButtonStock_Click);
            // 
            // ButtonDailyBook
            // 
            this.ButtonDailyBook.BackColor = System.Drawing.Color.White;
            this.ButtonDailyBook.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDailyBook.Location = new System.Drawing.Point(369, 63);
            this.ButtonDailyBook.Name = "ButtonDailyBook";
            this.ButtonDailyBook.Size = new System.Drawing.Size(150, 150);
            this.ButtonDailyBook.TabIndex = 2;
            this.ButtonDailyBook.Text = "DailyBook";
            this.ButtonDailyBook.UseVisualStyleBackColor = false;
            this.ButtonDailyBook.Click += new System.EventHandler(this.ButtonDailyBook_Click);
            // 
            // ButtonInvoice
            // 
            this.ButtonInvoice.BackColor = System.Drawing.Color.White;
            this.ButtonInvoice.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInvoice.Location = new System.Drawing.Point(212, 63);
            this.ButtonInvoice.Name = "ButtonInvoice";
            this.ButtonInvoice.Size = new System.Drawing.Size(150, 150);
            this.ButtonInvoice.TabIndex = 3;
            this.ButtonInvoice.Text = "Invoice";
            this.ButtonInvoice.UseVisualStyleBackColor = false;
            this.ButtonInvoice.Click += new System.EventHandler(this.ButtonInvoice_Click);
            // 
            // ButtonCustomer
            // 
            this.ButtonCustomer.BackColor = System.Drawing.Color.White;
            this.ButtonCustomer.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCustomer.Location = new System.Drawing.Point(56, 220);
            this.ButtonCustomer.Name = "ButtonCustomer";
            this.ButtonCustomer.Size = new System.Drawing.Size(150, 150);
            this.ButtonCustomer.TabIndex = 4;
            this.ButtonCustomer.Text = "Customers";
            this.ButtonCustomer.UseVisualStyleBackColor = false;
            this.ButtonCustomer.Click += new System.EventHandler(this.ButtonCustomer_Click);
            // 
            // Vendor
            // 
            this.Vendor.BackColor = System.Drawing.Color.White;
            this.Vendor.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendor.Location = new System.Drawing.Point(212, 221);
            this.Vendor.Name = "Vendor";
            this.Vendor.Size = new System.Drawing.Size(150, 150);
            this.Vendor.TabIndex = 6;
            this.Vendor.Text = "Vendor";
            this.Vendor.UseVisualStyleBackColor = false;
            this.Vendor.Click += new System.EventHandler(this.Vendor_Click);
            // 
            // ButtonReport
            // 
            this.ButtonReport.BackColor = System.Drawing.Color.White;
            this.ButtonReport.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReport.Location = new System.Drawing.Point(369, 220);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(150, 150);
            this.ButtonReport.TabIndex = 5;
            this.ButtonReport.Text = "Report";
            this.ButtonReport.UseVisualStyleBackColor = false;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.Vendor);
            this.Controls.Add(this.ButtonReport);
            this.Controls.Add(this.ButtonCustomer);
            this.Controls.Add(this.ButtonInvoice);
            this.Controls.Add(this.ButtonDailyBook);
            this.Controls.Add(this.ButtonStock);
            this.Controls.Add(this.DashboardChart);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DashboardChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DashboardChart;
        private System.Windows.Forms.Button ButtonStock;
        private System.Windows.Forms.Button ButtonDailyBook;
        private System.Windows.Forms.Button ButtonInvoice;
        private System.Windows.Forms.Button ButtonCustomer;
        private System.Windows.Forms.Button Vendor;
        private System.Windows.Forms.Button ButtonReport;
    }
}