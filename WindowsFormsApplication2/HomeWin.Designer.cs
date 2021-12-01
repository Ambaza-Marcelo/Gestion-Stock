namespace WindowsFormsApplication2
{
    partial class HomeWin
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
            this.gestionDesEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesDepensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesEmployeesToolStripMenuItem,
            this.gestionDesClientsToolStripMenuItem,
            this.gestionDesDepensesToolStripMenuItem,
            this.gestionDesProduitsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1444, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesEmployeesToolStripMenuItem
            // 
            this.gestionDesEmployeesToolStripMenuItem.Name = "gestionDesEmployeesToolStripMenuItem";
            this.gestionDesEmployeesToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.gestionDesEmployeesToolStripMenuItem.Text = "Gestion des Employees";
            this.gestionDesEmployeesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesEmployeesToolStripMenuItem_Click);
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            this.gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            this.gestionDesClientsToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.gestionDesClientsToolStripMenuItem.Text = "Gestion des Clients";
            this.gestionDesClientsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesClientsToolStripMenuItem_Click);
            // 
            // gestionDesDepensesToolStripMenuItem
            // 
            this.gestionDesDepensesToolStripMenuItem.Name = "gestionDesDepensesToolStripMenuItem";
            this.gestionDesDepensesToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.gestionDesDepensesToolStripMenuItem.Text = "Gestion des Depenses";
            this.gestionDesDepensesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesDepensesToolStripMenuItem_Click);
            // 
            // gestionDesProduitsToolStripMenuItem
            // 
            this.gestionDesProduitsToolStripMenuItem.Name = "gestionDesProduitsToolStripMenuItem";
            this.gestionDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.gestionDesProduitsToolStripMenuItem.Text = "Gestion des Produits";
            this.gestionDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesProduitsToolStripMenuItem_Click);
            // 
            // HomeWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 735);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeWin";
            this.Text = "HomeWin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesDepensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesProduitsToolStripMenuItem;
    }
}