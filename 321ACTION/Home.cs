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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Mode md = new Mode();
            md.Show();
            this.Hide();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            test tt = new test();
            tt.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            int btn_width = this.Width/2;
            int btn_height = this.Height/2;
            btn_start.Location = new Point(btn_width-(btn_start.Width/2), btn_height);
            btn_setting.Location = new Point(btn_start.Left, btn_start.Height + btn_start.Top + 10);
            btn_exit.Location = new Point(btn_setting.Left, btn_setting.Height + btn_setting.Top+10);
        }
    }
}
