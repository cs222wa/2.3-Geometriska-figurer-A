using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{
    enum Shapetype
    {
        Ellipse,
        Rectangle,
    };
    //Den uppräkningsbara typen ShapeType används för att definiera vilka typer av figurer applikationen 
    //kan hantera. 
    //Typen används då metoden Main() anropar metoden CreateShape() för att informera vilken typ av figur som ska skapas.
    //Typen definieras lämpligen i filen Shape.cs, men då utanför klassdefinitionen så att den inte blir en 
    //del av typen Shape.


   abstract class Shape  
        //Den abstrakta klassen Shape innehåller såväl konkreta som abstrakta medlemmar gemensamma för 
        //figurer som ellips och rektangel. I Figur A.3 presenteras de abstrakta medlemmarna med kursiv text.
    {
        private double _lenght;  //Privat fält av typen double representerande en figurs längd.
        private double _width;  //Privat fält av typen double representerande en figurs bredd.



        public abstract double Area  //Publik abstrakt egenskap av typen double representerande en figurs area.
        { get; }


        public double Lenght
        { get; set;}  //Kapslar in _lenght. set-metoden ska validera värdet som tilldelas egenskapen. Är värdet inte större än 0 ska ett undantag 
                      //av typen ArgumentException kastas.

        public abstract double Perimeter //Publik abstrakt egenskap av typen double representerande en figurs omkrets.
        { get; }

        public double Width
        { get; set; }   //kapslar in _width. set-metoden ska validera värdet som tilldelas egenskapen. Är värdet inte större än 0 ska ett undantag 
                        //av typen ArgumentException kastas.

        protected Shape(double lenght, double width)
        {
            //Konstruktorn, som ska vara ”protected”, ansvara för att fälten, via egenskaperna, tilldelas de värden 
            //konstruktorns parametrar har.
        }

        override public string ToString()
        {
            //string message;
            //            message = (String.Format("Längd: {0}\n Bredd: {1}\n Omkrets:{2}\n Area: {3}\n", Length, Width, Perimeter, Area));
            //            return message;


            //Publik metod som överskuggar metoden ToString() i basklassen Object. Metoden ska returnera en 
            //sträng representerande värdet av en instans. Strängen ska vara lite speciellt formaterad och på separata 
            //rader innehålla ledtext och värde för figurens läng, bredd, omkrets och area.
            //Längd : Length
            //Bredd : Width
            //Omkrets: Perimeter
            //Area : Area
        }
    }
}
