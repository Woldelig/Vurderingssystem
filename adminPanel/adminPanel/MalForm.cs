using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminPanel
{
    public partial class MalForm : Form
    {
        public MalForm()
        {
            InitializeComponent();
            UserLbl.Text = "Hei, " + UserInfo.Username; //Setter brukernavnet til brukeren i labelen UserLbl
        }

        private void avsluttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sQLEditorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Legg til metode når form er laget
        }

        private void statistikkOgDiagrammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Legg til metode når form er laget
        }

        private void vurderingsskjemaerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Legg til metode når form er laget
        }

        private void hjelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                ("Dette er en"+ Environment.NewLine
                + "hjelp meny");
            //Dette er en mulig måte og lage hjelp meny på
            //linjeskift kan man få ved å bruke
            //Environment.NewLine
        }

        private void loggOutBtnVelkomst_Click(object sender, EventArgs e)
        {
            Application.Restart(); //Bruker denne så lenge. Er vist ikke best-practice!!
        }

        private void MalForm_Load(object sender, EventArgs e)
        {

        }
    }
}