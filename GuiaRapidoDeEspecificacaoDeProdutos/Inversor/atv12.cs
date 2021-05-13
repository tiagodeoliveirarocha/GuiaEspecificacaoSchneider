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
    public partial class atv12 : Form
    {

        public atv12()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            this.Close();
            Inversor.p1.showPanel();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
