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
    public partial class Form1 : Form
    {
        public Form1()
        {

          //  Thread t = new Thread(new ThreadStart(StartForm));
          //  t.Start;
         //   Thread.Sleep(5000);
            InitializeComponent();
           //   customizeDesign();
            OpenChildForm(new Inicio());
           // t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new loadPage());
        }

        private void customizeDesign ()
        {

            panelAutomacao.Visible = false;
            panelCI.Visible = false;
            panelDistribuicao.Visible = false;
            panelMotion.Visible = false;
            panelAPC.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelAutomacao.Visible == true)
                panelAutomacao.Visible = false;
            if (panelCI.Visible == true)
                panelCI.Visible = false;
            if (panelDistribuicao.Visible == true)
                panelDistribuicao.Visible = false;
            if (panelMotion.Visible == true)
                panelMotion.Visible = false;
            if (panelAPC.Visible == true)
                panelAPC.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SbreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Automacao_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAutomacao);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new clp());

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            indisponivel ind = new indisponivel();
            ind.ShowDialog();
            
            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IHM());
           // indisponivel ind = new indisponivel();
          //  ind.ShowDialog();

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            indisponivel ind = new indisponivel();
            ind.ShowDialog();

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCI);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDistribuicao);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMotion);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new contator());
      
            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            indisponivel ind = new indisponivel();
            ind.ShowDialog();

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            indisponivel ind = new indisponivel();
            ind.ShowDialog();

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            indisponivel ind = new indisponivel();
            ind.ShowDialog();

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            indisponivel ind = new indisponivel();
            ind.ShowDialog();

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Botao());

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fimdecurso());
            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Disjuntor());
            
            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReleProtecao());

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            //indisponivel ind = new indisponivel();
            //ind.ShowDialog();

            OpenChildForm(new capacitor());
            hideSubMenu();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            indisponivel ind = new indisponivel();
            ind.ShowDialog();

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            OpenChildForm(new transformador_corrente());

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inversor());

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            // indisponivel ind = new indisponivel();
          //  ind.ShowDialog();
           OpenChildForm(new softstarter());
            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            indisponivel ind = new indisponivel();
            ind.ShowDialog();
            hideSubMenu();
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

        private void Button27_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAPC);
        }

        private void AutomaçãoIndustrialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAutomacao);
        }

        private void ControleIndustrialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCI);
        }

        private void DistribuiçãoElétricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDistribuicao);
        }

        private void MotionDrivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMotion);
        }

        private void APCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAPC);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelDistribuicao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button29_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre sb = new sobre();
            sb.ShowDialog();
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            indisponivel ind = new indisponivel();
            ind.ShowDialog();
            hideSubMenu();
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            OpenChildForm(new caixamoldada());

            //colocar o codigo aqui
            hideSubMenu();
        }

        private void Button29_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.se.com/br/pt/work/products/industrial-automation-control/tools/motor-control-configurator.jsp");
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            OpenChildForm(new seletor_monofasico());
            hideSubMenu();
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
