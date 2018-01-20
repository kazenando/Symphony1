using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Symphony1
{
    public partial class Form1 : Form
    {
        public int checkNote = 0;
        public int checkKey = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Symphony";

            //ProcessStartInfo runAlda = new ProcessStartInfo();
            //runAlda.WindowStyle = ProcessWindowStyle.Hidden;
            //runAlda.FileName = "cmd.exe";
            System.Diagnostics.Process.Start("alda", "repl");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void semibreveButton_Click(object sender, EventArgs e)
        {
            checkNote = 1;
            label1.Text = "1";
        }

        private void minimButton_Click(object sender, EventArgs e)
        {
            checkNote = 2;
            label1.Text = "2";
        }

        private void crotchetButton_Click(object sender, EventArgs e)
        {
            checkNote = 3;
            label1.Text = "3";
        }

        private void quaverButton_Click(object sender, EventArgs e)
        {
            checkNote = 4;
            label1.Text = "4";
        }

        private void semiquaverButton_Click(object sender, EventArgs e)
        {
            checkNote = 5;
            label1.Text = "5";
        }

        private void demisemiquaverButton_Click(object sender, EventArgs e)
        {
            checkNote = 6;
            label1.Text = "6";
        }

        private void dottedminimButton_Click(object sender, EventArgs e)
        {
            checkNote = 7;
            label1.Text = "7";
        }

        private void dottedcrotchetButton_Click(object sender, EventArgs e)
        {
            checkNote = 8;
            label1.Text = "8";
        }

        private void cMajor_Click(object sender, EventArgs e)
        {
            checkKey = 1;
            label2.Text = "1";
            testKey.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN1_Semibreve.png"); 
        }
        
        private void dMajor_Click(object sender, EventArgs e)
        {
            checkKey = 2;
            label2.Text = "2";
            testKey.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN2_Minim.png");
        }

        private void eMajor_Click(object sender, EventArgs e)
        {
            checkKey = 3;
            label2.Text = "3";
            testKey.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN3_Crotchet.png");
        }

        private void fMajor_Click(object sender, EventArgs e)
        {
            checkKey = 4;
            label2.Text = "4";
            testKey.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN4_quaver.png");
        }

        private void gMajor_Click(object sender, EventArgs e)
        {
            checkKey = 5;
            label2.Text = "5";
            testKey.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN4_quaver.png");
        }

        private void aMajor_Click(object sender, EventArgs e)
        {
            checkKey = 6;
            label2.Text = "6";
            testKey.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN3_Crotchet.png");
        }

        private void bMajor_Click(object sender, EventArgs e)
        {
            checkKey = 7;
            label2.Text = "7";
            testKey.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN2_Minim.png");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
        }

        private void toolBoxPanel_Control_MouseHover(object sender, EventArgs e)
        {
            toolBoxPanel_Control.Focus();
        }

        private void toolBoxPanel_Control_MouseClick(object sender, MouseEventArgs e)
        {
            toolBoxPanel_Control.Focus();
        }

        private void formMainPanel_Control_MouseHover(object sender, EventArgs e)
        {
            formMainPanel_Control.Focus();
        }

        private void formMainPanel_Control_MouseClick(object sender, MouseEventArgs e)
        {
            formMainPanel_Control.Focus();
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            if (checkNote == 1)
            {
                PictureBox11.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN1_Semibreve.png");
            }
            else if (checkNote == 2)
            {
                PictureBox11.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN2_Minim.png");
            }
            else if (checkNote == 3)
            {
                PictureBox11.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN3_Crotchet.png");
            }
            else if (checkNote == 4)
            {
                PictureBox11.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN4_Quaver.png");
            }
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            if (checkNote == 1)
            {
                PictureBox12.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN1_Semibreve.png");
            }
            else if (checkNote == 2)
            {
                PictureBox12.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN2_Minim.png");
            }
            else if (checkNote == 3)
            {
                PictureBox12.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN3_Crotchet.png");
            }
            else if (checkNote == 4)
            {
                PictureBox12.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN4_Quaver.png");
            }
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            if (checkNote == 1)
            {
                PictureBox13.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN1_Semibreve.png");
            }
            else if (checkNote == 2)
            {
                PictureBox13.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN2_Minim.png");
            }
            else if (checkNote == 3)
            {
                PictureBox13.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN3_Crotchet.png");
            }
            else if (checkNote == 4)
            {
                PictureBox13.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN4_Quaver.png");
            }
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            if (checkNote == 1)
            {
                PictureBox14.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN1_Semibreve.png");
            }
            else if (checkNote == 2)
            {
                PictureBox14.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN2_Minim.png");
            }
            else if (checkNote == 3)
            {
                PictureBox14.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN3_Crotchet.png");
            }
            else if (checkNote == 4)
            {
                PictureBox14.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN4_Quaver.png");
            }
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            if (checkNote == 1)
            {
                PictureBox15.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN1_Semibreve.png");
            }
            else if (checkNote == 2)
            {
                PictureBox15.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN2_Minim.png");
            }
            else if (checkNote == 3)
            {
                PictureBox15.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN3_Crotchet.png");
            }
            else if (checkNote == 4)
            {
                PictureBox15.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN4_Quaver.png");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkNote == 1)
            {
                pictureBox2.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN1_Semibreve.png");
            }
            else if (checkNote == 2)
            {
                pictureBox2.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN2_Minim.png");
            }
            else if (checkNote == 3)
            {
                pictureBox2.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN3_Crotchet.png");
            }
            else if (checkNote == 4)
            {
                pictureBox2.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN4_Quaver.png");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (checkNote == 1)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN1_Semibreve.png");
            }
            else if (checkNote == 2)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN2_Minim.png");
            }
            else if (checkNote == 3)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN3_Crotchet.png");
            }
            else if (checkNote == 4)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Kazenando/Desktop/Tugas Akhir/Design Musical/MN_Fixed/FMN4_Quaver.png");
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetProcessesByName(":new");
        }
    }
}
