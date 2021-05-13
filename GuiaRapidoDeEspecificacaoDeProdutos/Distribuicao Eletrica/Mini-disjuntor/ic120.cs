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
    public partial class ic120 : Form
    {
        public ic120()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Disjuntor.p1.showPanel();
        }
    }
}
