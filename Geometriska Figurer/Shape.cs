using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{
    /// <summary>
    ///Den uppräkningsbara typen ShapeType används för att definiera vilka typer av figurer applikationen 
    ///kan hantera. 
    ///Typen används då metoden Main() anropar metoden CreateShape() för att informera vilken typ av figur som ska skapas.
    ///Typen definieras lämpligen i filen Shape.cs, men då utanför klassdefinitionen så att den inte blir en 
    ///del av typen Shape.
    /// </summary>
    public enum ShapeType  //Typer som användaren har tillåtelse att välja mellan i switch-satsen/är förinställda.
    {
        Undefined,
        Ellipse,
        Rectangle,
    }
    
    /// <summary>
    ///Den abstrakta klassen Shape innehåller såväl konkreta som abstrakta medlemmar gemensamma för 
    ///figurer som ellips och rektangel. I Figur A.3 presenteras de abstrakta medlemmarna med kursiv text.
    /// </summary>
    public abstract class Shape
    {
        private static double _length;  //Privat fält av typen double representerande en figurs längd.
        private static double _width;  //Privat fält av typen double representerande en figurs bredd.

        public abstract double Area  //Publik abstrakt egenskap av typen double representerande en figurs area.
        { get; }

        /// <summary>
        /// Kapslar in _lenght. set-metoden ska validera värdet som tilldelas egenskapen. Är värdet inte större än 0 ska ett undantag 
        /// av typen ArgumentException kastas.
        /// </summary>
        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)   //Om värdet för för objektets längd är mindre än 0 ska ett undantag kastas.
                {
                    throw new ArgumentException("Värdet för objektets längd är för litet.\nVar vänlig ange ett värde större än 0.");
                }
                _length = value;
            }
        } 

        public abstract double Perimeter //Publik abstrakt egenskap av typen double representerande en figurs omkrets.
        { get; }

        /// <summary>
        /// 
        ///kapslar in _width. set-metoden ska validera värdet som tilldelas egenskapen. Är värdet inte större än 0 ska ett undantag 
        ///av typen ArgumentException kastas.
        /// </summary>
        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)         //Om värdet för för objektets bredd är mindre än 0 ska ett undantag kastas.
                {
                    throw new ArgumentException("Värdet för objektets bredd är för litet.\nVar vänlig ange ett värde större än 0.");
                }
                _width = value;
            }
        }  

        /// <summary>
        ///Konstruktorn, som ska vara ”protected”, ansvara för att fälten, via egenskaperna, tilldelas de värden 
        ///konstruktorns parametrar har.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;  
        }

        /// <summary>
        ///Publik metod som överskuggar metoden ToString() i basklassen Object. Metoden ska returnera en 
        ///sträng representerande värdet av en instans. Strängen ska vara lite speciellt formaterad och på separata 
        ///rader innehålla ledtext och värde för figurens läng, bredd, omkrets och area.
        /// </summary>
        /// <returns></returns>
        override public string ToString()   //Metod som samlar objektets information och förbereder det för att skrivas ut som en sträng.
        {
            string message;
            message = (String.Format("\nLängd: {0, 10:0.00} \nBredd: {1, 10:0.00} \nOmkrets: {2, 8:0.00} \nArea: {3, 11:0.00} \n", Length, Width, Perimeter, Area));
            return message;
        }
    }
}
