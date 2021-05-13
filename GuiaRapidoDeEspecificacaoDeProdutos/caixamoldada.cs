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
    public partial class caixamoldada : Form
    {
        public caixamoldada()
        {
            InitializeComponent();
        }

        public static caixamoldada p1 = null;

        public void showPanel()
        {
            panel4.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panelChildForm.AutoScroll = true;

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
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ezc());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            p1 = this;
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new cvs());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new nsx());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ns());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
        }
    }
}
