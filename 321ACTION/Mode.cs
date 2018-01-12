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
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }
        public static GamePlay gp2 = new GamePlay();

        private void btn_play_Click(object sender, EventArgs e)
        {
            //GamePlay gp = new GamePlay();
            //gp.Show();
            //this.Hide();
            gp2.Show();
            this.Hide();
        }
    }
}
