namespace Cinema
{
    partial class loading
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
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_current = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(202, 56);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(35, 13);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "label1";
            // 
            // lbl_current
            // 
            this.lbl_current.AutoSize = true;
            this.lbl_current.Location = new System.Drawing.Point(116, 56);
            this.lbl_current.Name = "lbl_current";
            this.lbl_current.Size = new System.Drawing.Size(35, 13);
            this.lbl_current.TabIndex = 1;
            this.lbl_current.Text = "label2";
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 112);
            this.Controls.Add(this.lbl_current);
            this.Controls.Add(this.lbl_total);
            this.Name = "loading";
            this.Text = "loading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_current;
    }
}