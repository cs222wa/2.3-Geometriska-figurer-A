using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{
    public enum ShapeType
    {
        Undefined,
        Ellipse,
        Rectangle,
    }
    //Den uppräkningsbara typen ShapeType används för att definiera vilka typer av figurer applikationen 
    //kan hantera. 
    //Typen används då metoden Main() anropar metoden CreateShape() för att informera vilken typ av figur som ska skapas.
    //Typen definieras lämpligen i filen Shape.cs, men då utanför klassdefinitionen så att den inte blir en 
    //del av typen Shape.


    abstract class Shape
    //Den abstrakta klassen Shape innehåller såväl konkreta som abstrakta medlemmar gemensamma för 
    //figurer som ellips och rektangel. I Figur A.3 presenteras de abstrakta medlemmarna med kursiv text.
    {
        private static double _length;  //Privat fält av typen double representerande en figurs längd.
        private static double _width;  //Privat fält av typen double representerande en figurs bredd.



        public abstract double Area  //Publik abstrakt egenskap av typen double representerande en figurs area.
        { get; }


        public static double Length
        {
            get { return _length; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Värdet för objektets längd är för litet.\nVar vänlig ange ett värde större än 0.");
                }
                _length = value;
            }

        }  //Kapslar in _lenght. set-metoden ska validera värdet som tilldelas egenskapen. Är värdet inte större än 0 ska ett undantag 
        //av typen ArgumentException kastas.




        public abstract double Perimeter //Publik abstrakt egenskap av typen double representerande en figurs omkrets.
        { get; }
        

        public static double Width
        {
            get { return _width; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Värdet för objektets bredd är för litet.\nVar vänlig ange ett värde större än 0.");
                }
                _width = value;
            }

        }  //kapslar in _width. set-metoden ska validera värdet som tilldelas egenskapen. Är värdet inte större än 0 ska ett undantag 
        //av typen ArgumentException kastas.

        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
            
            //Konstruktorn, som ska vara ”protected”, ansvara för att fälten, via egenskaperna, tilldelas de värden 
            //konstruktorns parametrar har.
        }

        override public string ToString()
        {
            string message;
            message = (String.Format("\nLängd: {0} \nBredd: {1} \nOmkrets:{2: 0.00} \nArea: {3: 0.00} \n\nAnge ett nytt menyval för att skapa ett nytt objekt.", Length, Width, Perimeter, Area));
            return message;

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
