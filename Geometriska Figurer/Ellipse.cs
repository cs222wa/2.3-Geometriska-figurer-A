using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{
    /// <summary>
    ///Klassen Ellipse ärver från den abstrakta basklassen Shape. I och med att det ska gå att instansiera 
    ///objekt av klassen, d.v.s. den ska vara konkret, måste den implementera de abstrakta egenskaperna 
    ///Area och Perimeter i basklassen
    /// </summary>
    class Ellipse : Shape
    {
        public override double Area   //Publik egenskapen av typen double som ska ge en ellips area 
        {
            get
            {
                return Math.PI * Length / 2 * Width / 2;
            }
        }
        //  𝑎*2 = length
        //  𝑏*2 = width
        //  formeln för en ellips area är: 𝐴𝑟𝑒𝑎 = 𝜋 ∙ 𝑎 ∙ b 
        //  och skrivs i C#: Math.PI * a * b

        public override double Perimeter  //Publik egenskapen av typen double som ska ge en ellips omkrets.
        {
            get
            {
                return Math.PI * Math.Sqrt(2 * Length / 2 * Length / 2 + 2 * Width / 2 * Width / 2);
            }
        }
        //  𝑎*2 = length
        //  𝑏*2 = width
        //Formeln för en ellips omkrets är: 𝜋 roten ur 2𝑎2 + 2𝑏2  
        //och skrivs i C#: Math.PI * Math.Sqrt(2 * a * a + 2 * b * b)

        public Ellipse(double length, double width)     //Publik konstruktor som genom anrop av basklassens konstruktor   
            : base(length, width)                       //ser till att det nya objektets längd och bredd sätts 
        {
        }
    }
}
