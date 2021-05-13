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
    public partial class Disjuntor : Form
    {

        public static Disjuntor p1 = null;
        public Disjuntor()
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
        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           OpenChildForm(new easy9());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;

            //  BrowserIC60 haha = new BrowserIC60();
            //  haha.Show();
        }
         private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ic60());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;

        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

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

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ic120());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ng125());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }
    }
}
