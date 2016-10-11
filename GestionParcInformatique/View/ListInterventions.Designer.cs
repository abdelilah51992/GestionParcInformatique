namespace GestionParcInformatique.View
{
    partial class ListInterventions
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnPannesAjouter = new System.Windows.Forms.Button();
            this.DGInterventions = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinPalnifieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinRealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interventionVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGInterventions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSupprimer);
            this.panel3.Controls.Add(this.btnModifier);
            this.panel3.Controls.Add(this.btnPannesAjouter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 35);
            this.panel3.TabIndex = 3;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(170, 9);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(89, 9);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnPannesAjouter
            // 
            this.btnPannesAjouter.Location = new System.Drawing.Point(8, 9);
            this.btnPannesAjouter.Name = "btnPannesAjouter";
            this.btnPannesAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnPannesAjouter.TabIndex = 0;
            this.btnPannesAjouter.Text = "Ajouter";
            this.btnPannesAjouter.UseVisualStyleBackColor = true;
            this.btnPannesAjouter.Click += new System.EventHandler(this.btnPannesAjouter_Click);
            // 
            // DGInterventions
            // 
            this.DGInterventions.AutoGenerateColumns = false;
            this.DGInterventions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInterventions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.realisationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.dateFinPalnifieDataGridViewTextBoxColumn,
            this.dateFinRealDataGridViewTextBoxColumn});
            this.DGInterventions.DataSource = this.interventionVMBindingSource;
            this.DGInterventions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGInterventions.Location = new System.Drawing.Point(0, 35);
            this.DGInterventions.Name = "DGInterventions";
            this.DGInterventions.Size = new System.Drawing.Size(645, 265);
            this.DGInterventions.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // realisationDataGridViewTextBoxColumn
            // 
            this.realisationDataGridViewTextBoxColumn.DataPropertyName = "Realisation";
            this.realisationDataGridViewTextBoxColumn.HeaderText = "Réalisation";
            this.realisationDataGridViewTextBoxColumn.Name = "realisationDataGridViewTextBoxColumn";
            this.realisationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date debut planifié";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateFinPalnifieDataGridViewTextBoxColumn
            // 
            this.dateFinPalnifieDataGridViewTextBoxColumn.DataPropertyName = "DateFinPalnifie";
            this.dateFinPalnifieDataGridViewTextBoxColumn.HeaderText = "Date fin palnifié";
            this.dateFinPalnifieDataGridViewTextBoxColumn.Name = "dateFinPalnifieDataGridViewTextBoxColumn";
            this.dateFinPalnifieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateFinRealDataGridViewTextBoxColumn
            // 
            this.dateFinRealDataGridViewTextBoxColumn.DataPropertyName = "DateFinReal";
            this.dateFinRealDataGridViewTextBoxColumn.HeaderText = "Date fin réal";
            this.dateFinRealDataGridViewTextBoxColumn.Name = "dateFinRealDataGridViewTextBoxColumn";
            this.dateFinRealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interventionVMBindingSource
            // 
            this.interventionVMBindingSource.DataSource = typeof(GestionParcInformatique.ViewModel.InterventionVM);
            // 
            // ListInterventions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 300);
            this.Controls.Add(this.DGInterventions);
            this.Controls.Add(this.panel3);
            this.Name = "ListInterventions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListInterventions";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGInterventions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnPannesAjouter;
        private System.Windows.Forms.DataGridView DGInterventions;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realisationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinPalnifieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinRealDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource interventionVMBindingSource;
    }
}