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
    public partial class Inversor : Form
    {

        public static Inversor p1 = null;


        public Inversor()
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

       // internal static void ActiveForm()
      //  {
       //     throw new NotImplementedException();
      //  }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new atv12());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
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
            OpenChildForm(new atv320());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new atv340());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new atv600());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new atv900());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new atv212());
            panelChildForm.AutoScroll = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void PanelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
