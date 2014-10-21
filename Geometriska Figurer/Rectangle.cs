using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{
    /// <summary>
    ///Klassen Rectangle ärver från den abstrakta basklassen Shape. I och med att det ska gå att instansiera 
    ///objekt av klassen, d.v.s. den ska vara konkret, måste den implementera de abstrakta egenskaperna 
    ///Area och Perimeter i basklassen.
    /// </summary>
    class Rectangle : Shape
    {
        public override double Area   //Publik egenskapen av typen double som ska ge en rektangel area
        {
            get
            {
                return Length * Width;    // Formeln för en rektangels area är : 𝑙 ∙ 𝑤   dvs, längden * bredden
            }
        }

        public override double Perimeter  //Publik egenskapen av typen double som ska ge en rektangel omkrets.
        {
            get
            {
                return 2 * Length + 2 * Width;  //Formeln för en rektangels omkrets är: 2𝑙 + 2𝑤   dvs, 2*längden + 2*bredden
            }
        }
        
        public Rectangle(double length, double width)       //Publik konstruktor som genom anrop av basklassens konstruktor
            : base(length, width)                           //ser till att det nya objektets längd och bredd sätts 
        {
        }
    }
}
