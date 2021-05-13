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
    public partial class clp : Form
    {

        public static clp p1 = null;
        public clp()
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
        private void Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new m221());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            p1 = this;
            panel2.Visible = true;
        }
        public void showPanel()
        {
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panelChildForm.AutoScroll = true;

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new m241());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new m251());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            indisponivel ind = new indisponivel();
            ind.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            indisponivel ind = new indisponivel();
            ind.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            indisponivel ind = new indisponivel();
            ind.ShowDialog();
        }
    }
}
