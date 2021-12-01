namespace WindowsFormsApplication2
{
    partial class DepenseWin
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
            this.idDepense = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.montant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(507, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des Depenses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Depense";
            // 
            // idDepense
            // 
            this.idDepense.Location = new System.Drawing.Point(272, 161);
            this.idDepense.Name = "idDepense";
            this.idDepense.Size = new System.Drawing.Size(254, 22);
            this.idDepense.TabIndex = 2;
            this.idDepense.TextChanged += new System.EventHandler(this.idDepense_TextChanged);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(272, 203);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(254, 22);
            this.description.TabIndex = 4;
            this.description.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // montant
            // 
            this.montant.Location = new System.Drawing.Point(272, 253);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(254, 22);
            this.montant.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Montant";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(272, 561);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(254, 28);
            this.delete.TabIndex = 16;
            this.delete.Text = "Supprimer";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(272, 507);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(254, 28);
            this.update.TabIndex = 15;
            this.update.Text = "Modifier";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(272, 448);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(254, 28);
            this.read.TabIndex = 14;
            this.read.Text = "Afficher";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(272, 383);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(254, 28);
            this.create.TabIndex = 13;
            this.create.Text = "Creer";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // DepenseWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 765);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.read);
            this.Controls.Add(this.create);
            this.Controls.Add(this.montant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idDepense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepenseWin";
            this.Text = "DepenseWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idDepense;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox montant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button create;
    }
}