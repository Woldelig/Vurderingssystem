using System.Drawing;

namespace adminPanel
{
    // En egen aksessor og mutator for å hente ut posisjonen på selve formen.
    class FormPosition
    {
        static private Point pos;

        static public Point Pos
        {
            // Get-metoden
            get
            {
                return pos;
            }
            // Set-metoden
            set
            {
                pos = value;
            }
        }
    }
}
