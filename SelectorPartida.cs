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
    public partial class SelectorPartidas : Form
    {
        public SelectorPartidas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnalistaPartidas Analista = new AnalistaPartidas();
            if (comboBox1.SelectedItem != null)
            {
                Analista.Partida = comboBox1.SelectedItem.ToString();
                this.Hide();
                Analista.Show();
            }
            else
                MessageBox.Show("Seleccione una Partida antes de Continuar.", "Partida no Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Esta seguro que desea salir de la aplicacion?",
        "Desea Salir?",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SelectorPartidas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SelectorPartidas_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] rgFiles = di.GetFiles("*.txt");

            foreach (FileInfo fi in rgFiles)
            {
                if(fi.Name.Contains("boliche"))
                    comboBox1.Items.Add(fi.Name);
            }

        }
    }
}
