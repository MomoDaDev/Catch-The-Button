using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_the_button_windows_forms
{
    public partial class optionsclicked : Form
    {
        public optionsclicked()
        {
            InitializeComponent();
        }



        
        static int playtime = 30;

        private void up_Click(object sender, EventArgs e)
        {
            playtime++;
            time.Text = (playtime + " sec");
        }

        private void down_Click(object sender, EventArgs e)
        {
            if (playtime != 1)
                playtime--;
            time.Text = (playtime + " sec");
        }







        Random rndm = new Random();
        private void optionstimer_Tick(object sender, EventArgs e)
        {
            int rndm_1 = rndm.Next(0, 255), rndm_2 = rndm.Next(0, 255), rndm_3 = rndm.Next(0, 255);
            BackColor = Color.FromArgb(rndm_1, rndm_2, rndm_3);
        }

        private void options_Click(object sender, EventArgs e)
        {
            this.Hide();

            mainmenu mainmenu_1 = new mainmenu();
            mainmenu_1.Show();
        }

        public int hey()
        {
            return playtime;
        }
    }
}
