namespace Library
{
    partial class DashBoard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbDashboardCustomers = new System.Windows.Forms.ComboBox();
            this.cmbDashBoardBooks = new System.Windows.Forms.ComboBox();
            this.numDashBoardCount = new System.Windows.Forms.NumericUpDown();
            this.txtDashBoardReturn = new System.Windows.Forms.TextBox();
            this.btnDashBoardRent = new System.Windows.Forms.Button();
            this.cmbDashBoardReturnCustomer = new System.Windows.Forms.ComboBox();
            this.lsbDashBoardReturnCustomerInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDashBoardReturn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDashBoardShow = new System.Windows.Forms.Button();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDashBoardCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2009, 88);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(95, 84);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(144, 84);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // cmbDashboardCustomers
            // 
            this.cmbDashboardCustomers.FormattingEnabled = true;
            this.cmbDashboardCustomers.Location = new System.Drawing.Point(57, 342);
            this.cmbDashboardCustomers.Name = "cmbDashboardCustomers";
            this.cmbDashboardCustomers.Size = new System.Drawing.Size(171, 28);
            this.cmbDashboardCustomers.TabIndex = 1;
            // 
            // cmbDashBoardBooks
            // 
            this.cmbDashBoardBooks.FormattingEnabled = true;
            this.cmbDashBoardBooks.Location = new System.Drawing.Point(57, 443);
            this.cmbDashBoardBooks.Name = "cmbDashBoardBooks";
            this.cmbDashBoardBooks.Size = new System.Drawing.Size(172, 28);
            this.cmbDashBoardBooks.TabIndex = 2;
            // 
            // numDashBoardCount
            // 
            this.numDashBoardCount.Location = new System.Drawing.Point(57, 543);
            this.numDashBoardCount.Name = "numDashBoardCount";
            this.numDashBoardCount.Size = new System.Drawing.Size(172, 26);
            this.numDashBoardCount.TabIndex = 3;
            // 
            // txtDashBoardReturn
            // 
            this.txtDashBoardReturn.Location = new System.Drawing.Point(57, 644);
            this.txtDashBoardReturn.Name = "txtDashBoardReturn";
            this.txtDashBoardReturn.Size = new System.Drawing.Size(171, 26);
            this.txtDashBoardReturn.TabIndex = 4;
            // 
            // btnDashBoardRent
            // 
            this.btnDashBoardRent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDashBoardRent.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoardRent.ForeColor = System.Drawing.Color.White;
            this.btnDashBoardRent.Location = new System.Drawing.Point(58, 739);
            this.btnDashBoardRent.Name = "btnDashBoardRent";
            this.btnDashBoardRent.Size = new System.Drawing.Size(170, 62);
            this.btnDashBoardRent.TabIndex = 5;
            this.btnDashBoardRent.Text = "Rent";
            this.btnDashBoardRent.UseVisualStyleBackColor = false;
            this.btnDashBoardRent.Click += new System.EventHandler(this.btnDashBoardRent_Click);
            // 
            // cmbDashBoardReturnCustomer
            // 
            this.cmbDashBoardReturnCustomer.FormattingEnabled = true;
            this.cmbDashBoardReturnCustomer.Location = new System.Drawing.Point(550, 342);
            this.cmbDashBoardReturnCustomer.Name = "cmbDashBoardReturnCustomer";
            this.cmbDashBoardReturnCustomer.Size = new System.Drawing.Size(247, 28);
            this.cmbDashBoardReturnCustomer.TabIndex = 6;
            this.cmbDashBoardReturnCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbDashBoardReturnCustomer_SelectedIndexChanged);
            // 
            // lsbDashBoardReturnCustomerInfo
            // 
            this.lsbDashBoardReturnCustomerInfo.FormattingEnabled = true;
            this.lsbDashBoardReturnCustomerInfo.ItemHeight = 20;
            this.lsbDashBoardReturnCustomerInfo.Location = new System.Drawing.Point(859, 298);
            this.lsbDashBoardReturnCustomerInfo.Name = "lsbDashBoardReturnCustomerInfo";
            this.lsbDashBoardReturnCustomerInfo.Size = new System.Drawing.Size(1138, 364);
            this.lsbDashBoardReturnCustomerInfo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Books:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Return Date:";
            // 
            // btnDashBoardReturn
            // 
            this.btnDashBoardReturn.BackColor = System.Drawing.Color.OliveDrab;
            this.btnDashBoardReturn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoardReturn.ForeColor = System.Drawing.Color.White;
            this.btnDashBoardReturn.Location = new System.Drawing.Point(550, 600);
            this.btnDashBoardReturn.Name = "btnDashBoardReturn";
            this.btnDashBoardReturn.Size = new System.Drawing.Size(247, 62);
            this.btnDashBoardReturn.TabIndex = 5;
            this.btnDashBoardReturn.Text = "Return Book";
            this.btnDashBoardReturn.UseVisualStyleBackColor = false;
            this.btnDashBoardReturn.Click += new System.EventHandler(this.btnDashBoardReturn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(545, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Customer:";
            // 
            // btnDashBoardShow
            // 
            this.btnDashBoardShow.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDashBoardShow.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoardShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashBoardShow.Location = new System.Drawing.Point(550, 504);
            this.btnDashBoardShow.Name = "btnDashBoardShow";
            this.btnDashBoardShow.Size = new System.Drawing.Size(247, 62);
            this.btnDashBoardShow.TabIndex = 13;
            this.btnDashBoardShow.Text = "Show Penalty";
            this.btnDashBoardShow.UseVisualStyleBackColor = false;
            this.btnDashBoardShow.Click += new System.EventHandler(this.btnDashBoardShow_Click);
            // 
            // txtPenalty
            // 
            this.txtPenalty.Location = new System.Drawing.Point(550, 432);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(247, 26);
            this.txtPenalty.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(545, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Penalty:";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(95, 84);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2009, 1047);
            this.Controls.Add(this.txtPenalty);
            this.Controls.Add(this.btnDashBoardShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbDashBoardReturnCustomerInfo);
            this.Controls.Add(this.cmbDashBoardReturnCustomer);
            this.Controls.Add(this.btnDashBoardReturn);
            this.Controls.Add(this.btnDashBoardRent);
            this.Controls.Add(this.txtDashBoardReturn);
            this.Controls.Add(this.numDashBoardCount);
            this.Controls.Add(this.cmbDashBoardBooks);
            this.Controls.Add(this.cmbDashboardCustomers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDashBoardCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbDashboardCustomers;
        private System.Windows.Forms.ComboBox cmbDashBoardBooks;
        private System.Windows.Forms.NumericUpDown numDashBoardCount;
        private System.Windows.Forms.TextBox txtDashBoardReturn;
        private System.Windows.Forms.Button btnDashBoardRent;
        private System.Windows.Forms.ComboBox cmbDashBoardReturnCustomer;
        private System.Windows.Forms.ListBox lsbDashBoardReturnCustomerInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDashBoardReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDashBoardShow;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
    }
}

