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
    public partial class contator : Form
    {

        public static contator p1 = null;
        public contator()
        {
            InitializeComponent();
        }
        
        public void showPanel()
        {
            panel1.Visible = true;
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
        private void Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new tesysK());
            panelChildForm.AutoScroll = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        private void Panel2_Paint_1(object sender, PaintEventArgs e)
        {
            p1 = this;
            panel2.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new tesysD());
            panelChildForm.AutoScroll = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new tesysF());
            panelChildForm.AutoScroll = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {

            OpenChildForm(new tesysD());
            panelChildForm.AutoScroll = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new tesysK());
            panelChildForm.AutoScroll = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new tesysF());
            panelChildForm.AutoScroll = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            indisponivel ind = new indisponivel();
            ind.ShowDialog();
        }
    }
    }
