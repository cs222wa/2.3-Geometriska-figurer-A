using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{
    class Rectangle : Shape
        //Klassen Rectangle ärver från den abstrakta basklassen Shape. I och med att det ska gå att instansiera 
        //objekt av klassen, d.v.s. den ska vara konkret, måste den implementera de abstrakta egenskaperna 
        //Area och Perimeter i basklassen.
    {
        public override double Area
        {
            get
            {
                return Length*Width;
            }
        }

        // 𝐴𝑟𝑒𝑎 = 𝑙 ∙ 𝑤
        //length * width

        //Publik egenskapen av typen double som ska ge en rektangel area

        public override double Perimeter
        {
            get
            {
                return 2*Length + 2*Width;
            }
        }

        //𝑂𝑚𝑘𝑟𝑒𝑡𝑠 = 2𝑙 + 2𝑤
        //2 * l + 2 * w

        //Publik egenskapen av typen double som ska ge en rektangel omkrets.

        public Rectangle(double length, double width) : base (length, width)
        {
            //Publik konstruktor som genom anrop av basklassens konstruktor ser till att det nya objektets längd och 
            //bredd sätts
        }
    }
}
