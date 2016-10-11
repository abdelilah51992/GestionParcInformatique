namespace GestionParcInformatique.View
{
    partial class PanneView
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
            this.cbCausePanne = new System.Windows.Forms.ComboBox();
            this.dtPanne = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cbEquipement = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSousCategorie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tmPanne = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tmFinPanne = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFinPanne = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCausePanne
            // 
            this.cbCausePanne.FormattingEnabled = true;
            this.cbCausePanne.Location = new System.Drawing.Point(183, 144);
            this.cbCausePanne.Name = "cbCausePanne";
            this.cbCausePanne.Size = new System.Drawing.Size(215, 21);
            this.cbCausePanne.TabIndex = 46;
            // 
            // dtPanne
            // 
            this.dtPanne.Location = new System.Drawing.Point(183, 92);
            this.dtPanne.Name = "dtPanne";
            this.dtPanne.Size = new System.Drawing.Size(215, 20);
            this.dtPanne.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Date de la panne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cause panne";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(287, 222);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(111, 23);
            this.btnEnregistrer.TabIndex = 49;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // cbEquipement
            // 
            this.cbEquipement.FormattingEnabled = true;
            this.cbEquipement.Location = new System.Drawing.Point(183, 65);
            this.cbEquipement.Name = "cbEquipement";
            this.cbEquipement.Size = new System.Drawing.Size(215, 21);
            this.cbEquipement.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Equipement";
            // 
            // cbSousCategorie
            // 
            this.cbSousCategorie.FormattingEnabled = true;
            this.cbSousCategorie.Location = new System.Drawing.Point(183, 41);
            this.cbSousCategorie.Name = "cbSousCategorie";
            this.cbSousCategorie.Size = new System.Drawing.Size(215, 21);
            this.cbSousCategorie.TabIndex = 54;
            this.cbSousCategorie.SelectedIndexChanged += new System.EventHandler(this.cbSousCategorie_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Sous Catégorie";
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(183, 17);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(215, 21);
            this.cbCategorie.TabIndex = 56;
            this.cbCategorie.SelectedIndexChanged += new System.EventHandler(this.cbCategorie_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Catégorie";
            // 
            // tmPanne
            // 
            this.tmPanne.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tmPanne.Location = new System.Drawing.Point(183, 118);
            this.tmPanne.Name = "tmPanne";
            this.tmPanne.Size = new System.Drawing.Size(215, 20);
            this.tmPanne.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Heure de la panne";
            // 
            // tmFinPanne
            // 
            this.tmFinPanne.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tmFinPanne.Location = new System.Drawing.Point(183, 196);
            this.tmFinPanne.Name = "tmFinPanne";
            this.tmFinPanne.Size = new System.Drawing.Size(215, 20);
            this.tmFinPanne.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Heure fin de la panne";
            // 
            // dtFinPanne
            // 
            this.dtFinPanne.Location = new System.Drawing.Point(183, 170);
            this.dtFinPanne.Name = "dtFinPanne";
            this.dtFinPanne.Size = new System.Drawing.Size(215, 20);
            this.dtFinPanne.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Date fin de la panne";
            // 
            // PanneView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 257);
            this.Controls.Add(this.tmFinPanne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFinPanne);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tmPanne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSousCategorie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEquipement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.cbCausePanne);
            this.Controls.Add(this.dtPanne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "PanneView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestions de panne";
            this.Load += new System.EventHandler(this.PanneView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCausePanne;
        private System.Windows.Forms.DateTimePicker dtPanne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ComboBox cbEquipement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSousCategorie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker tmPanne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker tmFinPanne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFinPanne;
        private System.Windows.Forms.Label label8;
    }
}