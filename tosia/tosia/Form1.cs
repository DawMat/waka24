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
        public int polecenie = 3;

        public Form1()
        {
            InitializeComponent();

            #region nazwy GUI
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
            groupBox_Zad1.Text = NazwyGUI.groupBox_Zad1;
            groupBox_Zad2.Text = NazwyGUI.groupBox_Zad2;
            label_Z1P1Tytuł.Text = NazwyGUI.label_Z1P1Tytuł;
            #endregion nazwy GUI

            INIT();
        }

        private Point firstPoint = new Point();
        
        public void INIT()
        {
            #region pictureBox_cukierki
            pictureBox_cukierki.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                }
            };

            pictureBox_cukierki.MouseMove += (ss, ee) =>
              {
                  if (ee.Button==System.Windows.Forms.MouseButtons.Left)
                  {
                      Point temp = Control.MousePosition;
                      Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                      pictureBox_cukierki.Location = new Point(pictureBox_cukierki.Location.X - res.X, pictureBox_cukierki.Location.Y - res.Y);

                      firstPoint = temp;
                  }
              };
            #endregion pictureBox_cukierki

            #region pictureBox_zeby
            pictureBox_zeby.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                }
            };

            pictureBox_zeby.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_zeby.Location = new Point(pictureBox_zeby.Location.X - res.X, pictureBox_zeby.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_zeby

            #region pictureBox_owca
            pictureBox_owca.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                }
            };

            pictureBox_owca.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_owca.Location = new Point(pictureBox_owca.Location.X - res.X, pictureBox_owca.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_owca

            #region pictureBox_welna
            pictureBox_welna.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                }
            };

            pictureBox_welna.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_welna.Location = new Point(pictureBox_welna.Location.X - res.X, pictureBox_welna.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_welna

            #region pictureBox_truskawki
            pictureBox_truskawki.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                }
            };

            pictureBox_truskawki.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_truskawki.Location = new Point(pictureBox_truskawki.Location.X - res.X, pictureBox_truskawki.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_truskawki

            #region pictureBox_dzem
            pictureBox_dzem.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                }
            };

            pictureBox_dzem.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_dzem.Location = new Point(pictureBox_dzem.Location.X - res.X, pictureBox_dzem.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_dzem

            #region pictureBox_krowa
            pictureBox_krowa.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                }
            };

            pictureBox_krowa.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_krowa.Location = new Point(pictureBox_krowa.Location.X - res.X, pictureBox_krowa.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_krowa

            #region pictureBox_mleko
            pictureBox_mleko.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                }
            };

            pictureBox_mleko.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_mleko.Location = new Point(pictureBox_mleko.Location.X - res.X, pictureBox_mleko.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_cukierki

            #region pictureBox_klos
            pictureBox_klos.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                }
            };

            pictureBox_klos.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_klos.Location = new Point(pictureBox_klos.Location.X - res.X, pictureBox_klos.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_klos

            #region pictureBox_maka
            pictureBox_maka.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                }
            };

            pictureBox_maka.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_maka.Location = new Point(pictureBox_maka.Location.X - res.X, pictureBox_maka.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_mleko

        }

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
            tabControl.SelectedTab = tabPage_Z1P1;
            playSound("sounds/polecenia/polecenie1.wav");
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

        private void pictureBox_TosiaKlasyfikacja_Click(object sender, EventArgs e)
        {
            playSound("sounds/kumkum.wav");

            pictureBox_Z1P1.Enabled = true;
            pictureBox_Z1P1.Image = Resources._1Color;
            //pictureBox_Z1P2.Image = Resources._2Color;
            //pictureBox_Z2P1.Image = Resources._1Color;
            //pictureBox_Z2P2.Image = Resources._2Color;
        }

        private void label_Menu1a_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage_MenuKlasyfikacja;
        }

        private void pictureBox_balonik_Click(object sender, EventArgs e)
        {
            pictureBox_krowa.Visible = true;
            pictureBox_mleko.Visible = true;
            pictureBox_owca.Visible = true;
            pictureBox_welna.Visible = true;
            pictureBox_truskawki.Visible = true;
            pictureBox_dzem.Visible = true;
            pictureBox_klos.Visible = true;
            pictureBox_maka.Visible = true;
            pictureBox_cukierki.Visible = true;
            pictureBox_zeby.Visible = true;
            pictureBox_dalej.Visible = true;

            playSound("sounds/polecenia/polecenie2.wav");
            pictureBox_balonik.Enabled = false;
        }

        private void pictureBox_dalej_Click(object sender, EventArgs e)
        {
            switch (polecenie)
            {
                case 3:
                    playSound("sounds/polecenia/polecenie3.wav");
                    polecenie++;
                    break;

                case 4:
                    playSound("sounds/polecenia/polecenie4.wav");
                    polecenie=5;
                    break;

                case 5:
                    playSound("sounds/polecenia/polecenie5.wav");
                    pictureBox_TakZ1P1.Visible = true;
                    pictureBox_NieZ1P1.Visible = true;
                    break;

                case 7:
                    playSound("sounds/polecenia/polecenie7.wav");
                    polecenie++;
                    break;
                case 8:
                    playSound("sounds/polecenia/polecenie8.wav");
                    break;
            }

        }

        private void pictureBox_TakZ1P1_Click(object sender, EventArgs e)
        {
            pictureBox_TakZ1P1.Visible = false;
            pictureBox_NieZ1P1.Visible = false;
            playSound("sounds/polecenia/polecenie6.wav");
            polecenie = 7;
        }

        private void pictureBox_NieZ1P1_Click(object sender, EventArgs e)
        {
            pictureBox_TakZ1P1.Visible = false;
            pictureBox_NieZ1P1.Visible = false;
            playSound("sounds/polecenia/polecenie8.wav");
        }
    }
}
