namespace Cinema
{
    partial class Home
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
            this.cbxFilms = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxSceance = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneSalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerFilmsDunFichierCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionerProjectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterProjectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnValider = new System.Windows.Forms.Button();
            this.pnl_salle = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxFilms
            // 
            this.cbxFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilms.FormattingEnabled = true;
            this.cbxFilms.Location = new System.Drawing.Point(12, 42);
            this.cbxFilms.Name = "cbxFilms";
            this.cbxFilms.Size = new System.Drawing.Size(121, 21);
            this.cbxFilms.TabIndex = 0;
            this.cbxFilms.SelectedIndexChanged += new System.EventHandler(this.cbxFilms_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 43);
            this.dateTimePicker1.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2015, 3, 17, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbxSceance
            // 
            this.cbxSceance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSceance.Enabled = false;
            this.cbxSceance.FormattingEnabled = true;
            this.cbxSceance.Location = new System.Drawing.Point(341, 42);
            this.cbxSceance.Name = "cbxSceance";
            this.cbxSceance.Size = new System.Drawing.Size(121, 21);
            this.cbxSceance.TabIndex = 2;
            this.cbxSceance.SelectedIndexChanged += new System.EventHandler(this.cbxSceance_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.projectionsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneSalleToolStripMenuItem,
            this.importerFilmsDunFichierCsvToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterUneSalleToolStripMenuItem
            // 
            this.ajouterUneSalleToolStripMenuItem.Name = "ajouterUneSalleToolStripMenuItem";
            this.ajouterUneSalleToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.ajouterUneSalleToolStripMenuItem.Text = "Importer salles d\'un fichier csv";
            this.ajouterUneSalleToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneSalleToolStripMenuItem_Click);
            // 
            // importerFilmsDunFichierCsvToolStripMenuItem
            // 
            this.importerFilmsDunFichierCsvToolStripMenuItem.Name = "importerFilmsDunFichierCsvToolStripMenuItem";
            this.importerFilmsDunFichierCsvToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.importerFilmsDunFichierCsvToolStripMenuItem.Text = "Importer films d\'un fichier csv";
            this.importerFilmsDunFichierCsvToolStripMenuItem.Click += new System.EventHandler(this.importerFilmsDunFichierCsvToolStripMenuItem_Click);
            // 
            // projectionsToolStripMenuItem
            // 
            this.projectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionerProjectionsToolStripMenuItem,
            this.ajouterProjectionToolStripMenuItem});
            this.projectionsToolStripMenuItem.Name = "projectionsToolStripMenuItem";
            this.projectionsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.projectionsToolStripMenuItem.Text = "Projections";
            // 
            // visionerProjectionsToolStripMenuItem
            // 
            this.visionerProjectionsToolStripMenuItem.Name = "visionerProjectionsToolStripMenuItem";
            this.visionerProjectionsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.visionerProjectionsToolStripMenuItem.Text = "Afficher projections";
            this.visionerProjectionsToolStripMenuItem.Click += new System.EventHandler(this.visionerProjectionsToolStripMenuItem_Click);
            // 
            // ajouterProjectionToolStripMenuItem
            // 
            this.ajouterProjectionToolStripMenuItem.Name = "ajouterProjectionToolStripMenuItem";
            this.ajouterProjectionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ajouterProjectionToolStripMenuItem.Text = "Ajouter projection";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(720, 614);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // pnl_salle
            // 
            this.pnl_salle.Location = new System.Drawing.Point(12, 69);
            this.pnl_salle.Name = "pnl_salle";
            this.pnl_salle.Size = new System.Drawing.Size(795, 539);
            this.pnl_salle.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 649);
            this.Controls.Add(this.pnl_salle);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cbxSceance);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbxFilms);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Cinema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFilms;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxSceance;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneSalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ToolStripMenuItem importerFilmsDunFichierCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionerProjectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterProjectionToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_salle;
    }
}

