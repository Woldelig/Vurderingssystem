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
    public partial class MyCourses : UserControl
    {
        public MyCourses()
        {
            InitializeComponent();
        }
        int antallGangerKnappenErTrykket = 0;
        private void MyCourses_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            String sql = "SELECT fagkode FROM fag;";
            var mySqlCommand = db.SqlCommand(sql);
            int row = 0; //10
            int column = 0; //3
            string fagkode = "";
            
            try
            {
                db.OpenConnection();
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (column > 2)
                        {
                            column = 0;
                            row++;

                            if (row > 10)
                            {
                                row = 0;
                            }
                        }

                        fagkode = reader.GetString("fagkode");
                        Button button = new Button();
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        button.Name = fagkode;
                        button.Text = fagkode;
                        button.Left = column * 145;
                        button.Top = row * 50;
                        button.Width = 145;
                        button.Height = 50;
                        button.Click += new EventHandler(Button_Click);
                        MyCoursesPanel.Controls.Add(button);
                        column++;
                    }
                }
            }
            catch (MySqlException DBexception)
            {

                Console.WriteLine("Feilmelding: ", DBexception);
            }


        }
        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            label1.Text = button.Name;
            if (antallGangerKnappenErTrykket == 0)
            {
                FagkodeNr1.Text = button.Text;
                antallGangerKnappenErTrykket++;
            }
            else
            {
                FagkodeNr2.Text = button.Text;
                antallGangerKnappenErTrykket--;
            }
        }
    }
}
