namespace WindowsFormsApplication2
{
    partial class ProduitWin
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
            this.idProduit = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prix_unitaire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des produits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Produit";
            // 
            // idProduit
            // 
            this.idProduit.Location = new System.Drawing.Point(255, 132);
            this.idProduit.Name = "idProduit";
            this.idProduit.Size = new System.Drawing.Size(209, 22);
            this.idProduit.TabIndex = 2;
            this.idProduit.TextChanged += new System.EventHandler(this.idProduit_TextChanged);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(255, 176);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(209, 22);
            this.nom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom ";
            // 
            // prix_unitaire
            // 
            this.prix_unitaire.Location = new System.Drawing.Point(255, 227);
            this.prix_unitaire.Name = "prix_unitaire";
            this.prix_unitaire.Size = new System.Drawing.Size(209, 22);
            this.prix_unitaire.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prix Unitaire";
            // 
            // quantite
            // 
            this.quantite.Location = new System.Drawing.Point(255, 283);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(209, 22);
            this.quantite.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantite";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(255, 384);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(209, 28);
            this.create.TabIndex = 9;
            this.create.Text = "Creer";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(255, 449);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(209, 28);
            this.read.TabIndex = 10;
            this.read.Text = "Afficher";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(255, 508);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(209, 28);
            this.update.TabIndex = 11;
            this.update.Text = "Modifier";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(255, 562);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(209, 28);
            this.delete.TabIndex = 12;
            this.delete.Text = "Supprimer";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // ProduitWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 758);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.read);
            this.Controls.Add(this.create);
            this.Controls.Add(this.quantite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prix_unitaire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idProduit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProduitWin";
            this.Text = "ProduitWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idProduit;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prix_unitaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
    }
}