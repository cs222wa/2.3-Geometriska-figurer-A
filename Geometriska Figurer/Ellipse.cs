using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{
    class Ellipse : Shape
        //Klassen Ellipse ärver från den abstrakta basklassen Shape. I och med att det ska gå att instansiera 
        //objekt av klassen, d.v.s. den ska vara konkret, måste den implementera de abstrakta egenskaperna 
        //Area och Perimeter i basklassen
    {
        public override double Area
        {
            get
            {
                return 0;
            }
        }

        //  𝑎/2 = length
      
        //  𝑏/2 = width

        //  𝐴𝑟𝑒𝑎 = 𝜋 ∙ 𝑎 ∙ b =
        //  Math.PI * a * b

        //Publik egenskapen av typen double som ska ge en ellips area

        public override double Perimeter
        { 
            get
            {
                return 0;
            }
        }

        //  𝑎/2 = length
        //  𝑏/2 = width

        //𝑂𝑚𝑘𝑟𝑒𝑡𝑠 = 𝜋 roten ur 2𝑎2 + 2𝑏2   =
        //Math.PI * Math.Sqrt(2 * a * a + 2 * b * b)

        //Publik egenskapen av typen double som ska ge en ellips omkrets.

        public Ellipse(double length, double width) : base (length, width)
        {
        //Publik konstruktor som genom anrop av basklassens konstruktor ser till att det nya objektets längd och 
        //bredd sätts

            // Shape(argument för  lenght, argument för width);
            
        }
    }
}
