﻿namespace BiblioUI
{
    partial class Enseignant
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chercherEnseignant = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.set = new Bunifu.Framework.UI.BunifuImageButton();
            this.add = new Bunifu.Framework.UI.BunifuImageButton();
            this.GridEnseignant = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.NomUtilisateurCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatreculeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEnseignant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chercherEnseignant);
            this.panel1.Controls.Add(this.set);
            this.panel1.Controls.Add(this.add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 166);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioUI.Properties.Resources.search__1_;
            this.pictureBox1.Location = new System.Drawing.Point(380, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // chercherEnseignant
            // 
            this.chercherEnseignant.BorderColor = System.Drawing.Color.SeaGreen;
            this.chercherEnseignant.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chercherEnseignant.Location = new System.Drawing.Point(436, 114);
            this.chercherEnseignant.Name = "chercherEnseignant";
            this.chercherEnseignant.Size = new System.Drawing.Size(244, 33);
            this.chercherEnseignant.TabIndex = 3;
            this.chercherEnseignant.TextChanged += new System.EventHandler(this.chercherEnseignant_TextChanged);
            // 
            // set
            // 
            this.set.BackColor = System.Drawing.Color.White;
            this.set.Image = global::BiblioUI.Properties.Resources.gear;
            this.set.ImageActive = null;
            this.set.Location = new System.Drawing.Point(580, 12);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(71, 71);
            this.set.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.set.TabIndex = 1;
            this.set.TabStop = false;
            this.set.Zoom = 10;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Image = global::BiblioUI.Properties.Resources.add;
            this.add.ImageActive = null;
            this.add.Location = new System.Drawing.Point(405, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 71);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 0;
            this.add.TabStop = false;
            this.add.Zoom = 10;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // GridEnseignant
            // 
            this.GridEnseignant.AllowUserToAddRows = false;
            this.GridEnseignant.AllowUserToDeleteRows = false;
            this.GridEnseignant.AllowUserToResizeColumns = false;
            this.GridEnseignant.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridEnseignant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridEnseignant.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridEnseignant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridEnseignant.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEnseignant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridEnseignant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEnseignant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomUtilisateurCol,
            this.MatreculeCol,
            this.NomCol,
            this.PrenomCol,
            this.GradeCol,
            this.EmailCol});
            this.GridEnseignant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEnseignant.DoubleBuffered = true;
            this.GridEnseignant.EnableHeadersVisualStyles = false;
            this.GridEnseignant.HeaderBgColor = System.Drawing.Color.SkyBlue;
            this.GridEnseignant.HeaderForeColor = System.Drawing.Color.White;
            this.GridEnseignant.Location = new System.Drawing.Point(0, 166);
            this.GridEnseignant.Name = "GridEnseignant";
            this.GridEnseignant.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridEnseignant.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridEnseignant.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.GridEnseignant.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridEnseignant.RowTemplate.Height = 40;
            this.GridEnseignant.Size = new System.Drawing.Size(953, 324);
            this.GridEnseignant.TabIndex = 2;
            // 
            // NomUtilisateurCol
            // 
            this.NomUtilisateurCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomUtilisateurCol.DataPropertyName = "1";
            this.NomUtilisateurCol.HeaderText = "Nom Utilisateur";
            this.NomUtilisateurCol.Name = "NomUtilisateurCol";
            this.NomUtilisateurCol.ReadOnly = true;
            // 
            // MatreculeCol
            // 
            this.MatreculeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatreculeCol.DataPropertyName = "2";
            this.MatreculeCol.HeaderText = "Matrecule";
            this.MatreculeCol.Name = "MatreculeCol";
            this.MatreculeCol.ReadOnly = true;
            // 
            // NomCol
            // 
            this.NomCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomCol.DataPropertyName = "3";
            this.NomCol.HeaderText = "Nom";
            this.NomCol.Name = "NomCol";
            this.NomCol.ReadOnly = true;
            // 
            // PrenomCol
            // 
            this.PrenomCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrenomCol.DataPropertyName = "4";
            this.PrenomCol.HeaderText = "Prenom";
            this.PrenomCol.Name = "PrenomCol";
            this.PrenomCol.ReadOnly = true;
            // 
            // GradeCol
            // 
            this.GradeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GradeCol.DataPropertyName = "5";
            this.GradeCol.HeaderText = "Grade";
            this.GradeCol.Name = "GradeCol";
            this.GradeCol.ReadOnly = true;
            // 
            // EmailCol
            // 
            this.EmailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailCol.DataPropertyName = "6";
            this.EmailCol.HeaderText = "Email";
            this.EmailCol.Name = "EmailCol";
            this.EmailCol.ReadOnly = true;
            // 
            // Enseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GridEnseignant);
            this.Controls.Add(this.panel1);
            this.Name = "Enseignant";
            this.Size = new System.Drawing.Size(953, 490);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEnseignant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox chercherEnseignant;
        private Bunifu.Framework.UI.BunifuImageButton set;
        private Bunifu.Framework.UI.BunifuImageButton add;
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridEnseignant;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomUtilisateurCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatreculeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCol;
    }
}
