﻿using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace adminPanel
{
    // Lager og tenger hele skallet for applikasjonen.
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
 
        public MainForm()
        {
            InitializeComponent();
        }

        // Setter "Hjem" til å være startsiden.
        private void MainForm_Load(object sender, EventArgs e)
        {
            HomeBtn.PerformClick();
        }

        private void LogoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LogoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Kunne flytte på vinduet ved å klikke og dra i LogoPanel
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void LogoPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // Avslutter applikasjonen.
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            UpdateLastLogin();
            Application.Exit();
        }

        // Minimerer vinduet
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Endrer fargen til teksten på knappen når musa er over.
        private void HomeBtn_MouseEnter(object sender, EventArgs e)
        {
            // Hjem-knappen får en ny farge
            HomeBtn.ForeColor = Color.FromArgb(70, 130, 180);
        }

        // Setter fagen tilbake når musa forlater knappen
        private void HomeBtn_MouseLeave(object sender, EventArgs e)
        {
            // Setter fargen tilbake til svart
            HomeBtn.ForeColor = Color.Black;
        }

        // Når knappen trykkes
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            /* 
             * Sender knappen til metoden ButtonToggel.
             * Her vil knappen bli markert for å letter visualisere hvilken
             * undersiden brukeren befinner seg på i applikasjonen.
            */
            ButtonToggle(sender);

            foreach(Control ctrl in ContainerPanel.Controls)
            {
                // Fjerner alle de componentene fra tidligere valgt side, altså oppdaterer viewen.
                ctrl.Dispose();
            }
            // Setter ny UserControl - Her settes Hjem til å vises i ContainerPanel
            ContainerPanel.Controls.Add(new Home());
        }

        private void CoursesBtn_Click(object sender, EventArgs e)
        { 
            ButtonToggle(sender);

            foreach (Control ctrl in ContainerPanel.Controls)
            {
                ctrl.Dispose();
            }
            ContainerPanel.Controls.Add(new MyCourses());
        }

        private void CoursesBtn_MouseEnter(object sender, EventArgs e)
        {
            CoursesBtn.ForeColor = Color.FromArgb(70, 130, 180);
        }

        private void CoursesBtn_MouseLeave(object sender, EventArgs e)
        {
            CoursesBtn.ForeColor = Color.Black;
        }

        private void StatsBtn_MouseEnter(object sender, EventArgs e)
        {
            StatsBtn.ForeColor = Color.FromArgb(70, 130, 180);
        }

        private void StatsBtn_MouseLeave(object sender, EventArgs e)
        {
            StatsBtn.ForeColor = Color.Black;
        }

        private void StatsBtn_Click(object sender, EventArgs e)
        {
            ButtonToggle(sender);

            foreach (Control ctrl in ContainerPanel.Controls)
            {
                ctrl.Dispose();
            }
            ContainerPanel.Controls.Add(new Stats());
        }

        private void SchemaBtn_MouseEnter(object sender, EventArgs e)
        {
            SchemaBtn.ForeColor = Color.FromArgb(70, 130, 180);
        }

        private void SchemaBtn_MouseLeave(object sender, EventArgs e)
        {
            SchemaBtn.ForeColor = Color.Black;
        }

        private void SchemaBtn_Click(object sender, EventArgs e)
        {
            ButtonToggle(sender);

            foreach (Control ctrl in ContainerPanel.Controls)
            {
                ctrl.Dispose();
            }
            ContainerPanel.Controls.Add(new Schema());
        }

        private void SqlBtn_MouseEnter(object sender, EventArgs e)
        {
            SqlBtn.ForeColor = Color.FromArgb(70, 130, 180);
        }

        private void SqlBtn_MouseLeave(object sender, EventArgs e)
        {
            SqlBtn.ForeColor = Color.Black;
        }

        private void SqlBtn_Click(object sender, EventArgs e)
        {
            ButtonToggle(sender);

            foreach (Control ctrl in ContainerPanel.Controls)
            {
                ctrl.Dispose();
            }
            ContainerPanel.Controls.Add(new SqlEditor());
        }
        /*
         * Metoden enderer fargen på valgt underside slik at brukeren enklere
         * kan finne ut av hvor i applikasjonen man befinner seg.
        */
        private void ButtonToggle(object sender) 
        {
            HomeBtn.BackColor = Color.LightSlateGray;
            CoursesBtn.BackColor = Color.LightSlateGray;
            StatsBtn.BackColor = Color.LightSlateGray;
            SchemaBtn.BackColor = Color.LightSlateGray;
            SqlBtn.BackColor = Color.LightSlateGray;
            NyttSemesterBtn.BackColor = Color.LightSlateGray;
            SammenlignFlereFagBtn.BackColor = Color.LightSlateGray;

            ((Control)sender).BackColor = Color.FromArgb(86, 99, 112);
        }

        private void ShutdownBtn_Click(object sender, EventArgs e)
        {
            UpdateLastLogin();
            Application.Exit();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            UpdateLastLogin();
            Application.Restart();
        }

        private void LogOutBtn_MouseEnter(object sender, EventArgs e)
        {
            LogOutBtn.ForeColor = Color.FromArgb(70, 130, 180);
        }

        private void LogOutBtn_MouseLeave(object sender, EventArgs e)
        {
            LogOutBtn.ForeColor = Color.Black;
        }

        private void ShutdownBtn_MouseEnter(object sender, EventArgs e)
        {
            ShutdownBtn.ForeColor = Color.FromArgb(70, 130, 180);
        }

        private void ShutdownBtn_MouseLeave(object sender, EventArgs e)
        {
            ShutdownBtn.ForeColor = Color.Black;
        }

        // Oppdatere tidsstempelet på sist innlogget i databasen
        private void UpdateLastLogin()
        {
            Database db = new Database();
            db.OpenConnection();

            // Sjekker først om brukeren har en rad i tabellen innloggingshistorikk
            String sql = "SELECT bruker FROM innloggingshistorikk WHERE bruker = @Brukernavn;";
            var mySqlCommand = db.SqlCommand(sql);
            mySqlCommand.Parameters.AddWithValue("@Brukernavn", UserInfo.Username);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            // Hvis brukeren finnes gjør vi bare en enkel update med sqlfunksjonen now()
            if (reader.HasRows)
            {
                reader.Close();
                sql = "UPDATE innloggingshistorikk SET tidsstempel=now() WHERE bruker = @Brukernavn;";
                mySqlCommand = db.SqlCommand(sql);
                mySqlCommand.Parameters.AddWithValue("@Brukernavn", UserInfo.Username);
                mySqlCommand.ExecuteNonQuery();
            }

            // Hvis brukeren ikke finnes gjør vi en insert, samme her så bruker vi funksjonen now()
            else
            {
                reader.Close();
                sql = "INSERT INTO innloggingshistorikk (bruker, tidsstempel) VALUES (@Brukernavn, now());";
                mySqlCommand = db.SqlCommand(sql);
                mySqlCommand.Parameters.AddWithValue("@Brukernavn", UserInfo.Username);
                mySqlCommand.ExecuteNonQuery();
            }
            reader.Close();
            db.CloseConnection();
        }

        private void NyttSemesterBtn_Click(object sender, EventArgs e)
        {
            ButtonToggle(sender);

            foreach (Control ctrl in ContainerPanel.Controls)
            {
                ctrl.Dispose();
            }
            ContainerPanel.Controls.Add(new NyttSemester());
        }
        private void NyttSemesterBtn_MouseEnter(object sender, EventArgs e)
        {
            NyttSemesterBtn.ForeColor = Color.FromArgb(70, 130, 180);
        }

        private void NyttSemesterBtn_MouseLeave(object sender, EventArgs e)
        {
            NyttSemesterBtn.ForeColor = Color.Black;
        }
        private void SammenlignFlereFagBtn_Click_1(object sender, EventArgs e)
        {
            ButtonToggle(sender);

            foreach (Control ctrl in ContainerPanel.Controls)
            {
                ctrl.Dispose();
            }
            ContainerPanel.Controls.Add(new SammenlignFlereFagkoder());
        }
        private void SammenlignFlereFagBtn_MouseEnter(object sender, EventArgs e)
        {
            SammenlignFlereFagBtn.ForeColor = Color.FromArgb(70, 130, 180);
        }

        private void SammenlignFlereFagBtn_MouseLeave(object sender, EventArgs e)
        {
            SammenlignFlereFagBtn.ForeColor = Color.Black;
        }

    }
}
