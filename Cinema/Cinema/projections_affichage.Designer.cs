namespace Cinema
{
    partial class projections_affichage
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
            this.lsb_projections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsb_projections
            // 
            this.lsb_projections.FormattingEnabled = true;
            this.lsb_projections.Location = new System.Drawing.Point(12, 12);
            this.lsb_projections.Name = "lsb_projections";
            this.lsb_projections.Size = new System.Drawing.Size(613, 277);
            this.lsb_projections.TabIndex = 0;
            // 
            // projections_affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 309);
            this.Controls.Add(this.lsb_projections);
            this.Name = "projections_affichage";
            this.Text = "Projections";
            this.Load += new System.EventHandler(this.projections_affichage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_projections;

    }
}