using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace adminPanel
{
    public partial class NyttSemester : UserControl
    {
        public NyttSemester()
        {
            InitializeComponent();
            FeilmeldingLbl.Text = "";
            AvsluttVurderingFeilmeldingLbl.Text = "";

            //Event handlers blir definert under. Mye lettere å håndtere de her enn i design. Spesielt hvis man skal endre navn.
            NyTabellGodkjennNyttSemesterLbl.MouseDown += new MouseEventHandler(NyTabellGodkjennNyttSemesterLbl_MouseDown);
            NyTabellIkkeGodkjennNyttSemesterLbl.MouseDown += new MouseEventHandler(NyTabellIkkeGodkjennNyttSemesterLbl_MouseDown);
            GodkjennAvsluttVurderingLbl.MouseDown += new MouseEventHandler(GodkjennAvsluttVurderingLbl_MouseDown);
            IkkeGodkjennAvsluttVurderingLbl.MouseDown += new MouseEventHandler(IkkeGodkjennAvsluttVurderingLbl_MouseDown);
            NyTabellValideringsTextBox.AllowDrop = true;
            NyTabellValideringsTextBox.DragEnter += new DragEventHandler(NyTabellValideringsTextBox_DragEnter);
            NyTabellValideringsTextBox.DragDrop += new DragEventHandler(NyTabellValideringsTextBox_DragDrop);
            GodkjennAvsluttVurderingTextbox.AllowDrop = true;
            GodkjennAvsluttVurderingTextbox.DragEnter += new DragEventHandler(GodkjennAvsluttVurderingTextbox_DragEnter);
            GodkjennAvsluttVurderingTextbox.DragDrop += new DragEventHandler(GodkjennAvsluttVurderingTextbox_DragDrop);

            //Her lages tooltip for å hjelpe brukeren. Tallene representerer tid
            ToolTip tooltip1 = new ToolTip();
            tooltip1.AutoPopDelay = 1500;
            tooltip1.InitialDelay = 700;
            tooltip1.ReshowDelay = 500;
            tooltip1.ShowAlways = true;

            //Her setter vi tekstverdiene. Vi kan bruke tooltip objektet for all kontrollene
            tooltip1.SetToolTip(this.TabellNavnLbl, "Skriv inn hva du vil navngi tabellen med vurderingshistorikk fra dette semesteret.");
            tooltip1.SetToolTip(this.StartNyttSemesterBtn, "Skriv inn hva du vil navngi tabellen med vurderingshistorikk fra dette semesteret.");
            tooltip1.SetToolTip(this.TabellNavnTextbox, "Skriv inn hva du vil navngi tabellen med vurderingshistorikk fra dette semesteret.");
            tooltip1.SetToolTip(this.NyTabellGodkjennNyttSemesterLbl, "Dra meg over til valideringsboksen for å godkjenne handlingen.");
            tooltip1.SetToolTip(this.NyTabellIkkeGodkjennNyttSemesterLbl, "Dra meg over til valideringsboksen for å godkjenne ikke handlingen.");
        }
        private void NyTabellGodkjennNyttSemesterLbl_MouseDown(object sender,MouseEventArgs e)
        {
            DoDragDrop(NyTabellGodkjennNyttSemesterLbl.Text, DragDropEffects.Copy);
        }
        private void NyTabellIkkeGodkjennNyttSemesterLbl_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(NyTabellIkkeGodkjennNyttSemesterLbl.Text, DragDropEffects.Copy);
        }
        private void IkkeGodkjennAvsluttVurderingLbl_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(IkkeGodkjennAvsluttVurderingLbl.Text, DragDropEffects.Copy);
        }
        private void GodkjennAvsluttVurderingLbl_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(GodkjennAvsluttVurderingLbl.Text, DragDropEffects.Copy);
        }
        private void NyTabellValideringsTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }
        private void NyTabellValideringsTextBox_DragDrop(object sender, DragEventArgs e)
        {
            NyTabellValideringsTextBox.Text = (String)e.Data.GetData(DataFormats.Text);
        }
        private void GodkjennAvsluttVurderingTextbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }
        private void GodkjennAvsluttVurderingTextbox_DragDrop(object sender, DragEventArgs e)
        {
            GodkjennAvsluttVurderingTextbox.Text = (String)e.Data.GetData(DataFormats.Text);
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

        private void StartNyttSemesterBtn_Click(object sender, EventArgs e)
        {
            FeilmeldingLbl.ForeColor = Color.Red;
            //Under sjekker vi først at tekstboksen ikke er tom eller bare har whitespace, deretter sjekker vi valideringstekstboksen
            if (String.IsNullOrWhiteSpace(TabellNavnTextbox.Text))
            {
                FeilmeldingLbl.Text = "Tekstboksen må ha et navn";
            }
            else if (NyTabellValideringsTextBox.Text != "Godkjenn")
            {
                FeilmeldingLbl.Text = "Du må godkjenne handlingen med valideringsteksboksen!";
            }
            else
            {
                Database db = new Database();
                var cmd = db.SqlCommand("SELECT * FROM information_schema.tables WHERE table_schema = 'vurderingssystem' AND table_name = @tabell LIMIT 1;");
                //Setningen over sjekker om tabellen eksisterer. Man kan ikke bruke en vanlig select * from tabellnavn
                //grunnen til dette er at hvis tabellen ikke eksisterer vil mysql gi en feilmelding
                cmd.Parameters.AddWithValue("@tabell", TabellNavnTextbox.Text);
                db.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    FeilmeldingLbl.Text = "Tabellnavnet finnes fra før!";
                    db.CloseConnection();
                    return;
                }
                db.CloseConnection();


                cmd = db.SqlCommand("lagre_pågående_evaluerings_resultater");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ny_tabell", TabellNavnTextbox.Text).Direction = ParameterDirection.Input;
                db.OpenConnection();
                try
                {
                    cmd.ExecuteNonQuery();
                    FeilmeldingLbl.ForeColor = Color.Black;
                    FeilmeldingLbl.Text = "Prosedyren er utført.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                db.CloseConnection();
            }
        }

        private void AvsluttVurderingBtn_Click(object sender, EventArgs e)
        {
            AvsluttVurderingFeilmeldingLbl.ForeColor = Color.Red;
            if (GodkjennAvsluttVurderingTextbox.Text != "Godkjenn")
            {
                AvsluttVurderingFeilmeldingLbl.Text = "Du må godkjenne handlingen med valideringsteksboksen!";
                return;
            }
            Database db = new Database();
            var cmd = db.SqlCommand("avslutt_evaluering");
            cmd.CommandType = CommandType.StoredProcedure;
            db.OpenConnection();
            try
            {
                cmd.ExecuteNonQuery();
                AvsluttVurderingFeilmeldingLbl.ForeColor = Color.Black;
                AvsluttVurderingFeilmeldingLbl.Text = "Vurderingen er nå avsluttet.";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            db.CloseConnection();
        }
    }
}
