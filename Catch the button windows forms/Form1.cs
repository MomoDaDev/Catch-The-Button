using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Catch_the_button_windows_forms
{
    public partial class mainmenu : Form
    {



        SoundPlayer playmusic_menu = new SoundPlayer(@"C:\Users\Moritz\source\C#\Kleinere Projekte\Catch the button windows forms\Catch the button windows forms\bin\Debug\mainmenu.wav");




        public mainmenu()
        {
            InitializeComponent();
            playmusic_menu.PlayLooping();
        }
        

        Random rndm = new Random();
        private void menutimer_Tick(object sender, EventArgs e)
        {
            int rndm_1 = rndm.Next(0, 255), rndm_2 = rndm.Next(0, 255), rndm_3 = rndm.Next(0, 255);
            BackColor = Color.FromArgb(rndm_1, rndm_2, rndm_3);
        }

        private void start_Click(object sender, EventArgs e)
        {
            playmusic_menu.Stop();
            this.Hide();
            startclicked startclicked_1 = new startclicked();
            startclicked_1.Show();
        }

        private void options_Click(object sender, EventArgs e)
        {
            this.Hide();
            optionsclicked optionsclicked_1 = new optionsclicked();
            optionsclicked_1.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            

            /*startclicked.ActiveForm.Close();
            optionsclicked.ActiveForm.Close();

            this.Close();*/
        }
        
        private void mainmenu_Load(object sender, EventArgs e)
        {
        }
    }
}
