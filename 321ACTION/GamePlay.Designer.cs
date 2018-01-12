namespace _321ACTION
{
    partial class GamePlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlay));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.time_start = new System.Windows.Forms.Timer(this.components);
            this.start_label = new System.Windows.Forms.PictureBox();
            this.pb_motion = new System.Windows.Forms.PictureBox();
            this.pb_question = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_go = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.time_play = new System.Windows.Forms.Timer(this.components);
            this.label_time = new System.Windows.Forms.Label();
            this.label_round = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_setup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_motion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(731, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // time_start
            // 
            this.time_start.Interval = 1000;
            this.time_start.Tick += new System.EventHandler(this.time_start_Tick);
            // 
            // start_label
            // 
            this.start_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start_label.Image = ((System.Drawing.Image)(resources.GetObject("start_label.Image")));
            this.start_label.Location = new System.Drawing.Point(0, 0);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(731, 433);
            this.start_label.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start_label.TabIndex = 1;
            this.start_label.TabStop = false;
            // 
            // pb_motion
            // 
            this.pb_motion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_motion.Location = new System.Drawing.Point(0, 0);
            this.pb_motion.Name = "pb_motion";
            this.pb_motion.Size = new System.Drawing.Size(731, 433);
            this.pb_motion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_motion.TabIndex = 2;
            this.pb_motion.TabStop = false;
            this.pb_motion.Visible = false;
            // 
            // pb_question
            // 
            this.pb_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_question.Location = new System.Drawing.Point(0, 0);
            this.pb_question.Name = "pb_question";
            this.pb_question.Size = new System.Drawing.Size(731, 433);
            this.pb_question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_question.TabIndex = 3;
            this.pb_question.TabStop = false;
            this.pb_question.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(364, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // btn_go
            // 
            this.btn_go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_go.BackColor = System.Drawing.Color.Transparent;
            this.btn_go.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_go.BackgroundImage")));
            this.btn_go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_go.FlatAppearance.BorderSize = 0;
            this.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go.Location = new System.Drawing.Point(552, 283);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(141, 130);
            this.btn_go.TabIndex = 5;
            this.btn_go.UseVisualStyleBackColor = false;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(39, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(305, 240);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // time_play
            // 
            this.time_play.Interval = 1000;
            this.time_play.Tick += new System.EventHandler(this.time_play_Tick);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("CRUSHED", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_time.Location = new System.Drawing.Point(35, 29);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(145, 23);
            this.label_time.TabIndex = 7;
            this.label_time.Text = "Time: 5";
            this.label_time.Visible = false;
            // 
            // label_round
            // 
            this.label_round.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_round.AutoSize = true;
            this.label_round.Font = new System.Drawing.Font("CRUSHED", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_round.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_round.Location = new System.Drawing.Point(276, 29);
            this.label_round.Name = "label_round";
            this.label_round.Size = new System.Drawing.Size(172, 23);
            this.label_round.TabIndex = 7;
            this.label_round.Text = "Round: 1";
            this.label_round.Visible = false;
            // 
            // label_score
            // 
            this.label_score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("CRUSHED", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_score.Location = new System.Drawing.Point(519, 29);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(174, 23);
            this.label_score.TabIndex = 7;
            this.label_score.Text = "Score: 0";
            this.label_score.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(39, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(319, 275);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(325, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label_setup
            // 
            this.label_setup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_setup.AutoSize = true;
            this.label_setup.Font = new System.Drawing.Font("CRUSHED", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_setup.ForeColor = System.Drawing.Color.Red;
            this.label_setup.Location = new System.Drawing.Point(8, 14);
            this.label_setup.Name = "label_setup";
            this.label_setup.Size = new System.Drawing.Size(723, 30);
            this.label_setup.TabIndex = 10;
            this.label_setup.Text = "Please setup your position";
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 432);
            this.Controls.Add(this.label_setup);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_round);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_question);
            this.Controls.Add(this.pb_motion);
            this.Controls.Add(this.start_label);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GamePlay";
            this.Text = "GamePlay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GamePlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_motion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer time_start;
        private System.Windows.Forms.PictureBox start_label;
        private System.Windows.Forms.PictureBox pb_motion;
        private System.Windows.Forms.PictureBox pb_question;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer time_play;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_round;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_setup;
    }
}