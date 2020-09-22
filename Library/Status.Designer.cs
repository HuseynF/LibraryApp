namespace Library
{
    partial class Status
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatusToday = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatusTomorrow = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatusLate = new System.Windows.Forms.ComboBox();
            this.lsbStatusToday = new System.Windows.Forms.ListBox();
            this.lsbStatusTomorrow = new System.Windows.Forms.ListBox();
            this.lsbStatusLate = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today";
            // 
            // cmbStatusToday
            // 
            this.cmbStatusToday.FormattingEnabled = true;
            this.cmbStatusToday.Location = new System.Drawing.Point(45, 186);
            this.cmbStatusToday.Name = "cmbStatusToday";
            this.cmbStatusToday.Size = new System.Drawing.Size(188, 28);
            this.cmbStatusToday.TabIndex = 1;
            this.cmbStatusToday.SelectedIndexChanged += new System.EventHandler(this.cmbStatusToday_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tomorrow";
            // 
            // cmbStatusTomorrow
            // 
            this.cmbStatusTomorrow.FormattingEnabled = true;
            this.cmbStatusTomorrow.Location = new System.Drawing.Point(594, 186);
            this.cmbStatusTomorrow.Name = "cmbStatusTomorrow";
            this.cmbStatusTomorrow.Size = new System.Drawing.Size(188, 28);
            this.cmbStatusTomorrow.TabIndex = 1;
            this.cmbStatusTomorrow.SelectedIndexChanged += new System.EventHandler(this.cmbStatusTomorrow_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1138, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Late";
            // 
            // cmbStatusLate
            // 
            this.cmbStatusLate.FormattingEnabled = true;
            this.cmbStatusLate.Location = new System.Drawing.Point(1142, 186);
            this.cmbStatusLate.Name = "cmbStatusLate";
            this.cmbStatusLate.Size = new System.Drawing.Size(188, 28);
            this.cmbStatusLate.TabIndex = 1;
            this.cmbStatusLate.SelectedIndexChanged += new System.EventHandler(this.cmbStatusLate_SelectedIndexChanged);
            // 
            // lsbStatusToday
            // 
            this.lsbStatusToday.FormattingEnabled = true;
            this.lsbStatusToday.ItemHeight = 20;
            this.lsbStatusToday.Location = new System.Drawing.Point(46, 340);
            this.lsbStatusToday.Name = "lsbStatusToday";
            this.lsbStatusToday.Size = new System.Drawing.Size(412, 124);
            this.lsbStatusToday.TabIndex = 2;
            // 
            // lsbStatusTomorrow
            // 
            this.lsbStatusTomorrow.FormattingEnabled = true;
            this.lsbStatusTomorrow.ItemHeight = 20;
            this.lsbStatusTomorrow.Location = new System.Drawing.Point(594, 340);
            this.lsbStatusTomorrow.Name = "lsbStatusTomorrow";
            this.lsbStatusTomorrow.Size = new System.Drawing.Size(445, 124);
            this.lsbStatusTomorrow.TabIndex = 2;
            // 
            // lsbStatusLate
            // 
            this.lsbStatusLate.FormattingEnabled = true;
            this.lsbStatusLate.ItemHeight = 20;
            this.lsbStatusLate.Location = new System.Drawing.Point(1142, 340);
            this.lsbStatusLate.Name = "lsbStatusLate";
            this.lsbStatusLate.Size = new System.Drawing.Size(438, 124);
            this.lsbStatusLate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1619, 94);
            this.label4.TabIndex = 3;
            this.label4.Text = "Information";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1619, 842);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsbStatusLate);
            this.Controls.Add(this.lsbStatusTomorrow);
            this.Controls.Add(this.lsbStatusToday);
            this.Controls.Add(this.cmbStatusLate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatusTomorrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatusToday);
            this.Controls.Add(this.label1);
            this.Name = "Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status";
            this.Load += new System.EventHandler(this.Status_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatusToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatusTomorrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatusLate;
        private System.Windows.Forms.ListBox lsbStatusToday;
        private System.Windows.Forms.ListBox lsbStatusTomorrow;
        private System.Windows.Forms.ListBox lsbStatusLate;
        private System.Windows.Forms.Label label4;
    }
}