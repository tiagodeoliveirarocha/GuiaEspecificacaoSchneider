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
    public partial class tesysK : Form
    {
        public tesysK()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            this.Close();
            contator.p1.showPanel();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
