namespace Library
{
    partial class Report
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
            this.dgvAdminReport = new System.Windows.Forms.DataGridView();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.cmbReportCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminReport
            // 
            this.dgvAdminReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminReport.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgvAdminReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAdminReport.Location = new System.Drawing.Point(0, 328);
            this.dgvAdminReport.Name = "dgvAdminReport";
            this.dgvAdminReport.RowHeadersWidth = 62;
            this.dgvAdminReport.RowTemplate.Height = 28;
            this.dgvAdminReport.Size = new System.Drawing.Size(1100, 207);
            this.dgvAdminReport.TabIndex = 0;
            // 
            // btnShowReport
            // 
            this.btnShowReport.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShowReport.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.ForeColor = System.Drawing.Color.White;
            this.btnShowReport.Location = new System.Drawing.Point(438, 204);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(200, 73);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "Show";
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // cmbReportCustomer
            // 
            this.cmbReportCustomer.FormattingEnabled = true;
            this.cmbReportCustomer.Location = new System.Drawing.Point(441, 107);
            this.cmbReportCustomer.Name = "cmbReportCustomer";
            this.cmbReportCustomer.Size = new System.Drawing.Size(197, 28);
            this.cmbReportCustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Customer:";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 535);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbReportCustomer);
            this.Controls.Add(this.dgvAdminReport);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminReport;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.ComboBox cmbReportCustomer;
        private System.Windows.Forms.Label label1;
    }
}