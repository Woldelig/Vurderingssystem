using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminPanel
{
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
 
        public MainForm()
        {
            InitializeComponent();
        }

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
                //Kunne flytte på vinduet ved å klikke og dra i LogoPanel
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void LogoPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();//Avslutter
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//Minimerer vinduet
        }

        private void HomeBtn_MouseEnter(object sender, EventArgs e)
        {
            HomeBtn.ForeColor = Color.FromArgb(70, 130, 180);//Endrer fargen på teksten til knappen
        }

        private void HomeBtn_MouseLeave(object sender, EventArgs e)
        {
            HomeBtn.ForeColor = Color.Black;//Setter knappen tilbake til svart
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ButtonToggle(sender);//Sender knappen til metoden ButtonToggel for å kunne vise brukeren hvor hen befinner seg i applikasjonen

            foreach(Control ctrl in ContainerPanel.Controls)
            {
                ctrl.Dispose();//Fjerner alle de componentene fra tidligere valgt side
            }
            ContainerPanel.Controls.Add(new Home());//Setter ny UserControl - Her settes Hjem til å vises i ContainerPanel
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

        private void ButtonToggle(object sender) //Setter hvilken knapp som skal ha focus. Ikke den beste løsningen
        {
            HomeBtn.BackColor = Color.LightSlateGray;
            CoursesBtn.BackColor = Color.LightSlateGray;
            StatsBtn.BackColor = Color.LightSlateGray;
            SchemaBtn.BackColor = Color.LightSlateGray;
            SqlBtn.BackColor = Color.LightSlateGray;

            ((Control)sender).BackColor = Color.FromArgb(86, 99, 112);
        }

        private void ShutdownBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            //Her må timestampen i databasen oppdateres
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
    }
}
