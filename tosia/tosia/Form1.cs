using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tosia.Properties;

namespace tosia
{
    public partial class Form1 : Form
    {
        private void playSound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = path;

            if (path == "stop")
            {
                player.Stop();
            }
            else
            {
                player.Load();
                player.Play();
            }
        }

        public Form1()
        {
            InitializeComponent();

            label_Tytuł.Text = NazwyGUI.label_Tytuł;
            label_Waka.Text = NazwyGUI.label_Waka;
            label_tekst1.Text = NazwyGUI.label_tekst1;
            label_tekst2.Text = NazwyGUI.label_tekst2;
            label_tekst3.Text = NazwyGUI.label_tekst3;
            label_EdukacjaMatematyczna.Text = NazwyGUI.label_EdukacjaMatematyczna;
            label_OperacjeLogiczne.Text = NazwyGUI.label_OperacjeLogiczne;
            label_Klasyfikacja.Text = NazwyGUI.label_Klasyfikacja;
            label_LiczbaNat.Text = NazwyGUI.label_LiczbaNat;
            label_ArytmetykaLiczb.Text = NazwyGUI.label_ArytmetykaLiczb;
            label_Geometria.Text = NazwyGUI.label_Geometria;
            label_Płaska.Text = NazwyGUI.label_Płaska;
            label_Przestrzenna.Text = NazwyGUI.label_Przestrzenna;
            label_Pomiar.Text = NazwyGUI.label_Pomiar;
            label_Długości.Text = NazwyGUI.label_Długości;
            label_Czasu.Text = NazwyGUI.label_Czasu;
            label_OperacjeLogiczne2.Text = NazwyGUI.label_OperacjeLogiczne;
            label_Myślenie.Text = NazwyGUI.label_Myślenie;
            label_Zad1.Text = NazwyGUI.label_Zad1;
            label_Zad2.Text = NazwyGUI.label_Zad2;
            label_Zad3.Text = NazwyGUI.label_Zad3;
            label_Z1Tytuł.Text = NazwyGUI.label_Z1Tytuł;
        }

        private void pictureBox1_Exit (object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox_Yes_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage_Song;
        }

        private void pictureBox_No_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage_Menu;
        }

        private void label_Operacja_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Menu_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage_Menu;
        }

        private void pictureBox_Z1_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage_Z1;
        }

        private void pictureBox_Next_Click(object sender, EventArgs e)
        {
            playSound("stop");

            tabControl.SelectedTab = tabPage_Menu;
        }
        
        private void pictureBox_TosiaHome_Click(object sender, EventArgs e)
        {
            playSound("sounds/kumkum.wav");

            pictureBox_Yes.Visible = true;
            pictureBox_No.Visible = true;
        }

        private void pictureBox_TosiaSong_Click(object sender, EventArgs e)
        {
            playSound("sounds/bylaSobieZabkaMala.wav");

            pictureBox_Next.Visible = true;
            label_tekst1.Visible = true;
            label_tekst2.Visible = true;
            label_tekst3.Visible = true;
        }

        private void pictureBox_TosiaMenu_Click(object sender, EventArgs e)
        {
            playSound("sounds/kumkum.wav");
        }

        private void pictureBox_TosiaZadania_Click(object sender, EventArgs e)
        {
            playSound("sounds/kumkum.wav");

            pictureBox_Z1.Enabled = true;
            pictureBox_Z1.Image= Resources._1Color;
        }

        private void pictureBox_TosiaZ1_Click(object sender, EventArgs e)
        {
            playSound("sounds/kumkum.wav");

            label_Zadanie.Visible = true;
        }

        private void label_Menu1a_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage_Menu1;
        }
    }
}
