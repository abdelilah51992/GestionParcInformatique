namespace GestionParcInformatique.View
{
    partial class InterventionsView
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
            this.cbRealisation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tmPlFin = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtPlFin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tmPlDebut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPLDebut = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tmFin = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRealisation
            // 
            this.cbRealisation.FormattingEnabled = true;
            this.cbRealisation.Items.AddRange(new object[] {
            "Interne",
            "Externe"});
            this.cbRealisation.Location = new System.Drawing.Point(195, 16);
            this.cbRealisation.Name = "cbRealisation";
            this.cbRealisation.Size = new System.Drawing.Size(215, 21);
            this.cbRealisation.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Réalisation";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 64;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(299, 267);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(111, 23);
            this.btnEnregistrer.TabIndex = 63;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tmPlFin);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtPlFin);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tmPlDebut);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtPLDebut);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 131);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les dates planifiées";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Heure Fin";
            // 
            // tmPlFin
            // 
            this.tmPlFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tmPlFin.Location = new System.Drawing.Point(182, 96);
            this.tmPlFin.Name = "tmPlFin";
            this.tmPlFin.Size = new System.Drawing.Size(215, 20);
            this.tmPlFin.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "Date Fin";
            // 
            // dtPlFin
            // 
            this.dtPlFin.Location = new System.Drawing.Point(182, 70);
            this.dtPlFin.Name = "dtPlFin";
            this.dtPlFin.Size = new System.Drawing.Size(215, 20);
            this.dtPlFin.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Heure debut";
            // 
            // tmPlDebut
            // 
            this.tmPlDebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tmPlDebut.Location = new System.Drawing.Point(183, 45);
            this.tmPlDebut.Name = "tmPlDebut";
            this.tmPlDebut.Size = new System.Drawing.Size(215, 20);
            this.tmPlDebut.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Date debut";
            // 
            // dtPLDebut
            // 
            this.dtPLDebut.Location = new System.Drawing.Point(183, 19);
            this.dtPLDebut.Name = "dtPLDebut";
            this.dtPLDebut.Size = new System.Drawing.Size(215, 20);
            this.dtPLDebut.TabIndex = 68;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tmFin);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtFin);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 83);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les dates réels";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "Heure fin";
            // 
            // tmFin
            // 
            this.tmFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tmFin.Location = new System.Drawing.Point(183, 45);
            this.tmFin.Name = "tmFin";
            this.tmFin.Size = new System.Drawing.Size(215, 20);
            this.tmFin.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "Date fin";
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(183, 19);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(215, 20);
            this.dtFin.TabIndex = 68;
            // 
            // InterventionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 296);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbRealisation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEnregistrer);
            this.Name = "InterventionsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion d\'Interventions";
            this.Load += new System.EventHandler(this.InterventionsView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRealisation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPLDebut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker tmPlFin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtPlFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker tmPlDebut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker tmFin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtFin;
    }
}