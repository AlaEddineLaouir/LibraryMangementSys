﻿namespace BiblioUI
{
    partial class ModifierEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierEtudiant));
            this.titre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.matLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.numC = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.nomLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nomU = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.email = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.niveau = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.specialite = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.prenom = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nom = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.add = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(263, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(259, 41);
            this.titre.TabIndex = 16;
            this.titre.Text = "Modifier Etudiant";
            // 
            // matLable
            // 
            this.matLable.AutoSize = true;
            this.matLable.ForeColor = System.Drawing.Color.Red;
            this.matLable.Location = new System.Drawing.Point(559, 158);
            this.matLable.Name = "matLable";
            this.matLable.Size = new System.Drawing.Size(59, 13);
            this.matLable.TabIndex = 26;
            this.matLable.Text = "deja utiliser";
            this.matLable.Visible = false;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(406, 125);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(145, 25);
            this.bunifuCustomLabel9.TabIndex = 25;
            this.bunifuCustomLabel9.Text = "Numero Carte :";
            // 
            // numC
            // 
            this.numC.BorderColor = System.Drawing.Color.SeaGreen;
            this.numC.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numC.Location = new System.Drawing.Point(553, 122);
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(176, 33);
            this.numC.TabIndex = 24;
            this.numC.Leave += new System.EventHandler(this.numC_Leave);
            // 
            // nomLable
            // 
            this.nomLable.AutoSize = true;
            this.nomLable.ForeColor = System.Drawing.Color.Red;
            this.nomLable.Location = new System.Drawing.Point(179, 158);
            this.nomLable.Name = "nomLable";
            this.nomLable.Size = new System.Drawing.Size(59, 13);
            this.nomLable.TabIndex = 23;
            this.nomLable.Text = "deja utiliser";
            this.nomLable.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 125);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(158, 25);
            this.bunifuCustomLabel1.TabIndex = 22;
            this.bunifuCustomLabel1.Text = "Nom Utilisateur :";
            // 
            // nomU
            // 
            this.nomU.BorderColor = System.Drawing.Color.SeaGreen;
            this.nomU.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomU.Location = new System.Drawing.Point(173, 122);
            this.nomU.Name = "nomU";
            this.nomU.Size = new System.Drawing.Size(193, 33);
            this.nomU.TabIndex = 21;
            this.nomU.Leave += new System.EventHandler(this.nomU_Leave);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(9, 254);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(69, 25);
            this.bunifuCustomLabel7.TabIndex = 36;
            this.bunifuCustomLabel7.Text = "Email :";
            // 
            // email
            // 
            this.email.BorderColor = System.Drawing.Color.SeaGreen;
            this.email.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(170, 251);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(196, 33);
            this.email.TabIndex = 35;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(406, 259);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(83, 25);
            this.bunifuCustomLabel6.TabIndex = 34;
            this.bunifuCustomLabel6.Text = "Niveau :";
            // 
            // niveau
            // 
            this.niveau.AutoCompleteCustomSource.AddRange(new string[] {
            "L1",
            "L2",
            "L3",
            "M1",
            "M2",
            "D1",
            "D2",
            "D3"});
            this.niveau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.niveau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.niveau.BorderColor = System.Drawing.Color.SeaGreen;
            this.niveau.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveau.Location = new System.Drawing.Point(553, 256);
            this.niveau.Name = "niveau";
            this.niveau.Size = new System.Drawing.Size(176, 33);
            this.niveau.TabIndex = 33;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(6, 315);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(104, 25);
            this.bunifuCustomLabel5.TabIndex = 32;
            this.bunifuCustomLabel5.Text = "Specialite :";
            // 
            // specialite
            // 
            this.specialite.BorderColor = System.Drawing.Color.SeaGreen;
            this.specialite.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialite.Location = new System.Drawing.Point(170, 309);
            this.specialite.Name = "specialite";
            this.specialite.Size = new System.Drawing.Size(193, 33);
            this.specialite.TabIndex = 31;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(9, 199);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(89, 25);
            this.bunifuCustomLabel3.TabIndex = 30;
            this.bunifuCustomLabel3.Text = "Prenom :";
            // 
            // prenom
            // 
            this.prenom.BorderColor = System.Drawing.Color.SeaGreen;
            this.prenom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(173, 196);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(193, 33);
            this.prenom.TabIndex = 29;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(406, 199);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(65, 25);
            this.bunifuCustomLabel2.TabIndex = 28;
            this.bunifuCustomLabel2.Text = "Nom :";
            // 
            // nom
            // 
            this.nom.BorderColor = System.Drawing.Color.SeaGreen;
            this.nom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(553, 196);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(176, 33);
            this.nom.TabIndex = 27;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Image = global::BiblioUI.Properties.Resources.gear;
            this.add.ImageActive = null;
            this.add.Location = new System.Drawing.Point(646, 390);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 71);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 37;
            this.add.TabStop = false;
            this.add.Zoom = 10;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ModifierEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 482);
            this.Controls.Add(this.add);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.email);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.niveau);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.specialite);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.matLable);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.numC);
            this.Controls.Add(this.nomLable);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.nomU);
            this.Controls.Add(this.titre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifierEtudiant";
            this.Text = "ModifierEtudiant";
            this.Load += new System.EventHandler(this.ModifierEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel titre;
        private Bunifu.Framework.UI.BunifuCustomLabel matLable;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox numC;
        private Bunifu.Framework.UI.BunifuCustomLabel nomLable;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox nomU;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox email;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox niveau;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox specialite;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox prenom;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox nom;
        private Bunifu.Framework.UI.BunifuImageButton add;
    }
}