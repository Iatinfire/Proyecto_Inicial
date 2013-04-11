using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoInicial
{
    public partial class AnalistaPartidas : Form
    {
        public string Partida;
        public int Turno = 1;
        public int Leector = 0;
        List<string> LineasJugadas;
        public int StrikePlayer1 = 0;
        public int StrikePlayer2 = 0; 
        public int SparePlayer1 = 0; 
        public int SparePlayer2 = 0;

        public AnalistaPartidas()
        {
            InitializeComponent();
        }

        private void AnalistaPartidas_Load(object sender, EventArgs e)
        {
            LineasJugadas = new List<string>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamReader reader = new StreamReader(path +'/'+ Partida))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    LineasJugadas.Add(line); // Add to list.
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Esta seguro que desea salir de la aplicacion?",
        "Desea Salir?",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AnalistaPartidas_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectorPartidas Inicio = new SelectorPartidas();
            Inicio.Show();
        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if (Leector == 0)
            {
                textBox1.Text = LineasJugadas[Leector];
            }
            else
            {
                MostrarPuntuaje();
                
            }

            if (LineasJugadas[Leector] == "10" && (PrimerTiroPlayer1() == true || PrimerTiroPlayer2() == true))
            {
                if (PrimerTiroPlayer1() == true)
                    StrikePlayer1 = 2;
                if (PrimerTiroPlayer2() == true)
                    StrikePlayer2 = 2;
                Leector++;
            }

            Leector++;

            if (Leector == LineasJugadas.Count)
            {
                button2.Enabled = false;
                textBox73.Text = "Fin del Archivo/Fin del Juego";
            }

            if (QuienJuega() == "Player2")
                radioButton2.Checked = true;
            else
                radioButton1.Checked = true;
            
            
        }

        private void MostrarPuntuaje()
        { 
            if(Leector == 0)
                textBox1.Text = LineasJugadas[Leector];
            if(Leector == 1)
                textBox2.Text = LineasJugadas[Leector];
            if(Leector == 2)
                textBox72.Text = LineasJugadas[Leector];
            if(Leector == 3)
                textBox71.Text = LineasJugadas[Leector];
            if(Leector == 4)
                textBox6.Text = LineasJugadas[Leector];
            if(Leector == 5)
                textBox5.Text = LineasJugadas[Leector];
            if(Leector == 6)
                textBox69.Text = LineasJugadas[Leector];
            if(Leector == 7)
                textBox68.Text = LineasJugadas[Leector];
            if(Leector == 8)
                textBox9.Text = LineasJugadas[Leector];
            if(Leector == 9)
                textBox8.Text = LineasJugadas[Leector];
            if(Leector == 10)
                textBox66.Text = LineasJugadas[Leector];
            if(Leector == 11)
                textBox65.Text = LineasJugadas[Leector];
            if(Leector == 12)
                textBox12.Text = LineasJugadas[Leector];
            if(Leector == 13)
                textBox11.Text = LineasJugadas[Leector];
            if(Leector == 14)
                textBox63.Text = LineasJugadas[Leector];
            if(Leector == 15)
                textBox62.Text = LineasJugadas[Leector];
            if(Leector == 16)
                textBox15.Text = LineasJugadas[Leector];
            if(Leector == 17)
                textBox14.Text = LineasJugadas[Leector];
            if (Leector == 18)
                textBox60.Text = LineasJugadas[Leector];
            if (Leector == 19)
                textBox59.Text = LineasJugadas[Leector];
            if (Leector == 20)
                textBox18.Text = LineasJugadas[Leector];
            if (Leector == 21)
                textBox17.Text = LineasJugadas[Leector];
            if (Leector == 22)
                textBox57.Text = LineasJugadas[Leector];
            if (Leector == 23)
                textBox56.Text = LineasJugadas[Leector];
            if (Leector == 24)
                textBox21.Text = LineasJugadas[Leector];
            if (Leector == 25)
                textBox20.Text = LineasJugadas[Leector];
            if (Leector == 26)
                textBox54.Text = LineasJugadas[Leector];
            if (Leector == 27)
                textBox53.Text = LineasJugadas[Leector];
            if (Leector == 28)
                textBox24.Text = LineasJugadas[Leector];
            if (Leector == 29)
                textBox23.Text = LineasJugadas[Leector];
            if (Leector == 30)
                textBox51.Text = LineasJugadas[Leector];
            if (Leector == 31)
                textBox50.Text = LineasJugadas[Leector];
            if (Leector == 32)
                textBox27.Text = LineasJugadas[Leector];
            if (Leector == 33)
                textBox26.Text = LineasJugadas[Leector];
            if (Leector == 34)
                textBox48.Text = LineasJugadas[Leector];
            if (Leector == 35)
                textBox47.Text = LineasJugadas[Leector];
            if (Leector == 36)
                textBox30.Text = LineasJugadas[Leector];
            if (Leector == 37)
                textBox29.Text = LineasJugadas[Leector];
            if (Leector == 38)
                textBox45.Text = LineasJugadas[Leector];
            if (Leector == 39)
                textBox44.Text = LineasJugadas[Leector];
            if (Leector == 40)
                textBox36.Text = LineasJugadas[Leector];
            if (Leector == 41)
                textBox42.Text = LineasJugadas[Leector];
        }

        private string QuienJuega()
        {
            string Jugador = "Player2";
            if (Leector == 0)
                Jugador = "Player1";
            if (Leector == 1)
                Jugador = "Player1";
            if (Leector == 4)
                Jugador = "Player1";
            if (Leector == 5)
                Jugador = "Player1";
            if (Leector == 8)
                Jugador = "Player1";
            if (Leector == 9)
                Jugador = "Player1";
            if (Leector == 12)
                Jugador = "Player1";
            if (Leector == 13)
                Jugador = "Player1";
            if (Leector == 16)
                Jugador = "Player1";
            if (Leector == 17)
                Jugador = "Player1";
            if (Leector == 20)
                Jugador = "Player1";
            if (Leector == 21)
                Jugador = "Player1";
            if (Leector == 24)
                Jugador = "Player1";
            if (Leector == 25)
                Jugador = "Player1";
            if (Leector == 28)
                Jugador = "Player1";
            if (Leector == 29)
                Jugador = "Player1";
            if (Leector == 32)
                Jugador = "Player1";
            if (Leector == 33)
                Jugador = "Player1";
            if (Leector == 36)
                Jugador = "Player1";
            if (Leector == 37)
                Jugador = "Player1";
            if (Leector == 40)
                Jugador = "Player1";
            if (Leector == 41)
                Jugador = "Player1";

            return Jugador;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leector--;
            button2.Enabled = true;
            if (Leector == 0)
            {
                textBox1.Text = "0";
            }
            else
            {
                LimpiarPuntuaje();
            }

            if (Leector == 0)
            {
                button1.Enabled = false;
                textBox73.Text = "Inicio del Juego";
            }

            if (QuienJuega() == "Player2")
                radioButton2.Checked = true;
            else
                radioButton1.Checked = true;

        }

        private void LimpiarPuntuaje()
        {
            if (Leector == 0)
                textBox1.Text = "0";
            if (Leector == 1)
                textBox2.Text = "0";
            if (Leector == 2)
                textBox72.Text = "0";
            if (Leector == 3)
                textBox71.Text = "0";
            if (Leector == 4)
                textBox6.Text = "0";
            if (Leector == 5)
                textBox5.Text = "0";
            if (Leector == 6)
                textBox69.Text = "0";
            if (Leector == 7)
                textBox68.Text = "0";
            if (Leector == 8)
                textBox9.Text = "0";
            if (Leector == 9)
                textBox8.Text = "0";
            if (Leector == 10)
                textBox66.Text = "0";
            if (Leector == 11)
                textBox65.Text = "0";
            if (Leector == 12)
                textBox13.Text = "0";
            if (Leector == 13)
                textBox11.Text = "0";
            if (Leector == 14)
                textBox63.Text = "0";
            if (Leector == 15)
                textBox62.Text = "0";
            if (Leector == 16)
                textBox15.Text = "0";
            if (Leector == 17)
                textBox14.Text = "0";
            if (Leector == 18)
                textBox60.Text = "0";
            if (Leector == 19)
                textBox59.Text = "0";
            if (Leector == 20)
                textBox18.Text = "0";
            if (Leector == 21)
                textBox17.Text = "0";
            if (Leector == 22)
                textBox57.Text = "0";
            if (Leector == 23)
                textBox56.Text = "0";
            if (Leector == 24)
                textBox21.Text = "0";
            if (Leector == 25)
                textBox20.Text = "0";
            if (Leector == 26)
                textBox54.Text = "0";
            if (Leector == 27)
                textBox53.Text = "0";
            if (Leector == 28)
                textBox24.Text = "0";
            if (Leector == 29)
                textBox23.Text = "0";
            if (Leector == 30)
                textBox51.Text = "0";
            if (Leector == 31)
                textBox50.Text = "0";
            if (Leector == 32)
                textBox27.Text = "0";
            if (Leector == 33)
                textBox26.Text = "0";
            if (Leector == 34)
                textBox48.Text = "0";
            if (Leector == 35)
                textBox47.Text = "0";
            if (Leector == 36)
                textBox30.Text = "0";
            if (Leector == 37)
                textBox29.Text = "0";
            if (Leector == 38)
                textBox45.Text = "0";
            if (Leector == 39)
                textBox44.Text = "0";
            if (Leector == 40)
                textBox36.Text = "0";
            if (Leector == 41)
                textBox42.Text = "0";

        }

        private bool PrimerTiroPlayer1()
        {
            bool Primero = false;

            if (Leector == 0)
                Primero = true;
            if (Leector == 4)
                Primero = true;
            if (Leector == 8)
                Primero = true;
            if (Leector == 12)
                Primero = true;
            if (Leector == 16)
                Primero = true;
            if (Leector == 20)
                Primero = true;
            if (Leector == 24)
                Primero = true;
            if (Leector == 28)
                Primero = true;
            if (Leector == 32)
                Primero = true;
            if (Leector == 36)
                Primero = true;
            if (Leector == 40)
                Primero = true;

            return Primero;
        }

        private bool PrimerTiroPlayer2()
        {
            bool Primero = false;

            if (Leector == 2)
                Primero = true;
            if (Leector == 6)
                Primero = true;
            if (Leector == 10)
                Primero = true;
            if (Leector == 14)
                Primero = true;
            if (Leector == 18)
                Primero = true;
            if (Leector == 22)
                Primero = true;
            if (Leector == 26)
                Primero = true;
            if (Leector == 30)
                Primero = true;
            if (Leector == 34)
                Primero = true;
            if (Leector == 38)
                Primero = true;
            if (Leector == 41)
                Primero = true;

            return Primero;
        }

        #region SumatoriaPuntuacion
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer1 == 1)
            {
                textBox3.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox6.Text));
                SparePlayer1 = 0;
            }
            textBox4.Text = Convert.ToString(int.Parse(textBox6.Text) + int.Parse(textBox5.Text));
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(int.Parse(textBox6.Text) + int.Parse(textBox5.Text));
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer1 == 1)
            {
                textBox4.Text = Convert.ToString(int.Parse(textBox4.Text) + int.Parse(textBox9.Text));
                SparePlayer1 = 0;
            }
            textBox7.Text = Convert.ToString(int.Parse(textBox9.Text) + int.Parse(textBox8.Text));
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = Convert.ToString(int.Parse(textBox9.Text) + int.Parse(textBox8.Text));
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer1 == 1)
            {
                textBox7.Text = Convert.ToString(int.Parse(textBox7.Text) + int.Parse(textBox12.Text));
                SparePlayer1 = 0;
            }
            textBox10.Text = Convert.ToString(int.Parse(textBox12.Text) + int.Parse(textBox11.Text));
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox10.Text = Convert.ToString(int.Parse(textBox12.Text) + int.Parse(textBox11.Text));
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer1 == 1)
            {
                textBox10.Text = Convert.ToString(int.Parse(textBox10.Text) + int.Parse(textBox15.Text));
                SparePlayer1 = 0;
            }
            textBox13.Text = Convert.ToString(int.Parse(textBox15.Text) + int.Parse(textBox14.Text));
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox13.Text = Convert.ToString(int.Parse(textBox15.Text) + int.Parse(textBox14.Text));
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer1 == 1)
            {
                textBox13.Text = Convert.ToString(int.Parse(textBox13.Text) + int.Parse(textBox18.Text));
                SparePlayer1 = 0;
            }
            textBox16.Text = Convert.ToString(int.Parse(textBox18.Text) + int.Parse(textBox17.Text));
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            textBox16.Text = Convert.ToString(int.Parse(textBox18.Text) + int.Parse(textBox17.Text));
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer1 == 1)
            {
                textBox16.Text = Convert.ToString(int.Parse(textBox16.Text) + int.Parse(textBox21.Text));
                SparePlayer1 = 0;
            }
            textBox19.Text = Convert.ToString(int.Parse(textBox20.Text) + int.Parse(textBox21.Text));
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            textBox19.Text = Convert.ToString(int.Parse(textBox20.Text) + int.Parse(textBox21.Text));
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer1 == 1)
            {
                textBox19.Text = Convert.ToString(int.Parse(textBox19.Text) + int.Parse(textBox24.Text));
                SparePlayer1 = 0;
            }
            textBox22.Text = Convert.ToString(int.Parse(textBox24.Text) + int.Parse(textBox23.Text));
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            textBox22.Text = Convert.ToString(int.Parse(textBox24.Text) + int.Parse(textBox23.Text));
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer1 == 1)
            {
                textBox22.Text = Convert.ToString(int.Parse(textBox22.Text) + int.Parse(textBox27.Text));
                SparePlayer1 = 0;
            }
            textBox25.Text = Convert.ToString(int.Parse(textBox27.Text) + int.Parse(textBox26.Text));
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            textBox25.Text = Convert.ToString(int.Parse(textBox27.Text) + int.Parse(textBox26.Text));
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer1 == 1)
            {
                textBox25.Text = Convert.ToString(int.Parse(textBox25.Text) + int.Parse(textBox30.Text));
                SparePlayer1 = 0;
            }
            textBox28.Text = Convert.ToString(int.Parse(textBox29.Text) + int.Parse(textBox30.Text) + int.Parse(textBox36.Text));
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            textBox28.Text = Convert.ToString(int.Parse(textBox29.Text) + int.Parse(textBox30.Text) + int.Parse(textBox36.Text));
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            
            textBox28.Text = Convert.ToString(int.Parse(textBox29.Text) + int.Parse(textBox30.Text) + int.Parse(textBox36.Text));
        }

        #endregion

        #region SumatoriaPuntuacionPlayer2

        private void textBox72_TextChanged(object sender, EventArgs e)
        {
            textBox70.Text = Convert.ToString(int.Parse(textBox71.Text) + int.Parse(textBox72.Text));
        }

        private void textBox71_TextChanged(object sender, EventArgs e)
        {
            textBox70.Text = Convert.ToString(int.Parse(textBox71.Text) + int.Parse(textBox72.Text));
        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer2 == 1)
            {
                textBox70.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox69.Text));
                SparePlayer2 = 0;
            }
            textBox67.Text = Convert.ToString(int.Parse(textBox68.Text) + int.Parse(textBox69.Text));
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            textBox67.Text = Convert.ToString(int.Parse(textBox68.Text) + int.Parse(textBox69.Text));
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer2 == 1)
            {
                textBox67.Text = Convert.ToString(int.Parse(textBox67.Text) + int.Parse(textBox66.Text));
                SparePlayer2 = 0;
            }
            textBox64.Text = Convert.ToString(int.Parse(textBox66.Text) + int.Parse(textBox65.Text));
        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            textBox64.Text = Convert.ToString(int.Parse(textBox66.Text) + int.Parse(textBox65.Text));
        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer2 == 1)
            {
                textBox64.Text = Convert.ToString(int.Parse(textBox64.Text) + int.Parse(textBox63.Text));
                SparePlayer2 = 0;
            }
            textBox61.Text = Convert.ToString(int.Parse(textBox62.Text) + int.Parse(textBox63.Text));
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            textBox61.Text = Convert.ToString(int.Parse(textBox62.Text) + int.Parse(textBox63.Text));
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer2 == 1)
            {
                textBox61.Text = Convert.ToString(int.Parse(textBox61.Text) + int.Parse(textBox60.Text));
                SparePlayer2 = 0;
            }
            textBox58.Text = Convert.ToString(int.Parse(textBox60.Text) + int.Parse(textBox59.Text));
        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            textBox58.Text = Convert.ToString(int.Parse(textBox60.Text) + int.Parse(textBox59.Text));
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer2 == 1)
            {
                textBox58.Text = Convert.ToString(int.Parse(textBox58.Text) + int.Parse(textBox57.Text));
                SparePlayer2 = 0;
            }
            textBox55.Text = Convert.ToString(int.Parse(textBox56.Text) + int.Parse(textBox57.Text));
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            textBox55.Text = Convert.ToString(int.Parse(textBox56.Text) + int.Parse(textBox57.Text));
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer2 == 1)
            {
                textBox55.Text = Convert.ToString(int.Parse(textBox55.Text) + int.Parse(textBox54.Text));
                SparePlayer2 = 0;
            }
            textBox52.Text = Convert.ToString(int.Parse(textBox54.Text) + int.Parse(textBox53.Text));
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            textBox52.Text = Convert.ToString(int.Parse(textBox54.Text) + int.Parse(textBox53.Text));
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer2 == 1)
            {
                textBox52.Text = Convert.ToString(int.Parse(textBox52.Text) + int.Parse(textBox51.Text));
                SparePlayer2 = 0;
            }
            textBox49.Text = Convert.ToString(int.Parse(textBox51.Text) + int.Parse(textBox50.Text));
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            textBox49.Text = Convert.ToString(int.Parse(textBox51.Text) + int.Parse(textBox50.Text));
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer2 == 1)
            {
                textBox49.Text = Convert.ToString(int.Parse(textBox49.Text) + int.Parse(textBox48.Text));
                SparePlayer2 = 0;
            }
            textBox46.Text = Convert.ToString(int.Parse(textBox48.Text) + int.Parse(textBox47.Text));
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            textBox46.Text = Convert.ToString(int.Parse(textBox48.Text) + int.Parse(textBox47.Text));
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            if (SparePlayer2 == 1)
            {
                textBox46.Text = Convert.ToString(int.Parse(textBox46.Text) + int.Parse(textBox45.Text));
                SparePlayer2 = 0;
            }
            textBox43.Text = Convert.ToString(int.Parse(textBox45.Text) + int.Parse(textBox44.Text) + int.Parse(textBox42.Text));
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            textBox43.Text = Convert.ToString(int.Parse(textBox45.Text) + int.Parse(textBox44.Text) + int.Parse(textBox42.Text));
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            textBox43.Text = Convert.ToString(int.Parse(textBox45.Text) + int.Parse(textBox44.Text) + int.Parse(textBox42.Text));
        }

        #endregion

        #region VerificaSparePlayer1

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "0"&& textBox3.Text == "10")
                SparePlayer1 = 1;

            textBox31.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox7.Text) + int.Parse(textBox10.Text) + int.Parse(textBox13.Text) + int.Parse(textBox16.Text) + int.Parse(textBox19.Text) + int.Parse(textBox22.Text) + int.Parse(textBox25.Text) + int.Parse(textBox28.Text));
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (StrikePlayer1 == 1)
            {
                
            }
            if (StrikePlayer1 == 2)
                {
                    if (PrimerTiroPlayer1() == false)
                    {
                        StrikePlayer1 = 0;                        
                        textBox3.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox4.Text));
                    }
                    else
                    {
                        if (textBox6.Text == "10")
                        {
                            textBox3.Text = Convert.ToString(int.Parse(textBox3.Text) + 10);
                            StrikePlayer1 = 1;
                        }

                    }
                }
            textBox31.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox7.Text) + int.Parse(textBox10.Text) + int.Parse(textBox13.Text) + int.Parse(textBox16.Text) + int.Parse(textBox19.Text) + int.Parse(textBox22.Text) + int.Parse(textBox25.Text) + int.Parse(textBox28.Text));
            

            if (textBox3.Text != "0" && textBox4.Text == "10")
                SparePlayer1 = 1;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer1 == 1)
            {
                StrikePlayer1 = 0;    
                textBox3.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox9.Text));
               

            }
            if (StrikePlayer1 == 2)
            {
                if (PrimerTiroPlayer1() == false)
                {
                    StrikePlayer1 = 0;    
                    textBox4.Text = Convert.ToString(int.Parse(textBox4.Text) + int.Parse(textBox7.Text));
                    
                }
                else
                {
                    if (textBox9.Text == "10")
                    {
                        textBox4.Text = Convert.ToString(int.Parse(textBox4.Text) + 10);
                        StrikePlayer1 = 1;
                    }

                }
            }

            textBox31.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox7.Text) + int.Parse(textBox10.Text) + int.Parse(textBox13.Text) + int.Parse(textBox16.Text) + int.Parse(textBox19.Text) + int.Parse(textBox22.Text) + int.Parse(textBox25.Text) + int.Parse(textBox28.Text));

            if (textBox8.Text != "0" && textBox7.Text == "10")
                SparePlayer1 = 1;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer1 == 1)
            {
                StrikePlayer1 = 0;    
                textBox4.Text = Convert.ToString(int.Parse(textBox4.Text) + int.Parse(textBox12.Text));
                

            }
            if (StrikePlayer1 == 2)
            {
                if (PrimerTiroPlayer1() == false)
                {
                    StrikePlayer1 = 0;    
                    textBox7.Text = Convert.ToString(int.Parse(textBox7.Text) + int.Parse(textBox10.Text));
                    
                }
                else
                {
                    if (textBox12.Text == "10")
                    {
                        textBox7.Text = Convert.ToString(int.Parse(textBox7.Text) + 10);
                        StrikePlayer1 = 1;
                    }

                }
            }
            textBox31.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox7.Text) + int.Parse(textBox10.Text) + int.Parse(textBox13.Text) + int.Parse(textBox16.Text) + int.Parse(textBox19.Text) + int.Parse(textBox22.Text) + int.Parse(textBox25.Text) + int.Parse(textBox28.Text));

            if (textBox11.Text != "0" && textBox10.Text == "10")
                SparePlayer1 = 1;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer1 == 1)
            {

                StrikePlayer1 = 0; 
                textBox7.Text = Convert.ToString(int.Parse(textBox7.Text) + int.Parse(textBox15.Text));
                

            }
            if (StrikePlayer1 == 2)
            {
                if (PrimerTiroPlayer1() == false)
                {
                    StrikePlayer1 = 0;    
                    textBox10.Text = Convert.ToString(int.Parse(textBox10.Text) + int.Parse(textBox13.Text));
                    
                }
                else
                {
                    if (textBox15.Text == "10")
                    {
                        textBox10.Text = Convert.ToString(int.Parse(textBox10.Text) + 10);
                        StrikePlayer1 = 1;
                    }

                }
            }
            textBox31.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox7.Text) + int.Parse(textBox10.Text) + int.Parse(textBox13.Text) + int.Parse(textBox16.Text) + int.Parse(textBox19.Text) + int.Parse(textBox22.Text) + int.Parse(textBox25.Text) + int.Parse(textBox28.Text));

            if (textBox14.Text != "0" && textBox13.Text == "10")
                SparePlayer1 = 1;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer1 == 1)
            {
                StrikePlayer1 = 0;    
                textBox10.Text = Convert.ToString(int.Parse(textBox10.Text) + int.Parse(textBox18.Text));
                

            }
            if (StrikePlayer1 == 2)
            {
                if (PrimerTiroPlayer1() == false)
                {
                    StrikePlayer1 = 0;    
                    textBox13.Text = Convert.ToString(int.Parse(textBox13.Text) + int.Parse(textBox16.Text));
                    
                }
                else
                {
                    if (textBox18.Text == "10")
                    {
                        textBox13.Text = Convert.ToString(int.Parse(textBox13.Text) + 10);
                        StrikePlayer1 = 1;
                    }

                }
            }
            textBox31.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox7.Text) + int.Parse(textBox10.Text) + int.Parse(textBox13.Text) + int.Parse(textBox16.Text) + int.Parse(textBox19.Text) + int.Parse(textBox22.Text) + int.Parse(textBox25.Text) + int.Parse(textBox28.Text));

            if (textBox17.Text != "0" && textBox16.Text == "10")
                SparePlayer1 = 1;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer1 == 1)
            {
                StrikePlayer1 = 0;    
                textBox13.Text = Convert.ToString(int.Parse(textBox13.Text) + int.Parse(textBox21.Text));
                

            }
            if (StrikePlayer1 == 2)
            {
                if (PrimerTiroPlayer1() == false)
                {
                    StrikePlayer1 = 0;    
                    textBox16.Text = Convert.ToString(int.Parse(textBox16.Text) + int.Parse(textBox19.Text));
                    
                }
                else
                {
                    if (textBox21.Text == "10")
                    {
                        textBox16.Text = Convert.ToString(int.Parse(textBox16.Text) + 10);
                        StrikePlayer1 = 1;
                    }

                }
            }

            textBox31.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox7.Text) + int.Parse(textBox10.Text) + int.Parse(textBox13.Text) + int.Parse(textBox16.Text) + int.Parse(textBox19.Text) + int.Parse(textBox22.Text) + int.Parse(textBox25.Text) + int.Parse(textBox28.Text));

            if (textBox20.Text != "0" && textBox19.Text == "10")
                SparePlayer1 = 1;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer1 == 1)
            {
                StrikePlayer1 = 0;    
                textBox16.Text = Convert.ToString(int.Parse(textBox16.Text) + int.Parse(textBox24.Text));
                

            }
            if (StrikePlayer1 == 2)
            {
                if (PrimerTiroPlayer1() == false)
                {
                    StrikePlayer1 = 0;    
                    textBox19.Text = Convert.ToString(int.Parse(textBox19.Text) + int.Parse(textBox22.Text));
                    
                }
                else
                {
                    if (textBox24.Text == "10")
                    {
                        textBox19.Text = Convert.ToString(int.Parse(textBox19.Text) + 10);
                        StrikePlayer1 = 1;
                    }

                }
            }

            textBox31.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox7.Text) + int.Parse(textBox10.Text) + int.Parse(textBox13.Text) + int.Parse(textBox16.Text) + int.Parse(textBox19.Text) + int.Parse(textBox22.Text) + int.Parse(textBox25.Text) + int.Parse(textBox28.Text));

            if (textBox23.Text != "0" && textBox22.Text == "10")
                SparePlayer1 = 1;
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer1 == 1)
            {
                StrikePlayer1 = 0;    
                textBox19.Text = Convert.ToString(int.Parse(textBox19.Text) + int.Parse(textBox27.Text));
                

            }
            if (StrikePlayer1 == 2)
            {
                if (PrimerTiroPlayer1() == false)
                {
                    StrikePlayer1 = 0;    
                    textBox22.Text = Convert.ToString(int.Parse(textBox22.Text) + int.Parse(textBox25.Text));
                    
                }
                else
                {
                    if (textBox27.Text == "10")
                    {
                        textBox22.Text = Convert.ToString(int.Parse(textBox22.Text) + 10);
                        StrikePlayer1 = 1;
                    }

                }
            }

            textBox31.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox7.Text) + int.Parse(textBox10.Text) + int.Parse(textBox13.Text) + int.Parse(textBox16.Text) + int.Parse(textBox19.Text) + int.Parse(textBox22.Text) + int.Parse(textBox25.Text) + int.Parse(textBox28.Text));

            if (textBox26.Text != "0" && textBox25.Text == "10")
                SparePlayer1 = 1;
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer1 == 1)
            {
                StrikePlayer1 = 0;    
                textBox22.Text = Convert.ToString(int.Parse(textBox22.Text) + int.Parse(textBox30.Text));
                

            }
            if (StrikePlayer1 == 2)
            {
                if (PrimerTiroPlayer1() == false)
                {
                    StrikePlayer1 = 0;
                    textBox25.Text = Convert.ToString(int.Parse(textBox25.Text) + int.Parse(textBox28.Text));
                    
                }
                else
                {
                    if (textBox30.Text == "10")
                    {
                        textBox25.Text = Convert.ToString(int.Parse(textBox25.Text) + 10);
                        StrikePlayer1 = 1;
                    }

                }
            }
            textBox31.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox7.Text) + int.Parse(textBox10.Text) + int.Parse(textBox13.Text) + int.Parse(textBox16.Text) + int.Parse(textBox19.Text) + int.Parse(textBox22.Text) + int.Parse(textBox25.Text) + int.Parse(textBox28.Text));

            if (textBox29.Text != "0" && textBox28.Text == "10")
                SparePlayer1 = 1;
        }


        #endregion

        #region VerificaSparePlayer2

        private void textBox70_TextChanged(object sender, EventArgs e)
        {
            textBox32.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox67.Text) + int.Parse(textBox64.Text) + int.Parse(textBox61.Text) + int.Parse(textBox58.Text) + int.Parse(textBox55.Text) + int.Parse(textBox52.Text) + int.Parse(textBox49.Text) + int.Parse(textBox46.Text) + int.Parse(textBox43.Text));
            if (textBox71.Text != "0" && textBox70.Text == "10")
                SparePlayer2 = 1;
        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer2 == 1)
            {

            }
            if (StrikePlayer2 == 2)
            {
                if (PrimerTiroPlayer2() == false)
                {
                    StrikePlayer2 = 0;
                    textBox70.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox67.Text));
                    
                }
                else
                {
                    if (textBox69.Text == "10" && textBox66.Text == "0")
                    {
                        
                        textBox70.Text = Convert.ToString(int.Parse(textBox70.Text) + 10);
                        StrikePlayer2 = 1;
                      
                    }

                }
            }
            textBox32.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox67.Text) + int.Parse(textBox64.Text) + int.Parse(textBox61.Text) + int.Parse(textBox58.Text) + int.Parse(textBox55.Text) + int.Parse(textBox52.Text) + int.Parse(textBox49.Text) + int.Parse(textBox46.Text) + int.Parse(textBox43.Text));
            if (textBox68.Text != "0" && textBox67.Text == "10")
                SparePlayer2 = 1;
        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer2 == 1)
            {
                StrikePlayer2 = 0;
                textBox70.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox66.Text));

            }
            if (StrikePlayer2 == 2)
            {
                if (PrimerTiroPlayer2() == false)
                {

                    StrikePlayer2 = 0; 
                    textBox67.Text = Convert.ToString(int.Parse(textBox67.Text) + int.Parse(textBox64.Text));
                    
                }
                else
                {
                    if (textBox66.Text == "10")
                    {
                        
                        textBox67.Text = Convert.ToString(int.Parse(textBox67.Text) + 10);
                        StrikePlayer2 = 1;
                    }

                }
            }
            textBox32.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox67.Text) + int.Parse(textBox64.Text) + int.Parse(textBox61.Text) + int.Parse(textBox58.Text) + int.Parse(textBox55.Text) + int.Parse(textBox52.Text) + int.Parse(textBox49.Text) + int.Parse(textBox46.Text) + int.Parse(textBox43.Text));
            if (textBox65.Text != "0" && textBox64.Text == "10")
                SparePlayer2 = 1;
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer2 == 1)
            {
                StrikePlayer2 = 0;
                textBox67.Text = Convert.ToString(int.Parse(textBox67.Text) + int.Parse(textBox63.Text));
               
            }
            if (StrikePlayer2 == 2)
            {
                if (PrimerTiroPlayer2() == false)
                {
                    StrikePlayer2 = 0;
                    textBox64.Text = Convert.ToString(int.Parse(textBox64.Text) + int.Parse(textBox61.Text));
                   
                }
                else
                {
                    if (textBox63.Text == "10")
                    {
                        textBox64.Text = Convert.ToString(int.Parse(textBox64.Text) + 10);
                        StrikePlayer2 = 1;
                    }

                }
            }
            textBox32.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox67.Text) + int.Parse(textBox64.Text) + int.Parse(textBox61.Text) + int.Parse(textBox58.Text) + int.Parse(textBox55.Text) + int.Parse(textBox52.Text) + int.Parse(textBox49.Text) + int.Parse(textBox46.Text) + int.Parse(textBox43.Text));
            if (textBox62.Text != "0" && textBox61.Text == "10")
                SparePlayer2 = 1;
        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer2 == 1)
            {
                StrikePlayer2 = 0;
                textBox64.Text = Convert.ToString(int.Parse(textBox64.Text) + int.Parse(textBox60.Text));
                
            }
            if (StrikePlayer2 == 2)
            {
                if (PrimerTiroPlayer2() == false)
                {
                    StrikePlayer2 = 0;
                    textBox61.Text = Convert.ToString(int.Parse(textBox61.Text) + int.Parse(textBox58.Text));
                    
                }
                else
                {
                    if (textBox60.Text == "10")
                    {
                        textBox61.Text = Convert.ToString(int.Parse(textBox61.Text) + 10);
                        StrikePlayer2 = 1;
                    }

                }
            }
            textBox32.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox67.Text) + int.Parse(textBox64.Text) + int.Parse(textBox61.Text) + int.Parse(textBox58.Text) + int.Parse(textBox55.Text) + int.Parse(textBox52.Text) + int.Parse(textBox49.Text) + int.Parse(textBox46.Text) + int.Parse(textBox43.Text));
            if (textBox59.Text != "0" && textBox58.Text == "10")
                SparePlayer2 = 1;
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer2 == 1)
            {
                StrikePlayer2 = 0;
                textBox61.Text = Convert.ToString(int.Parse(textBox61.Text) + int.Parse(textBox57.Text));
                
            }
            if (StrikePlayer2 == 2)
            {
                if (PrimerTiroPlayer2() == false)
                {
                    StrikePlayer2 = 0;
                    textBox58.Text = Convert.ToString(int.Parse(textBox58.Text) + int.Parse(textBox55.Text));
                  
                }
                else
                {
                    if (textBox57.Text == "10")
                    {
                        textBox58.Text = Convert.ToString(int.Parse(textBox58.Text) + 10);
                        StrikePlayer2 = 1;
                    }

                }
            }
            textBox32.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox67.Text) + int.Parse(textBox64.Text) + int.Parse(textBox61.Text) + int.Parse(textBox58.Text) + int.Parse(textBox55.Text) + int.Parse(textBox52.Text) + int.Parse(textBox49.Text) + int.Parse(textBox46.Text) + int.Parse(textBox43.Text));
            if (textBox56.Text != "0" && textBox55.Text == "10")
                SparePlayer2 = 1;
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer2 == 1)
            {
                StrikePlayer2 = 0;
                textBox58.Text = Convert.ToString(int.Parse(textBox58.Text) + int.Parse(textBox54.Text));
                
            }
            if (StrikePlayer2 == 2)
            {
                if (PrimerTiroPlayer2() == false)
                {
                    StrikePlayer2 = 0;
                    textBox55.Text = Convert.ToString(int.Parse(textBox55.Text) + int.Parse(textBox52.Text));
                    
                }
                else
                {
                    if (textBox54.Text == "10")
                    {
                        textBox55.Text = Convert.ToString(int.Parse(textBox55.Text) + 10);
                        StrikePlayer2 = 1;
                    }

                }
            }
            textBox32.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox67.Text) + int.Parse(textBox64.Text) + int.Parse(textBox61.Text) + int.Parse(textBox58.Text) + int.Parse(textBox55.Text) + int.Parse(textBox52.Text) + int.Parse(textBox49.Text) + int.Parse(textBox46.Text) + int.Parse(textBox43.Text));

            if (textBox53.Text != "0" && textBox52.Text == "10")
                SparePlayer2 = 1;
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer2 == 1)
            {
                StrikePlayer2 = 0;
                textBox55.Text = Convert.ToString(int.Parse(textBox55.Text) + int.Parse(textBox51.Text));
                
            }
            if (StrikePlayer2 == 2)
            {
                if (PrimerTiroPlayer2() == false)
                {
                    StrikePlayer2 = 0;
                    textBox52.Text = Convert.ToString(int.Parse(textBox52.Text) + int.Parse(textBox49.Text));
                    
                }
                else
                {
                    if (textBox51.Text == "10")
                    {
                        textBox52.Text = Convert.ToString(int.Parse(textBox52.Text) + 10);
                        StrikePlayer2 = 1;
                    }

                }
            }
            textBox32.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox67.Text) + int.Parse(textBox64.Text) + int.Parse(textBox61.Text) + int.Parse(textBox58.Text) + int.Parse(textBox55.Text) + int.Parse(textBox52.Text) + int.Parse(textBox49.Text) + int.Parse(textBox46.Text) + int.Parse(textBox43.Text));

            if (textBox50.Text != "0" && textBox49.Text == "10")
                SparePlayer2 = 1;
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer2 == 1)
            {
                StrikePlayer2 = 0;
                textBox52.Text = Convert.ToString(int.Parse(textBox52.Text) + int.Parse(textBox48.Text));
                
            }
            if (StrikePlayer2 == 2)
            {
                if (PrimerTiroPlayer2() == false)
                {
                    StrikePlayer2 = 0;
                    textBox49.Text = Convert.ToString(int.Parse(textBox49.Text) + int.Parse(textBox46.Text));
                    
                }
                else
                {
                    if (textBox48.Text == "10")
                    {
                        textBox49.Text = Convert.ToString(int.Parse(textBox49.Text) + 10);
                        StrikePlayer2 = 1;
                    }

                }
            }
            textBox32.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox67.Text) + int.Parse(textBox64.Text) + int.Parse(textBox61.Text) + int.Parse(textBox58.Text) + int.Parse(textBox55.Text) + int.Parse(textBox52.Text) + int.Parse(textBox49.Text) + int.Parse(textBox46.Text) + int.Parse(textBox43.Text));

            if (textBox47.Text != "0" && textBox46.Text == "10")
                SparePlayer2 = 1;
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            if (StrikePlayer2 == 1)
            {
                StrikePlayer2 = 0;
                textBox46.Text = Convert.ToString(int.Parse(textBox49.Text) + int.Parse(textBox45.Text));
               
            }
            if (StrikePlayer2 == 2)
            {
                if (PrimerTiroPlayer2() == false)
                {
                    StrikePlayer2 = 0;
                    textBox46.Text = Convert.ToString(int.Parse(textBox46.Text) + int.Parse(textBox43.Text));
                    
                }
                else
                {
                    if (textBox45.Text == "10")
                    {
                        textBox46.Text = Convert.ToString(int.Parse(textBox46.Text) + 10);
                        StrikePlayer2 = 1;
                    }

                }
            }
            textBox32.Text = Convert.ToString(int.Parse(textBox70.Text) + int.Parse(textBox67.Text) + int.Parse(textBox64.Text) + int.Parse(textBox61.Text) + int.Parse(textBox58.Text) + int.Parse(textBox55.Text) + int.Parse(textBox52.Text) + int.Parse(textBox49.Text) + int.Parse(textBox46.Text) + int.Parse(textBox43.Text));

            if (textBox44.Text != "0" && textBox43.Text == "10")
                SparePlayer2 = 1;
        }

        #endregion



    }
}
