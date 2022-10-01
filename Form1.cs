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

namespace fluxoDeCaixa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {

           Radius.ArredondaPanel(panel1, 25, true, true);
            Radius.ArredondaBt(button1, 35, true, true);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.DarkSlateGray;
        }
    }
}
