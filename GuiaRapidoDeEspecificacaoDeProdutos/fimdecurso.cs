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
    public partial class fimdecurso : Form
    {
        public fimdecurso()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OsiSenseXC());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel6.Visible = false;
            //  panelChildForm.AutoScroll = false;
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
