using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dummyData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //14
            string[] fornavn = new string[]
            {
                "Jan", "Vetle", "Christoffer", "Jean", "Truls", "Anette", "Claudia", "Line", "Max", "Heidi", "Rune", "Johanne", "Berit", "Herman"
            };
            //14
            string[] etternavn = new string[]
            {
                "Haugan", "Wold", "Gunnerød", "Ødegaard", "Hansen", "Jensen", "Olsen", "Bruun", "Flæthe", "Michelsen", "Jacobsen", "Simensen", "Mohammad", "Bertsen"
            };
            //7
            string[] stuide = new string[]
            {
                "It og informasjonssystemer", "Dataingeniør", "Produktdesign", "Regnskap og revisjon", "Nautikk", "Sosiologi", "Sykepleie"
            };

            Random rnd = new Random();
            int forn = rnd.Next(0, 15);
            int ettern = rnd.Next(0, 15);
            string navn = "";

            navn = fornavn[forn] + " " + etternavn[ettern];

            Console.WriteLine(navn);

        }
    }
}
