namespace GestionAD
{
    partial class fm_listUsers
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
            this.dg_listusers = new System.Windows.Forms.DataGridView();
            this.lb_domain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_listusers)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_listusers
            // 
            this.dg_listusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_listusers.Location = new System.Drawing.Point(12, 96);
            this.dg_listusers.Name = "dg_listusers";
            this.dg_listusers.Size = new System.Drawing.Size(725, 315);
            this.dg_listusers.TabIndex = 0;
            // 
            // lb_domain
            // 
            this.lb_domain.AutoSize = true;
            this.lb_domain.Location = new System.Drawing.Point(356, 55);
            this.lb_domain.Name = "lb_domain";
            this.lb_domain.Size = new System.Drawing.Size(35, 13);
            this.lb_domain.TabIndex = 1;
            this.lb_domain.Text = "label1";
            // 
            // fm_listUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 423);
            this.Controls.Add(this.lb_domain);
            this.Controls.Add(this.dg_listusers);
            this.Name = "fm_listUsers";
            this.Text = "Liste des utilisateurs";
            this.Load += new System.EventHandler(this.fm_listUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_listusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_listusers;
        private System.Windows.Forms.Label lb_domain;
    }
}