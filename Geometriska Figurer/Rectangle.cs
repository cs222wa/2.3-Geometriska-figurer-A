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
        public double Area
        { get; }
        //Publik egenskapen av typen double som ska ge en rektangel area

        public double Perimeter
        { get; }
        //Publik egenskapen av typen double som ska ge en rektangel omkrets.

        public double Rectangle(double lenght, double width)
        {
            //Publik konstruktor som genom anrop av basklassens konstruktor ser till att det nya objektets längd och 
            //bredd sätts
        }
    }
}
