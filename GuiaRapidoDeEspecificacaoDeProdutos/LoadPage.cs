using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiaRapidoDeEspecificacaoDeProdutos
{
    public partial class loadPage : Form
    {
        public loadPage()
        {

            InitializeComponent();
       
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            barra.Width += 3;
            if(barra.Width >= 390)
            {
                timer1.Stop();
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
                              
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
