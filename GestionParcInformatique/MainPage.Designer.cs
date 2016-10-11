namespace GestionParcInformatique
{
    partial class MainPage
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramèresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonnelsTab = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGPersonnels = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRecrutementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.echelonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonctionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structureAffectationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPersonnelsSupprimer = new System.Windows.Forms.Button();
            this.Personnels_Modifier = new System.Windows.Forms.Button();
            this.Personnels_Ajouter = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgMateriels = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroEquipement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SousCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miseEnServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAcquisitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valeurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabriquantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tailleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nInventaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeVieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structureAffectationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materielVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnMaterielsModifier = new System.Windows.Forms.Button();
            this.btnMaterielAjouter = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGPannes = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panneVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInterventions = new System.Windows.Forms.Button();
            this.btnPannesSupprimer = new System.Windows.Forms.Button();
            this.btnPanneModifier = new System.Windows.Forms.Button();
            this.btnPannesAjouter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.PersonnelsTab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPersonnels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentVMBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielVMBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPannes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panneVMBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.paramèresToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // paramèresToolStripMenuItem
            // 
            this.paramèresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contratToolStripMenuItem});
            this.paramèresToolStripMenuItem.Name = "paramèresToolStripMenuItem";
            this.paramèresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.paramèresToolStripMenuItem.Text = "Paramètres";
            this.paramèresToolStripMenuItem.Click += new System.EventHandler(this.paramèresToolStripMenuItem_Click);
            // 
            // contratToolStripMenuItem
            // 
            this.contratToolStripMenuItem.Name = "contratToolStripMenuItem";
            this.contratToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.contratToolStripMenuItem.Text = "Contrats";
            this.contratToolStripMenuItem.Click += new System.EventHandler(this.contratToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // PersonnelsTab
            // 
            this.PersonnelsTab.Controls.Add(this.tabPage3);
            this.PersonnelsTab.Controls.Add(this.tabPage2);
            this.PersonnelsTab.Controls.Add(this.tabPage1);
            this.PersonnelsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonnelsTab.Location = new System.Drawing.Point(0, 24);
            this.PersonnelsTab.Name = "PersonnelsTab";
            this.PersonnelsTab.SelectedIndex = 0;
            this.PersonnelsTab.Size = new System.Drawing.Size(1012, 405);
            this.PersonnelsTab.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGPersonnels);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1004, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Personnels ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGPersonnels
            // 
            this.DGPersonnels.AutoGenerateColumns = false;
            this.DGPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPersonnels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.matriculeDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.dateRecrutementDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.echelonDataGridViewTextBoxColumn,
            this.fonctionDataGridViewTextBoxColumn,
            this.structureAffectationDataGridViewTextBoxColumn});
            this.DGPersonnels.DataSource = this.agentVMBindingSource;
            this.DGPersonnels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGPersonnels.Location = new System.Drawing.Point(0, 35);
            this.DGPersonnels.Name = "DGPersonnels";
            this.DGPersonnels.Size = new System.Drawing.Size(1004, 344);
            this.DGPersonnels.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Identiant";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // matriculeDataGridViewTextBoxColumn
            // 
            this.matriculeDataGridViewTextBoxColumn.DataPropertyName = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.HeaderText = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.Name = "matriculeDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // dateRecrutementDataGridViewTextBoxColumn
            // 
            this.dateRecrutementDataGridViewTextBoxColumn.DataPropertyName = "DateRecrutement";
            this.dateRecrutementDataGridViewTextBoxColumn.HeaderText = "Date de recrutement";
            this.dateRecrutementDataGridViewTextBoxColumn.Name = "dateRecrutementDataGridViewTextBoxColumn";
            this.dateRecrutementDataGridViewTextBoxColumn.Width = 150;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // echelonDataGridViewTextBoxColumn
            // 
            this.echelonDataGridViewTextBoxColumn.DataPropertyName = "Echelon";
            this.echelonDataGridViewTextBoxColumn.HeaderText = "Echelon";
            this.echelonDataGridViewTextBoxColumn.Name = "echelonDataGridViewTextBoxColumn";
            // 
            // fonctionDataGridViewTextBoxColumn
            // 
            this.fonctionDataGridViewTextBoxColumn.DataPropertyName = "Fonction";
            this.fonctionDataGridViewTextBoxColumn.HeaderText = "Fonction";
            this.fonctionDataGridViewTextBoxColumn.Name = "fonctionDataGridViewTextBoxColumn";
            this.fonctionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // structureAffectationDataGridViewTextBoxColumn
            // 
            this.structureAffectationDataGridViewTextBoxColumn.DataPropertyName = "StructureAffectation";
            this.structureAffectationDataGridViewTextBoxColumn.HeaderText = "Structure d\'affectation";
            this.structureAffectationDataGridViewTextBoxColumn.Name = "structureAffectationDataGridViewTextBoxColumn";
            this.structureAffectationDataGridViewTextBoxColumn.ReadOnly = true;
            this.structureAffectationDataGridViewTextBoxColumn.Width = 150;
            // 
            // agentVMBindingSource
            // 
            this.agentVMBindingSource.DataSource = typeof(GestionParcInformatique.ViewModel.AgentVM);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPersonnelsSupprimer);
            this.panel1.Controls.Add(this.Personnels_Modifier);
            this.panel1.Controls.Add(this.Personnels_Ajouter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnPersonnelsSupprimer
            // 
            this.btnPersonnelsSupprimer.Location = new System.Drawing.Point(170, 9);
            this.btnPersonnelsSupprimer.Name = "btnPersonnelsSupprimer";
            this.btnPersonnelsSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnPersonnelsSupprimer.TabIndex = 2;
            this.btnPersonnelsSupprimer.Text = "Supprimer";
            this.btnPersonnelsSupprimer.UseVisualStyleBackColor = true;
            this.btnPersonnelsSupprimer.Click += new System.EventHandler(this.btnPersonnelsSupprimer_Click);
            // 
            // Personnels_Modifier
            // 
            this.Personnels_Modifier.Location = new System.Drawing.Point(89, 9);
            this.Personnels_Modifier.Name = "Personnels_Modifier";
            this.Personnels_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Personnels_Modifier.TabIndex = 1;
            this.Personnels_Modifier.Text = "Modifier";
            this.Personnels_Modifier.UseVisualStyleBackColor = true;
            this.Personnels_Modifier.Click += new System.EventHandler(this.Personnels_Modifier_Click);
            // 
            // Personnels_Ajouter
            // 
            this.Personnels_Ajouter.Location = new System.Drawing.Point(8, 9);
            this.Personnels_Ajouter.Name = "Personnels_Ajouter";
            this.Personnels_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Personnels_Ajouter.TabIndex = 0;
            this.Personnels_Ajouter.Text = "Ajouter";
            this.Personnels_Ajouter.UseVisualStyleBackColor = true;
            this.Personnels_Ajouter.Click += new System.EventHandler(this.Personnels_Ajouter_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgMateriels);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1004, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Materiels";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgMateriels
            // 
            this.dgMateriels.AutoGenerateColumns = false;
            this.dgMateriels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMateriels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.NumeroEquipement,
            this.designationDataGridViewTextBoxColumn,
            this.Categorie,
            this.SousCategorie,
            this.panneTypeDataGridViewTextBoxColumn,
            this.miseEnServiceDataGridViewTextBoxColumn,
            this.dateAcquisitionDataGridViewTextBoxColumn,
            this.valeurDataGridViewTextBoxColumn,
            this.fabriquantDataGridViewTextBoxColumn,
            this.poidsDataGridViewTextBoxColumn,
            this.tailleDataGridViewTextBoxColumn,
            this.nInventaireDataGridViewTextBoxColumn,
            this.nSerieDataGridViewTextBoxColumn,
            this.dureeVieDataGridViewTextBoxColumn,
            this.structureAffectationDataGridViewTextBoxColumn1});
            this.dgMateriels.DataSource = this.materielVMBindingSource;
            this.dgMateriels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMateriels.Location = new System.Drawing.Point(3, 38);
            this.dgMateriels.Name = "dgMateriels";
            this.dgMateriels.Size = new System.Drawing.Size(998, 338);
            this.dgMateriels.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "Identifiant";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // NumeroEquipement
            // 
            this.NumeroEquipement.DataPropertyName = "NumeroEquipement";
            this.NumeroEquipement.HeaderText = "Numero équipement";
            this.NumeroEquipement.Name = "NumeroEquipement";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Désignation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // Categorie
            // 
            this.Categorie.DataPropertyName = "Categorie";
            this.Categorie.HeaderText = "Catégorie";
            this.Categorie.Name = "Categorie";
            this.Categorie.ReadOnly = true;
            // 
            // SousCategorie
            // 
            this.SousCategorie.DataPropertyName = "SousCategorie";
            this.SousCategorie.HeaderText = "Sous catégorie";
            this.SousCategorie.Name = "SousCategorie";
            this.SousCategorie.ReadOnly = true;
            // 
            // panneTypeDataGridViewTextBoxColumn
            // 
            this.panneTypeDataGridViewTextBoxColumn.DataPropertyName = "PanneType";
            this.panneTypeDataGridViewTextBoxColumn.HeaderText = "Statu";
            this.panneTypeDataGridViewTextBoxColumn.Name = "panneTypeDataGridViewTextBoxColumn";
            this.panneTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miseEnServiceDataGridViewTextBoxColumn
            // 
            this.miseEnServiceDataGridViewTextBoxColumn.DataPropertyName = "MiseEnService";
            this.miseEnServiceDataGridViewTextBoxColumn.HeaderText = "Date mise en service";
            this.miseEnServiceDataGridViewTextBoxColumn.Name = "miseEnServiceDataGridViewTextBoxColumn";
            // 
            // dateAcquisitionDataGridViewTextBoxColumn
            // 
            this.dateAcquisitionDataGridViewTextBoxColumn.DataPropertyName = "DateAcquisition";
            this.dateAcquisitionDataGridViewTextBoxColumn.HeaderText = "Date d\'acquisition";
            this.dateAcquisitionDataGridViewTextBoxColumn.Name = "dateAcquisitionDataGridViewTextBoxColumn";
            // 
            // valeurDataGridViewTextBoxColumn
            // 
            this.valeurDataGridViewTextBoxColumn.DataPropertyName = "Valeur";
            this.valeurDataGridViewTextBoxColumn.HeaderText = "Valeur d\'acquisition en dhs";
            this.valeurDataGridViewTextBoxColumn.Name = "valeurDataGridViewTextBoxColumn";
            // 
            // fabriquantDataGridViewTextBoxColumn
            // 
            this.fabriquantDataGridViewTextBoxColumn.DataPropertyName = "Fabriquant";
            this.fabriquantDataGridViewTextBoxColumn.HeaderText = "Fabriquant";
            this.fabriquantDataGridViewTextBoxColumn.Name = "fabriquantDataGridViewTextBoxColumn";
            // 
            // poidsDataGridViewTextBoxColumn
            // 
            this.poidsDataGridViewTextBoxColumn.DataPropertyName = "Poids";
            this.poidsDataGridViewTextBoxColumn.HeaderText = "Poids";
            this.poidsDataGridViewTextBoxColumn.Name = "poidsDataGridViewTextBoxColumn";
            // 
            // tailleDataGridViewTextBoxColumn
            // 
            this.tailleDataGridViewTextBoxColumn.DataPropertyName = "Taille";
            this.tailleDataGridViewTextBoxColumn.HeaderText = "Taille";
            this.tailleDataGridViewTextBoxColumn.Name = "tailleDataGridViewTextBoxColumn";
            // 
            // nInventaireDataGridViewTextBoxColumn
            // 
            this.nInventaireDataGridViewTextBoxColumn.DataPropertyName = "NInventaire";
            this.nInventaireDataGridViewTextBoxColumn.HeaderText = "N° d\'inventaire";
            this.nInventaireDataGridViewTextBoxColumn.Name = "nInventaireDataGridViewTextBoxColumn";
            // 
            // nSerieDataGridViewTextBoxColumn
            // 
            this.nSerieDataGridViewTextBoxColumn.DataPropertyName = "NSerie";
            this.nSerieDataGridViewTextBoxColumn.HeaderText = "N° de série";
            this.nSerieDataGridViewTextBoxColumn.Name = "nSerieDataGridViewTextBoxColumn";
            // 
            // dureeVieDataGridViewTextBoxColumn
            // 
            this.dureeVieDataGridViewTextBoxColumn.DataPropertyName = "DureeVie";
            this.dureeVieDataGridViewTextBoxColumn.HeaderText = "Durée de vie";
            this.dureeVieDataGridViewTextBoxColumn.Name = "dureeVieDataGridViewTextBoxColumn";
            // 
            // structureAffectationDataGridViewTextBoxColumn1
            // 
            this.structureAffectationDataGridViewTextBoxColumn1.DataPropertyName = "StructureAffectation";
            this.structureAffectationDataGridViewTextBoxColumn1.HeaderText = "Entité d\'affectations";
            this.structureAffectationDataGridViewTextBoxColumn1.Name = "structureAffectationDataGridViewTextBoxColumn1";
            this.structureAffectationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // materielVMBindingSource
            // 
            this.materielVMBindingSource.DataSource = typeof(GestionParcInformatique.ViewModel.MaterielVM);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSupprimer);
            this.panel2.Controls.Add(this.btnMaterielsModifier);
            this.panel2.Controls.Add(this.btnMaterielAjouter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 35);
            this.panel2.TabIndex = 1;
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
            // btnMaterielsModifier
            // 
            this.btnMaterielsModifier.Location = new System.Drawing.Point(89, 9);
            this.btnMaterielsModifier.Name = "btnMaterielsModifier";
            this.btnMaterielsModifier.Size = new System.Drawing.Size(75, 23);
            this.btnMaterielsModifier.TabIndex = 1;
            this.btnMaterielsModifier.Text = "Modifier";
            this.btnMaterielsModifier.UseVisualStyleBackColor = true;
            this.btnMaterielsModifier.Click += new System.EventHandler(this.btnMaterielsModifier_Click);
            // 
            // btnMaterielAjouter
            // 
            this.btnMaterielAjouter.Location = new System.Drawing.Point(8, 9);
            this.btnMaterielAjouter.Name = "btnMaterielAjouter";
            this.btnMaterielAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnMaterielAjouter.TabIndex = 0;
            this.btnMaterielAjouter.Text = "Ajouter";
            this.btnMaterielAjouter.UseVisualStyleBackColor = true;
            this.btnMaterielAjouter.Click += new System.EventHandler(this.btnMaterielAjouter_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGPannes);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pannes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGPannes
            // 
            this.DGPannes.AutoGenerateColumns = false;
            this.DGPannes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPannes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.materielDataGridViewTextBoxColumn,
            this.causeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.finDataGridViewTextBoxColumn});
            this.DGPannes.DataSource = this.panneVMBindingSource;
            this.DGPannes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGPannes.Location = new System.Drawing.Point(3, 38);
            this.DGPannes.Name = "DGPannes";
            this.DGPannes.Size = new System.Drawing.Size(998, 338);
            this.DGPannes.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // materielDataGridViewTextBoxColumn
            // 
            this.materielDataGridViewTextBoxColumn.DataPropertyName = "Materiel";
            this.materielDataGridViewTextBoxColumn.HeaderText = "Materiel";
            this.materielDataGridViewTextBoxColumn.Name = "materielDataGridViewTextBoxColumn";
            this.materielDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // causeDataGridViewTextBoxColumn
            // 
            this.causeDataGridViewTextBoxColumn.DataPropertyName = "Cause";
            this.causeDataGridViewTextBoxColumn.HeaderText = "Cause";
            this.causeDataGridViewTextBoxColumn.Name = "causeDataGridViewTextBoxColumn";
            this.causeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date et Heure Panne";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finDataGridViewTextBoxColumn
            // 
            this.finDataGridViewTextBoxColumn.DataPropertyName = "Fin";
            this.finDataGridViewTextBoxColumn.HeaderText = "Date et Heure Fin";
            this.finDataGridViewTextBoxColumn.Name = "finDataGridViewTextBoxColumn";
            this.finDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panneVMBindingSource
            // 
            this.panneVMBindingSource.DataSource = typeof(GestionParcInformatique.ViewModel.PanneVM);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnInterventions);
            this.panel3.Controls.Add(this.btnPannesSupprimer);
            this.panel3.Controls.Add(this.btnPanneModifier);
            this.panel3.Controls.Add(this.btnPannesAjouter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 35);
            this.panel3.TabIndex = 2;
            // 
            // btnInterventions
            // 
            this.btnInterventions.Location = new System.Drawing.Point(251, 9);
            this.btnInterventions.Name = "btnInterventions";
            this.btnInterventions.Size = new System.Drawing.Size(75, 23);
            this.btnInterventions.TabIndex = 3;
            this.btnInterventions.Text = "Interventions";
            this.btnInterventions.UseVisualStyleBackColor = true;
            this.btnInterventions.Click += new System.EventHandler(this.btnInterventions_Click);
            // 
            // btnPannesSupprimer
            // 
            this.btnPannesSupprimer.Location = new System.Drawing.Point(170, 9);
            this.btnPannesSupprimer.Name = "btnPannesSupprimer";
            this.btnPannesSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnPannesSupprimer.TabIndex = 2;
            this.btnPannesSupprimer.Text = "Supprimer";
            this.btnPannesSupprimer.UseVisualStyleBackColor = true;
            this.btnPannesSupprimer.Click += new System.EventHandler(this.btnPannesSupprimer_Click);
            // 
            // btnPanneModifier
            // 
            this.btnPanneModifier.Location = new System.Drawing.Point(89, 9);
            this.btnPanneModifier.Name = "btnPanneModifier";
            this.btnPanneModifier.Size = new System.Drawing.Size(75, 23);
            this.btnPanneModifier.TabIndex = 1;
            this.btnPanneModifier.Text = "Modifier";
            this.btnPanneModifier.UseVisualStyleBackColor = true;
            this.btnPanneModifier.Click += new System.EventHandler(this.btnPanneModifier_Click);
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
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 429);
            this.Controls.Add(this.PersonnelsTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application de gestion de parc informatique";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PersonnelsTab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGPersonnels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentVMBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielVMBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGPannes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panneVMBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramèresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.TabControl PersonnelsTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGPersonnels;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPersonnelsSupprimer;
        private System.Windows.Forms.Button Personnels_Modifier;
        private System.Windows.Forms.Button Personnels_Ajouter;
        private System.Windows.Forms.BindingSource agentVMBindingSource;
        private System.Windows.Forms.ToolStripMenuItem contratToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRecrutementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn echelonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonctionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn structureAffectationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgMateriels;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnMaterielsModifier;
        private System.Windows.Forms.Button btnMaterielAjouter;
        private System.Windows.Forms.DataGridView DGPannes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPannesSupprimer;
        private System.Windows.Forms.Button btnPanneModifier;
        private System.Windows.Forms.Button btnPannesAjouter;
        private System.Windows.Forms.BindingSource materielVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn materielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn causeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource panneVMBindingSource;
        private System.Windows.Forms.Button btnInterventions;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroEquipement;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn SousCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn panneTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miseEnServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAcquisitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valeurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabriquantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tailleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nInventaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeVieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn structureAffectationDataGridViewTextBoxColumn1;
    }
}

