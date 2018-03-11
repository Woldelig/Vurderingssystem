using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminPanel
{
    public partial class NyttSemester : UserControl
    {
        public NyttSemester()
        {
            InitializeComponent();
            GodkjennNyttSemesterLbl.MouseDown += new MouseEventHandler(GodkjennNyttSemesterLbl_MouseDown);
            textBox1.AllowDrop = true;
            textBox1.DragEnter += new DragEventHandler(textBox1_DragEnter);
            textBox1.DragDrop += new DragEventHandler(textBox1_DragDrop);
            ValideringsTextBox.AllowDrop = true;
            ValideringsTextBox.DragEnter += new DragEventHandler(ValideringsTextBox_DragEnter);
            ValideringsTextBox.DragDrop += new DragEventHandler(ValideringsTextBox_DragDrop);
        }
        private void GodkjennNyttSemesterLbl_MouseDown(object sender,MouseEventArgs e)
        {
            DoDragDrop(GodkjennNyttSemesterLbl.Text, DragDropEffects.Copy);
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            textBox1.Text = (String)e.Data.GetData(DataFormats.Text);
        }
        private void ValideringsTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }
        private void ValideringsTextBox_DragDrop(object sender, DragEventArgs e)
        {
            ValideringsTextBox.Text = (String)e.Data.GetData(DataFormats.Text);
        }

        private void HjelpBtn_Click(object sender, EventArgs e)
        {
            String hjelpetekst = "En ny vurdering vil plassere eldre vurderingshistorikk i en ny tabell." +
                "Tabellnavnet velger du i tekstboksen nedenfor." +
                "For å godkjenne handlingen om å starte en ny semestervurdering må du dra ordet godkjenn over i godkjenningstekstboksen.";
            //plus symbolene gir linjeskift i messagebox
            MessageBox.Show(hjelpetekst,"Hjelp", MessageBoxButtons.OK);
            //Parameter nr 2 setter tittelen til messagebox og parameter 3 legger til en ok knapp
        }
    }
}
