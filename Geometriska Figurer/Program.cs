using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{
    /// <summary>
    /// Klassen Program och den uppräkningsbara typen ShapeType ska användas för att skriva den 
    /// menystyrda delen av applikationen där användaren väljer vilken figur för vilken längd och bredd ska 
    /// matas in, area och omkrets beräknas samt figurens detaljer presenteras.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Den privata statiska metoden CreateShape ska läsa in en figurs längd och bredd, skapa objektet och 
        ///returnera en referens till det. 
        ///Metoden ska ha en parameter av typen ShapeType vars värde bestämmer om en ellips eller rektangel ska skapas.
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        private static Shape CreateShape(ShapeType shapeType)  //Ett nytt objekt skapas enligt användarens menyval.
        {
            string promtLength = "Ange objektets längd: ";
            double length = ReadDoubleGreaterThanZero(promtLength);         //Användaren uppmanas att ange måtten på sitt önskade objekt.

            string promtWidth = "Ange objektets bredd: ";
            double width = ReadDoubleGreaterThanZero(promtWidth);

            if (shapeType == ShapeType.Ellipse)  //Om användarens val är en Ellipse, ska ett Ellipse-objekt skapas med de mått användaren angivit.
            {
                Ellipse ellipse = new Ellipse(length, width);
                return ellipse;
            }
            else
            {
                Rectangle rectangle = new Rectangle(length, width); //Om inte, ska ett Rektangle-objekt skapas med de mått användaren angivit.
                return rectangle;
            }
        }

        static void Main(string[] args)
        {
            do
            {
                Viewmenu(); //Metoden Main ska anropa metoden ViewMenu() för att visa en meny.

                int index;  //En variabel för användarens menyval skapas.
                if (Int32.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 2)  //Om användarens val ligger inom det tillåtna intervallet
                {                                                                               //så används värdet av index till att välja ett alternativ i switch-satsen.
                    ShapeType choice = ShapeType.Undefined;  //Användarens val sätts från början till ett odefinierat val.
                    switch (index)
                    {
                        case 0:
                            return;  //Programmet avslutas.

                        case 1:
                            choice = ShapeType.Ellipse; //Skickar kommando till CreateShape att det ska skapas ett Ellipse-objekt
                            break;

                        case 2:
                            choice = ShapeType.Rectangle; //Skickar kommando till CreateShape att det ska skapas ett Rectangle-objekt
                            break;
                    }

                    if (choice != ShapeType.Undefined)  //När användaren angett all information...
                    {
                        ViewShapeDetail(CreateShape(choice));  //...anropas metoden ViewShapeDetail(Shape shape) med en   
                    }                                          //referens till det objekt vars detaljer ska presenteras.
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;     //Om användarens menyval inte ligger inom det tillåtna intervallet visas ett
                    Console.ForegroundColor = ConsoleColor.White;  //felmeddelande och användaren får en chans att återgå till menyn och prova igen
                    Console.WriteLine("Fel. Den angivna siffran var inte mellan 0 och 2. \nTryck på valfri tangent för att återgå till menyn.");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            } while (true);
        }

        /// <summary>
        ///Den privata statiska metoden ReadDoubleGreaterThanZero() ska returnera ett värde av typen 
        ///double som är större än 0.
        ///Till metoden ska det vara möjligt att skicka med ett argument.
        ///Argument ska vara en sträng med information som ska visas i anslutning till där inmatningen av värdet sker.
        ///Om det inmatade inte kan tolkas som ett korrekt värde ska användaren få en chans att göra en ny 
        ///inmatning efter att ett tydligt felmeddelande presenterats
        /// </summary>
        /// <param name="promt"></param>
        /// <returns></returns>
        static private double ReadDoubleGreaterThanZero(string promt)  //Läser in och kontrollerar användarens mått på objektet.
        {
            double measurements;
            while (true)
            {
                Console.WriteLine(promt);
                if (double.TryParse(Console.ReadLine(), out measurements) && measurements > 0)  //Om måttet är inom det angivna intervallet så returneras det
                {                                                                               //till metoden CreateShape().
                    return measurements;
                }
                Console.BackgroundColor = ConsoleColor.Red;                                     //Om inte visas ett felmeddelande och användaren får
                Console.ForegroundColor = ConsoleColor.White;                                   //en ny chans att mata in ett giltligt värde.
                Console.WriteLine("Fel. Var god ange ett värde större än 0.");
                Console.ResetColor();
            }
        }

        /// <summary>
        ///Den privata statiska metoden ViewMenu() ska bara presentera en meny. Någon inläsning ska inte 
        ///göras av metoden.
        ///Väljer användaren att inte avsluta applikationen ska med metoden 
        ///CreateShape() anropas som skapar och returnerar en referens till ett Ellips- eller Rectangle-objekt. 
        ///Referensen till objektet används sedan vid anrop av ViewDetail() som presenterar figurens detaljer. 
        ///Då en beräkning är gjord ska menyn visas på nytt.
        ///Meny alternativen är numrerade från 0 till 2 och väljer inte användaren ett värde i det slutna intervallet 
        ///mellan 0 och 2 ska ett felmeddelande visas och användaren uppmanas att trycka på en tangent för att 
        ///få en ny chans att ange ett korrekt menyalternativ.
        /// </summary>
        private static void Viewmenu()  //Mneyn visas efter att metoden anropats av Main() och användaren uppmanas att göra ett menyval.
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║                Meny                  ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("0 - Avsluta");
            Console.WriteLine("1 - Skapa en ellips");
            Console.WriteLine("2 - Skapa en rektangel");
            Console.WriteLine();
            Console.WriteLine("Vad vill du göra? \nVar god ange en siffra mellan 0 och 2.");
            Console.WriteLine("═════════════════════════════════════════");
        }

        /// <summary>
        ///Den privata statiska metoden ViewShapewDetail() ska presentera en figurs detaljer.
        ///Vid anrop av metoden skickas ett argument med som refererar till figurens vars detaljer ska presenteras.
        ///Parametern shape av typen Shape refererar till figuren.
        /// </summary>
        /// <param name="shape"></param>
        static void ViewShapeDetail(Shape shape)  //En metod som skriver ut det skapade objektets informationm som det hämtar 
        {                                         //ifrån metoden ToString() i klassen Shape.
            Console.WriteLine("═════════════════════════════════════════");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(shape.ToString());
            Console.ResetColor();
            Console.WriteLine("═════════════════════════════════════════");
            Console.WriteLine("Tryck på valfri tangent för att återgå till menyn.");
            Console.ReadKey(); 
        }
    }
}
