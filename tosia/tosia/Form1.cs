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
        public System.Media.SoundPlayer bylaSobieZabkaMala = new System.Media.SoundPlayer();
        public System.Media.SoundPlayer kumkum = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();

            label_Tytuł.Text = NazwyGUI.label_Tytuł;
            label_Waka.Text = NazwyGUI.label_Waka;
            label_MenuTytuł.Text = NazwyGUI.label_MenuTytuł;
            label_Menu1.Text = NazwyGUI.labeMenu1;
            label_Menu2.Text = NazwyGUI.labeMenu2;
            label_Menu3.Text = NazwyGUI.labeMenu3;
            label_Menu4.Text = NazwyGUI.labeMenu4;
            label_Menu5.Text = NazwyGUI.labeMenu5;
            label_Menu1Tytuł.Text = NazwyGUI.label_Menu1Tytuł;
            label_Menu1Podtytuł.Text = NazwyGUI.label_Menu1Podtytuł;
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
            tabControl.SelectedTab = tabPage_Menu1;
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
            tabControl.SelectedTab = tabPage_Menu;
            bylaSobieZabkaMala.Stop();
        }

        private void pictureBox_TosiaHome_Click(object sender, EventArgs e)
        {
            kumkum.SoundLocation = "kumkum.wav";
            kumkum.Play();
            pictureBox_Yes.Visible = true;
            pictureBox_No.Visible = true;
        }

        private void pictureBox_TosiaSong_Click(object sender, EventArgs e)
        {
            bylaSobieZabkaMala.SoundLocation = "bylaSobieZabkaMala.wav";
            bylaSobieZabkaMala.Play();
            pictureBox_Next.Visible = true;
            label_tekst.Visible = true;

        }

        private void pictureBox_TosiaMenu_Click(object sender, EventArgs e)
        {
            kumkum.SoundLocation = "kumkum.wav";
            kumkum.Play();
            label_Menu1.Enabled = true;
        }

        private void pictureBox_TosiaZadania_Click(object sender, EventArgs e)
        {
            kumkum.SoundLocation = "kumkum.wav";
            kumkum.Play();
            pictureBox_Z1.Enabled = true;
            pictureBox_Z1.Image= Resources._1Color;
        }

        private void pictureBox_TosiaZ1_Click(object sender, EventArgs e)
        {
            kumkum.SoundLocation = "kumkum.wav";
            kumkum.Play();
            label_Zadanie.Visible = true;
        }
    }
}
