namespace GestionParcInformatique.View
{
    partial class ListContratView
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgListContrat = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroContratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raisonSocialeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListContrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(175, 13);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(94, 13);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(13, 13);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgListContrat
            // 
            this.dgListContrat.AutoGenerateColumns = false;
            this.dgListContrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListContrat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.numeroContratDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.finDataGridViewTextBoxColumn,
            this.codeFournisseurDataGridViewTextBoxColumn,
            this.raisonSocialeDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn});
            this.dgListContrat.DataSource = this.contratVMBindingSource;
            this.dgListContrat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListContrat.Location = new System.Drawing.Point(0, 43);
            this.dgListContrat.Name = "dgListContrat";
            this.dgListContrat.Size = new System.Drawing.Size(856, 336);
            this.dgListContrat.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // numeroContratDataGridViewTextBoxColumn
            // 
            this.numeroContratDataGridViewTextBoxColumn.DataPropertyName = "NumeroContrat";
            this.numeroContratDataGridViewTextBoxColumn.HeaderText = "N° du contrat";
            this.numeroContratDataGridViewTextBoxColumn.Name = "numeroContratDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date du contrat";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // finDataGridViewTextBoxColumn
            // 
            this.finDataGridViewTextBoxColumn.DataPropertyName = "Fin";
            this.finDataGridViewTextBoxColumn.HeaderText = "DateFin du contrat";
            this.finDataGridViewTextBoxColumn.Name = "finDataGridViewTextBoxColumn";
            // 
            // codeFournisseurDataGridViewTextBoxColumn
            // 
            this.codeFournisseurDataGridViewTextBoxColumn.DataPropertyName = "CodeFournisseur";
            this.codeFournisseurDataGridViewTextBoxColumn.HeaderText = "Code Fournisseur";
            this.codeFournisseurDataGridViewTextBoxColumn.Name = "codeFournisseurDataGridViewTextBoxColumn";
            // 
            // raisonSocialeDataGridViewTextBoxColumn
            // 
            this.raisonSocialeDataGridViewTextBoxColumn.DataPropertyName = "RaisonSociale";
            this.raisonSocialeDataGridViewTextBoxColumn.HeaderText = "Raison sociale";
            this.raisonSocialeDataGridViewTextBoxColumn.Name = "raisonSocialeDataGridViewTextBoxColumn";
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "Montant";
            this.montantDataGridViewTextBoxColumn.HeaderText = "Montant du contrat";
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            // 
            // contratVMBindingSource
            // 
            this.contratVMBindingSource.DataSource = typeof(GestionParcInformatique.ViewModel.ContratVM);
            // 
            // ListContratView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 379);
            this.Controls.Add(this.dgListContrat);
            this.Controls.Add(this.panel1);
            this.Name = "ListContratView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste contrat";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListContrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgListContrat;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroContratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raisonSocialeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contratVMBindingSource;
    }
}