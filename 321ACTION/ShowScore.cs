using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _321ACTION
{
    public partial class ShowScore : Form
    {
        public ShowScore()
        {
            InitializeComponent();
        }

        private void ShowScore_Load(object sender, EventArgs e)
        {
            int score = GamePlay.score;
            label_score.Text = score.ToString();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            //GamePlay gp = new GamePlay();
            //gp.Show();
            Mode.gp2.Show();
            this.Hide();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }
    }
}
