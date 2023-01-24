using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Catch_the_button_windows_forms
{
    public partial class startclicked : Form
    {






        SoundPlayer playmusic_start = new SoundPlayer(@"C:\Users\Moritz\source\C#\Kleinere Projekte\Catch the button windows forms\Catch the button windows forms\bin\Debug\bombsaway.wav.wav");



        static optionsclicked optionsclicked_2 = new optionsclicked();
        string playtimee = optionsclicked_2.hey().ToString();

        int playtime;



        public startclicked()
        {
            InitializeComponent();
            
            //playmusic_start.PlayLooping();
            

            playtime = int.Parse(playtimee);


            label1.Text = ("Time left : " + playtime);
            
        }
        
        

        int my_points = 0;

        mainmenu mainmenu_1 = new mainmenu();

        Random rndm = new Random();
        int x;
        bool starting = true;

        private void b1_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
            Starten();
            if (b1.Text == " ")
            {
                my_points++;
                b1.Text = "";
                b1.BackColor = Color.DarkSlateGray;
                Nextbutton();
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
            Starten();
            if (b2.Text == " ")
            {
                my_points++;
                b2.Text = "";
                b2.BackColor = Color.DarkSlateGray;
                Nextbutton();
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
            Starten();
            if (b3.Text == " ")
            {
                my_points++;
                b3.Text = "";
                b3.BackColor = Color.DarkSlateGray;
                Nextbutton();
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
            Starten();
            if (b4.Text == " ")
            {
                my_points++;
                b4.Text = "";
                b4.BackColor = Color.DarkSlateGray;
                Nextbutton();
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
            Starten();
            if (b5.Text == " ")
            {
                my_points++;
                b5.Text = "";
                b5.BackColor = Color.DarkSlateGray;
                Nextbutton();
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
            Starten();
            if (b6.Text == " ")
            {
                my_points++;
                b6.Text = "";
                b6.BackColor = Color.DarkSlateGray;
                Nextbutton();
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
            Starten();
            if (b7.Text == " ")
            {
                my_points++;
                b7.Text = "";
                b7.BackColor = Color.DarkSlateGray;
                Nextbutton();
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
            Starten();
            if (b8.Text == " ")
            {
                my_points++;
                b8.Text = "";
                b8.BackColor = Color.DarkSlateGray;
                Nextbutton();
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
            Starten();
            if (b9.Text == " ")
            {
                my_points++;
                b9.Text = "";
                b9.BackColor = Color.DarkSlateGray;
                Nextbutton();
            }
        }

        private void b10_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
            Starten();
            if (b10.Text == " ")
            {
                my_points++;
                b10.Text = "";
                b10.BackColor = Color.DarkSlateGray;
                Nextbutton();
            }
        }

        private void b11_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
            Starten();
            if (b11.Text == " ")
            {
                my_points++;
                b11.Text = "";
                b11.BackColor = Color.DarkSlateGray;
                Nextbutton();
            }
        }

        private void b12_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
            Starten();
            if (b12.Text == " ")
            {
                my_points++;
                b12.Text = "";
                b12.BackColor = Color.DarkSlateGray;
                Nextbutton();
            }
        }



        




        void Starten()
        {
            x = rndm.Next(1, 13);
            if (starting)
            {
                
                switch (x)
                {
                    case 1:
                        b1.Text = " "; b1.BackColor = Color.GreenYellow;
                        break;
                    case 2:
                        b2.Text = " "; b2.BackColor = Color.GreenYellow;
                        break;
                    case 3:
                        b3.Text = " "; b3.BackColor = Color.GreenYellow;
                        break;
                    case 4:
                        b4.Text = " "; b4.BackColor = Color.GreenYellow;
                        break;
                    case 5:
                        b5.Text = " "; b5.BackColor = Color.GreenYellow;
                        break;
                    case 6:
                        b6.Text = " "; b6.BackColor = Color.GreenYellow;
                        break;
                    case 7:
                        b7.Text = " "; b7.BackColor = Color.GreenYellow;
                        break;
                    case 8:
                        b8.Text = " "; b8.BackColor = Color.GreenYellow;
                        break;
                    case 9:
                        b9.Text = " "; b9.BackColor = Color.GreenYellow;
                        break;
                    case 10:
                        b10.Text = " "; b10.BackColor = Color.GreenYellow;
                        break;
                    case 11:
                        b11.Text = " "; b11.BackColor = Color.GreenYellow;
                        break;
                    case 12:
                        b12.Text = " "; b12.BackColor = Color.GreenYellow;
                        break;
                }
                starting = false;
            }
        }
        void Nextbutton()
        {
            x = rndm.Next(1, 13);
            switch (x)
            {
                case 1: b1.Text = " "; b1.BackColor = Color.GreenYellow;
                    break;
                case 2: b2.Text = " "; b2.BackColor = Color.GreenYellow;
                    break;
                case 3: b3.Text = " "; b3.BackColor = Color.GreenYellow;
                    break;
                case 4: b4.Text = " "; b4.BackColor = Color.GreenYellow;
                    break;
                case 5: b5.Text = " "; b5.BackColor = Color.GreenYellow;
                    break;
                case 6: b6.Text = " "; b6.BackColor = Color.GreenYellow;
                    break;
                case 7: b7.Text = " "; b7.BackColor = Color.GreenYellow;
                    break;
                case 8: b8.Text = " "; b8.BackColor = Color.GreenYellow;
                    break;
                case 9: b9.Text = " "; b9.BackColor = Color.GreenYellow;
                    break;
                case 10:b10.Text = " "; b10.BackColor = Color.GreenYellow;
                    break;
                case 11:b11.Text = " "; b11.BackColor = Color.GreenYellow;
                    break;
                case 12:b12.Text = " "; b12.BackColor = Color.GreenYellow;
                    break;
            }
        }









        private void timer_Tick(object sender, EventArgs e)
        {
            playtime--;
            label1.Text = ("Time left : " + playtime);
            if(playtime == 0)
            {
                timer.Enabled = false;
                b1.Visible = false;
                b2.Visible = false;
                b3.Visible = false;
                b4.Visible = false;
                b5.Visible = false;
                b6.Visible = false;
                b7.Visible = false;
                b8.Visible = false;
                b9.Visible = false;
                b10.Visible = false;
                b11.Visible = false;
                b12.Visible = false;
                label1.Visible = false;
                label2.Text = ("Your Points   " + my_points);
                label2.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            playmusic_start.Stop();
            Thread.Sleep(1000);
            my_points = 0;
            this.Close();
            mainmenu_1.Show();
        }
    }
}
