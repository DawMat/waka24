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
        int polecenie = 3;
        int time;

        public Form1()
        {
            InitializeComponent();

                #region nazwy GUI

            label_Tytuł.Text = NazwyGUI.label_Tytuł;
            label_Waka.Text = NazwyGUI.label_Waka;
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
        
            #region przenoszenie obrazow

        private Point firstPoint = new Point();
        
        public void INIT()
        {
            #region pictureBox_cukierki
            pictureBox_cukierki.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_cukierki.BringToFront();
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
                    pictureBox_zeby.BringToFront();
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
                    pictureBox_owca.BringToFront();
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
                    pictureBox_welna.BringToFront();
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
                    pictureBox_truskawki.BringToFront();
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
                    pictureBox_dzem.BringToFront();
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
                    pictureBox_krowa.BringToFront();
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
                    pictureBox_mleko.BringToFront();
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
                    pictureBox_klos.BringToFront();
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
                    pictureBox_maka.BringToFront();
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

            #region pictureBox_deska
            pictureBox_deska.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_deska.BringToFront();
                }
            };

            pictureBox_deska.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_deska.Location = new Point(pictureBox_deska.Location.X - res.X, pictureBox_deska.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_deska

            #region pictureBox_kura
            pictureBox_kura.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_kura.BringToFront();
                }
            };

            pictureBox_kura.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_kura.Location = new Point(pictureBox_kura.Location.X - res.X, pictureBox_kura.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_kura

            #region pictureBox_kolano
            pictureBox_kolano.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_kolano.BringToFront();
                }
            };

            pictureBox_kolano.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_kolano.Location = new Point(pictureBox_kolano.Location.X - res.X, pictureBox_kolano.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_kolano

            #region pictureBox_ksiazka
            pictureBox_ksiazka.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_ksiazka.BringToFront();
                }
            };

            pictureBox_ksiazka.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_ksiazka.Location = new Point(pictureBox_ksiazka.Location.X - res.X, pictureBox_ksiazka.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_ksiazka

            #region pictureBox_brudneDlonie
            pictureBox_brudneDlonie.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_brudneDlonie.BringToFront();
                }
            };

            pictureBox_brudneDlonie.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_brudneDlonie.Location = new Point(pictureBox_brudneDlonie.Location.X - res.X, pictureBox_brudneDlonie.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_brudneDlonie

            #region pictureBox_czysteDlonie
            pictureBox_czysteDlonie.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_czysteDlonie.BringToFront();
                }
            };

            pictureBox_czysteDlonie.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_czysteDlonie.Location = new Point(pictureBox_czysteDlonie.Location.X - res.X, pictureBox_czysteDlonie.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_czysteDlonie

            #region pictureBox_pomysl
            pictureBox_pomysl.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_pomysl.BringToFront();
                }
            };

            pictureBox_pomysl.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_pomysl.Location = new Point(pictureBox_pomysl.Location.X - res.X, pictureBox_pomysl.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_pomysl

            #region pictureBox_rolki
            pictureBox_rolki.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_rolki.BringToFront();
                }
            };

            pictureBox_rolki.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_rolki.Location = new Point(pictureBox_rolki.Location.X - res.X, pictureBox_rolki.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_rolki

            #region pictureBox_plot
            pictureBox_plot.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_plot.BringToFront();
                }
            };

            pictureBox_plot.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_plot.Location = new Point(pictureBox_plot.Location.X - res.X, pictureBox_plot.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_plot

            #region pictureBox_jajko
            pictureBox_jajko.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_jajko.BringToFront();
                }
            };

            pictureBox_jajko.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_jajko.Location = new Point(pictureBox_jajko.Location.X - res.X, pictureBox_jajko.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_jajko

            #region pictureBox_mlotek
            pictureBox_mlotek.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_mlotek.BringToFront();
                }
            };

            pictureBox_mlotek.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_mlotek.Location = new Point(pictureBox_mlotek.Location.X - res.X, pictureBox_mlotek.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_mlotek

            #region pictureBox_pisanki
            pictureBox_pisanki.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_pisanki.BringToFront();
                }
            };

            pictureBox_pisanki.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_pisanki.Location = new Point(pictureBox_pisanki.Location.X - res.X, pictureBox_pisanki.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_pisanki

            #region pictureBox_mydlo
            pictureBox_mydlo.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_mydlo.BringToFront();
                }
            };

            pictureBox_mydlo.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_mydlo.Location = new Point(pictureBox_mydlo.Location.X - res.X, pictureBox_mydlo.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_mydlo

            #region pictureBox_czytanie
            pictureBox_czytanie.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_czytanie.BringToFront();
                }
            };

            pictureBox_czytanie.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_czytanie.Location = new Point(pictureBox_czytanie.Location.X - res.X, pictureBox_czytanie.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_czytanie

            #region pictureBox_brakKasku
            pictureBox_brakKasku.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                    pictureBox_brakKasku.BringToFront();
                }
            };

            pictureBox_brakKasku.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox_brakKasku.Location = new Point(pictureBox_brakKasku.Location.X - res.X, pictureBox_brakKasku.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
            #endregion pictureBox_brakKasku

        }

        #endregion przenoszenie obrazow

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

        private void pictureBox_TosiaHome_Click(object sender, EventArgs e)
        {
            playSound("sounds/kumkum.wav");

            pictureBox_Yes.Visible = true;
            pictureBox_No.Visible = true;
        }

        private void pictureBox_Yes_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage_Song;
        }

        private void pictureBox_No_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage_Menu;
        }

        private void pictureBox_Menu_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage_Menu;
        }
        
            #region piosenka

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (true)
            {
                time = time + 1;
                //label_Tytuł.Text = time + "";
                switch (time)
                {
                    case 19:
                        label_tekst.Text = NazwyGUI.label_tekst2;
                        break;
                    case 28:
                        label_tekst.Text = NazwyGUI.label_tekst3;
                        break;
                    case 37:
                        label_tekst.Text = NazwyGUI.label_tekst4;
                        break;
                    case 55:
                        label_tekst.Text = NazwyGUI.label_tekst5;
                        break;
                    case 64:
                        label_tekst.Text = NazwyGUI.label_tekst6;
                        break;
                    case 73:
                        label_tekst.Text = NazwyGUI.label_tekst7;
                        timer1.Stop();
                        break;
                }


            }
        }

        private void pictureBox_TosiaSong_Click(object sender, EventArgs e)
        {
            time = 0;
            playSound("sounds/bylaSobieZabkaMala.wav");
            timer1.Start();
            label_tekst.Text = NazwyGUI.label_tekst1;
            pictureBox_Next.Visible = true;
            label_tekst.Visible = true;

        }

        private void pictureBox_Next_Click(object sender, EventArgs e)
        {
            playSound("stop");

            tabControl.SelectedTab = tabPage_Menu;
        }
   
            #endregion piosenka

        private void pictureBox_TosiaMenu_Click(object sender, EventArgs e)
        {
            playSound("sounds/kumkum.wav");
        }

        private void label_Menu1a_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage_MenuKlasyfikacja;
        }

        private void pictureBox_TosiaKlasyfikacja_Click(object sender, EventArgs e)
        {
            playSound("sounds/kumkum.wav");

            pictureBox_Z1P1.Enabled = true;
            pictureBox_Z1P1.Image = Resources._1Color;

            pictureBox_Z1P2.Enabled = true;
            pictureBox_Z1P2.Image = Resources._2Color;

            //pictureBox_Z2P1.Image = Resources._1Color;
            //pictureBox_Z2P2.Image = Resources._2Color;
        }

            #region zadanie1 poziom1

        private void pictureBox_Z1P1_Click_1(object sender, EventArgs e)
        {
            #region resetowanie
            pictureBox_krowa.Visible = false;
            pictureBox_mleko.Visible = false;
            pictureBox_owca.Visible = false;
            pictureBox_welna.Visible = false;
            pictureBox_truskawki.Visible = false;
            pictureBox_dzem.Visible = false;
            pictureBox_klos.Visible = false;
            pictureBox_maka.Visible = false;
            pictureBox_cukierki.Visible = false;
            pictureBox_zeby.Visible = false;

            pictureBox_owca.Location = new Point(77, 52);
            pictureBox_cukierki.Location = new Point(279, 71);
            pictureBox_klos.Location = new Point(461, 52);
            pictureBox_truskawki.Location = new Point(653, 71);
            pictureBox_krowa.Location = new Point(829, 71);
            pictureBox_maka.Location = new Point(62, 348);
            pictureBox_mleko.Location = new Point(200, 391);
            pictureBox_zeby.Location = new Point(353, 381);
            pictureBox_welna.Location = new Point(529, 391);
            pictureBox_dzem.Location = new Point(731, 375);
            #endregion resetowanie

            polecenie = 3;
            pictureBox_dalejZ1P1.Visible = false;
            pictureBox_ramkaZ1P1.Visible = false;
            pictureBox_balonikZ1P1.Enabled = true;
            tabControl.SelectedTab = tabPage_Z1P1;
            playSound("sounds/polecenia/polecenie1.wav");
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

            pictureBox_dalejZ1P1.Visible = true;
            playSound("sounds/polecenia/polecenie2.wav");
            pictureBox_balonikZ1P1.Enabled = false;
        }

        private void pictureBox_dalej_Click(object sender, EventArgs e)
        {
            switch (polecenie)
            {
                case 3:
                    playSound("sounds/polecenia/polecenie3.wav");
                    pictureBox_ramkaZ1P1.Visible = true;
                    polecenie++;
                    break;

                case 4:
                    playSound("sounds/polecenia/polecenie4.wav");
                    polecenie++;
                    break;

                case 5:
                    playSound("sounds/polecenia/polecenie5.wav");
                    pictureBox_TakZ1P1.Visible = true;
                    pictureBox_NieZ1P1.Visible = true;
                    pictureBox_TakZ1P1.BringToFront();
                    pictureBox_NieZ1P1.BringToFront();
                    break;

                case 7:
                    playSound("sounds/polecenia/polecenie7.wav");
                    polecenie++;
                    break;
                case 8:
                    playSound("sounds/polecenia/polecenie8.wav");
                    tabControl.SelectedTab = tabPage_Z1P1Tosi;
                    break;
            }

        }

        private void pictureBox_TakZ1P1_Click(object sender, EventArgs e)
        {
            pictureBox_owca.Location = new Point(77, 52);
            pictureBox_cukierki.Location = new Point(279, 71);
            pictureBox_klos.Location = new Point(461, 52);
            pictureBox_truskawki.Location = new Point(653, 71);
            pictureBox_krowa.Location = new Point(829, 71);
            pictureBox_maka.Location = new Point(62, 348);
            pictureBox_mleko.Location = new Point(200, 391);
            pictureBox_zeby.Location = new Point(353, 381);
            pictureBox_welna.Location = new Point(529, 391);
            pictureBox_dzem.Location = new Point(731, 375);

            pictureBox_TakZ1P1.Visible = false;
            pictureBox_NieZ1P1.Visible = false;
            playSound("sounds/polecenia/polecenie6.wav");
            polecenie = 7;



        }

        private void pictureBox_NieZ1P1_Click(object sender, EventArgs e)
        {
            pictureBox_TakZ1P1.Visible = false;
            pictureBox_NieZ1P1.Visible = false;

            tabControl.SelectedTab = tabPage_Z1P1Tosi;
            playSound("sounds/polecenia/polecenie8.wav");
        }

        private void pictureBox_czerwonyTrojkat_Click(object sender, EventArgs e)
        {
            pictureBoxTosia1a.Visible = true;
            pictureBoxTosia1b.Visible = true;

            playSound("sounds/polecenia/polecenie9.wav");
        }

        private void pictureBox_niebieskiKwadrat_Click(object sender, EventArgs e)
        {
            pictureBoxTosia2a.Visible = true;
            pictureBoxTosia2b.Visible = true;

            playSound("sounds/polecenia/polecenie10.wav");
        }

        private void pictureBox_ziolonyTrojkat_Click(object sender, EventArgs e)
        {
            pictureBoxTosia3a.Visible = true;
            pictureBoxTosia3b.Visible = true;

            playSound("sounds/polecenia/polecenie11.wav");
        }

        private void pictureBox_zoltyKwadrat_Click(object sender, EventArgs e)
        {
            pictureBoxTosia4a.Visible = true;
            pictureBoxTosia4b.Visible = true;

            playSound("sounds/polecenia/polecenie12.wav");
        }

        private void pictureBox_pomaranczowyTrojkat_Click(object sender, EventArgs e)
        {
            pictureBoxTosia5a.Visible = true;
            pictureBoxTosia5b.Visible = true;

            playSound("sounds/polecenia/polecenie13.wav");
        }

        private void pictureBox_TosiaZ1P1_Click(object sender, EventArgs e)
        {
            playSound("sounds/kumkum.wav");
            tabControl.SelectedTab = tabPage_MenuKlasyfikacja;
        }

        #endregion zadanie1 poziom1

        private void pictureBox_Z1P2_Click(object sender, EventArgs e)
        {

            #region resetowanie

            pictureBox_mlotek.Visible = false;
            pictureBox_pisanki.Visible = false;
            pictureBox_mydlo.Visible = false;
            pictureBox_czytanie.Visible = false;
            pictureBox_brakKasku.Visible = false;
            pictureBox_deska.Visible = false;
            pictureBox_kura.Visible = false;
            pictureBox_kolano.Visible = false;
            pictureBox_ksiazka.Visible = false;
            pictureBox_brudneDlonie.Visible = false;
            pictureBox_czysteDlonie.Visible = false;
            pictureBox_pomysl.Visible = false;
            pictureBox_rolki.Visible = false;
            pictureBox_plot.Visible = false;
            pictureBox_jajko.Visible = false;
            pictureBox_ramka1Z1P2.Visible = false;
            pictureBox_ramka2Z1P2.Visible = false;
            pictureBox_ramka3Z1P2.Visible = false;

            pictureBox_dalejZ1P2.Visible = false;
            pictureBox_balonikZ1P2.Enabled = true;

            pictureBox_mlotek.Location = new Point(186, 21);
            pictureBox_pisanki.Location = new Point(318, 21);
            pictureBox_mydlo.Location = new Point(452, 21);
            pictureBox_czytanie.Location = new Point(587, 21);
            pictureBox_brakKasku.Location = new Point(719, 21);

            #endregion resetowanie



            polecenie = 3;
            pictureBox_dalejZ1P1.Visible = false;
            pictureBox_balonikZ1P1.Enabled = true;
            tabControl.SelectedTab = tabPage_Z1P2;
            playSound("sounds/polecenia/polecenie1.wav");
        }

        private void pictureBox_balonikZ1P2_Click(object sender, EventArgs e)
        {
            pictureBox_deska.Visible = true;
            pictureBox_kura.Visible = true;
            pictureBox_kolano.Visible = true;
            pictureBox_ksiazka.Visible = true;
            pictureBox_brudneDlonie.Visible = true;
            pictureBox_czysteDlonie.Visible = true;
            pictureBox_pomysl.Visible = true;
            pictureBox_rolki.Visible = true;
            pictureBox_plot.Visible = true;
            pictureBox_jajko.Visible = true;

            pictureBox_dalejZ1P2.Visible = true;
            pictureBox_balonikZ1P2.Enabled = false;
            playSound("sounds/polecenia/polecenie2.wav");
        }

        private void pictureBox_dalejZ1P2_Click(object sender, EventArgs e)
        {
            switch (polecenie)
            {
                case 3:
                    playSound("sounds/polecenia/polecenie3.wav");
                    pictureBox_ramka1Z1P2.Visible = true;
                    polecenie++;
                    break;

                case 4:
                    playSound("sounds/polecenia/polecenie4.wav");
                    polecenie = 14;

                    break;

                case 14:
                    playSound("sounds/polecenia/polecenie14.wav");
                    pictureBox_ramka2Z1P2.Visible = true;
                    pictureBox_ramka3Z1P2.Visible = true;
                    pictureBox_mlotek.Visible = true;
                    pictureBox_pisanki.Visible = true;
                    pictureBox_mydlo.Visible = true;
                    pictureBox_czytanie.Visible = true;
                    pictureBox_brakKasku.Visible = true;

                    polecenie++;
                    break;

                case 15:
                    playSound("sounds/polecenia/polecenie15.18.wav");
                    polecenie++;
                    break;

                case 16:
                    playSound("sounds/polecenia/polecenie16.wav");
                    pictureBox_TakZ1P2.Visible = true;
                    pictureBox_NieZ1P2.Visible = true;
                    pictureBox_TakZ1P2.BringToFront();
                    pictureBox_NieZ1P2.BringToFront();
                    break;

                case 18:
                    playSound("sounds/polecenia/polecenie15.18.wav");
                    polecenie++;
                    break;

                case 19:
                    playSound("sounds/polecenia/polecenie19.wav");
                    tabControl.SelectedTab = tabPage_Z1P2Tosi;
                    break;

            }
        }

        private void pictureBox_TakZ1P2_Click(object sender, EventArgs e)
        {
            pictureBox_mlotek.Location = new Point(186, 21);
            pictureBox_pisanki.Location = new Point(318, 21);
            pictureBox_mydlo.Location = new Point(452, 21);
            pictureBox_czytanie.Location = new Point(587, 21);
            pictureBox_brakKasku.Location = new Point(719, 21);

            pictureBox_TakZ1P2.Visible = false;
            pictureBox_NieZ1P2.Visible = false;

            pictureBox_TakZ1P1.Visible = false;
            pictureBox_NieZ1P1.Visible = false;
            playSound("sounds/polecenia/polecenie17.wav");
            polecenie = 18;
        }

        private void pictureBox_NieZ1P2_Click(object sender, EventArgs e)
        {
            pictureBox_TakZ1P2.Visible = false;
            pictureBox_NieZ1P2.Visible = false;

            tabControl.SelectedTab = tabPage_Z1P2Tosi;
            playSound("sounds/polecenia/polecenie19.wav");
        }

        private void pictureBox_TosiaZ1P2_Click(object sender, EventArgs e)
        {
            playSound("sounds/kumkum.wav");
            tabControl.SelectedTab = tabPage_MenuKlasyfikacja;
        }

    }
}
