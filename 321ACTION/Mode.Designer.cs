namespace _321ACTION
{
    partial class Mode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mode));
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_play2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_play.BackgroundImage")));
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Location = new System.Drawing.Point(44, 58);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(228, 206);
            this.btn_play.TabIndex = 0;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_play2
            // 
            this.btn_play2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_play2.BackColor = System.Drawing.Color.Transparent;
            this.btn_play2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_play2.BackgroundImage")));
            this.btn_play2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play2.FlatAppearance.BorderSize = 0;
            this.btn_play2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play2.Location = new System.Drawing.Point(575, 58);
            this.btn_play2.Name = "btn_play2";
            this.btn_play2.Size = new System.Drawing.Size(228, 206);
            this.btn_play2.TabIndex = 0;
            this.btn_play2.UseVisualStyleBackColor = false;
            this.btn_play2.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 551);
            this.Controls.Add(this.btn_play2);
            this.Controls.Add(this.btn_play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mode";
            this.Text = "Start";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_play2;
    }
}