using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using static fluxoDeCaixa.DBConnect;

namespace fluxoDeCaixa
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Radius.ArredondaPanel(panel1, 25, true, true);
            Radius.ArredondaBt(button1, 35, true, true);
            Radius.ArredondaDGV(dgvDetalhes, 35, true, true);
            Radius.ArredondaDGV(dgvEntradas, 35, true, true);
            Radius.ArredondaDGV(dgvSaldos, 35, true, true);
            Radius.ArredondaDGV(dgvSaidas, 35, true, true);

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.DarkSlateGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect.select(dgvEntradas);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            DialogResult fecharJanela =  MessageBox.Show("Deseja Realmente Fechar o Fluxo de Caixa?", "Fechar Janela", MessageBoxButtons.YesNo);
            if (fecharJanela == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
            
        }

        private void lbMinim_Click(object sender, EventArgs e)  
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
