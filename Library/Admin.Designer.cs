namespace Library
{
    partial class Admin
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
            this.txtboxAdmin = new System.Windows.Forms.TextBox();
            this.btnAdminDelete = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnAdminConfirm = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxAdmin
            // 
            this.txtboxAdmin.Location = new System.Drawing.Point(188, 214);
            this.txtboxAdmin.Name = "txtboxAdmin";
            this.txtboxAdmin.ReadOnly = true;
            this.txtboxAdmin.Size = new System.Drawing.Size(225, 26);
            this.txtboxAdmin.TabIndex = 0;
            // 
            // btnAdminDelete
            // 
            this.btnAdminDelete.BackColor = System.Drawing.Color.Red;
            this.btnAdminDelete.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDelete.ForeColor = System.Drawing.Color.White;
            this.btnAdminDelete.Location = new System.Drawing.Point(543, 187);
            this.btnAdminDelete.Name = "btnAdminDelete";
            this.btnAdminDelete.Size = new System.Drawing.Size(181, 80);
            this.btnAdminDelete.TabIndex = 1;
            this.btnAdminDelete.Text = "Delete";
            this.btnAdminDelete.UseVisualStyleBackColor = false;
            this.btnAdminDelete.Visible = false;
            this.btnAdminDelete.Click += new System.EventHandler(this.btnAdminDelete_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAdmin.Location = new System.Drawing.Point(0, 447);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 62;
            this.dgvAdmin.RowTemplate.Height = 28;
            this.dgvAdmin.Size = new System.Drawing.Size(1262, 261);
            this.dgvAdmin.TabIndex = 2;
            this.dgvAdmin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellDoubleClick);
            // 
            // btnAdminConfirm
            // 
            this.btnAdminConfirm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdminConfirm.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminConfirm.ForeColor = System.Drawing.Color.White;
            this.btnAdminConfirm.Location = new System.Drawing.Point(825, 187);
            this.btnAdminConfirm.Name = "btnAdminConfirm";
            this.btnAdminConfirm.Size = new System.Drawing.Size(181, 80);
            this.btnAdminConfirm.TabIndex = 1;
            this.btnAdminConfirm.Text = "Confirm";
            this.btnAdminConfirm.UseVisualStyleBackColor = false;
            this.btnAdminConfirm.Visible = false;
            this.btnAdminConfirm.Click += new System.EventHandler(this.btnAdminConfirm_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 65);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(101, 61);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 708);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.btnAdminConfirm);
            this.Controls.Add(this.btnAdminDelete);
            this.Controls.Add(this.txtboxAdmin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxAdmin;
        private System.Windows.Forms.Button btnAdminDelete;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnAdminConfirm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}