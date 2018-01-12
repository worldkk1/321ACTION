namespace _321ACTION
{
    partial class ShowScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowScore));
            this.label_score = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_score
            // 
            this.label_score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("label_score.BackgroundImage")));
            this.label_score.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.label_score.FlatAppearance.BorderSize = 0;
            this.label_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_score.Location = new System.Drawing.Point(297, 23);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(279, 171);
            this.label_score.TabIndex = 0;
            this.label_score.UseVisualStyleBackColor = false;
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_menu.BackgroundImage")));
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_menu.Location = new System.Drawing.Point(46, 439);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(135, 141);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_restart.BackColor = System.Drawing.Color.Transparent;
            this.btn_restart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_restart.BackgroundImage")));
            this.btn_restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_restart.FlatAppearance.BorderSize = 0;
            this.btn_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_restart.Location = new System.Drawing.Point(46, 292);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(135, 141);
            this.btn_restart.TabIndex = 0;
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // ShowScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 619);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.label_score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowScore";
            this.Text = "ShowScore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShowScore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button label_score;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_restart;
    }
}