namespace WindowsFormsApplication2
{
    partial class ClientWin
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
            this.label2 = new System.Windows.Forms.Label();
            this.idClient = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Client";
            // 
            // idClient
            // 
            this.idClient.Location = new System.Drawing.Point(233, 156);
            this.idClient.Name = "idClient";
            this.idClient.Size = new System.Drawing.Size(181, 22);
            this.idClient.TabIndex = 2;
            this.idClient.TextChanged += new System.EventHandler(this.idClient_TextChanged);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(233, 202);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(181, 22);
            this.nom.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nom";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(233, 256);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(181, 22);
            this.prenom.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prenom";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(233, 311);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(181, 22);
            this.email.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "E-mail";
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(233, 362);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(181, 22);
            this.telephone.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Telephone";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(233, 415);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(181, 22);
            this.adresse.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Adresse";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(233, 658);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(181, 28);
            this.delete.TabIndex = 26;
            this.delete.Text = "Supprimer";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(233, 604);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(181, 28);
            this.update.TabIndex = 25;
            this.update.Text = "Modifier";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(233, 545);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(181, 28);
            this.read.TabIndex = 24;
            this.read.Text = "Afficher";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(233, 480);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(181, 28);
            this.create.TabIndex = 23;
            this.create.Text = "Creer";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // ClientWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 760);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.read);
            this.Controls.Add(this.create);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientWin";
            this.Text = "ClientWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idClient;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button create;
    }
}