using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adminPanel
{
    class FormPosition
    {
        static private Point pos;

        static public Point Pos
        {
            get
            {
                return pos;
            }

            set
            {
                pos = value;
            }
        }
    }
}
