using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{
    class Program
    //Klassen Program och den uppräkningsbara typen ShapeType ska användas för att skriva den 
    //menystyrda delen av applikationen där användaren väljer vilken figur för vilken längd och bredd ska 
    //matas in, area och omkrets beräknas samt figurens detaljer presenteras.
    {
        private static Shape CreateShape(ShapeType shapeType)
        {
            if (shapeType == ShapeType.Ellipse)
            {
                Ellipse ellipse = new Ellipse();
                return ellipse;
            }
            else
            {

                Rectangle rectangle = new Rectangle();
                return rectangle;
            }
            string promtLength = "Ange objektets längd: ";
            Shape.Length = ReadDoubleGreaterThanZero(promtLength);

            string promtWidth = "Ange objektets bredd: ";
            Shape.Width = ReadDoubleGreaterThanZero(promtWidth);


        }
        //Den privata statiska metoden CreateShape ska läsa in en figurs längd och bredd, skapa objektet och 
        //returnera en referens till det. 
        //Metoden ska ha en parameter av typen ShapeType vars värde bestämmer om en ellips eller rektangel ska skapas.

        static void Main(string[] args)
        {
            Viewmenu(); //Metoden Main ska anropa metoden ViewMenu() för att visa en meny. 





        }

        static private double ReadDoubleGreaterThanZero(string promt)
        {
            Console.WriteLine(promt);
            double measurements = double.Parse(Console.ReadLine());

            if (double.TryParse(Console.ReadLine(), out measurements) && measurements > 0)
            {
                return measurements;
            }
            
            Console.WriteLine("Fel. Var god ange ett värde större än 0.");
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.Clear();
            Console.CursorVisible = true;

            //Den privata statiska metoden ReadDoubleGreaterThanZero() ska returnera ett värde av typen 
            //double som är större än 0. 

            //Till metoden ska det vara möjligt att skicka med ett argument. 

            //Argument ska vara en sträng med information som ska visas i anslutning till där inmatningen av värdet sker.

            //I Figur A.9 har argumenten "Ange längden: " skickats med som argument vid anropet av metoden.

            //Om det inmatade inte kan tolkas som ett korrekt värde ska användaren få en chans att göra en ny 
            //inmatning efter att ett tydligt felmeddelande presenterats
        }

        private static void Viewmenu()
        {
            //Den privata statiska metoden ViewMenu() ska bara presentera en meny. Någon inläsning ska inte 
            //göras av metoden.

            //Väljer användaren att inte avsluta applikationen ska med metoden 
            //CreateShape() anropas som skapar och returnerar en referens till ett Ellips- eller Rectangle-objekt. 
            //Referensen till objektet används sedan vid anrop av ViewDetail() som presenterar figurens detaljer. 

            //Då en beräkning är gjord ska menyn visas på nytt.

            //Meny alternativen är numrerade från 0 till 2 och väljer inte användaren ett värde i det slutna intervallet 
            //mellan 0 och 2 ska ett felmeddelande visas och användaren uppmanas att trycka på en tangent för att 
            //få en ny chans att ange ett korrekt menyalternativ.



            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ╔══════════════════════════════════════╗ ");
                Console.WriteLine(" ║                Menu                  ║ ");
                Console.WriteLine(" ╚══════════════════════════════════════╝ ");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Ellipse");
                Console.WriteLine("2 - Rectangle");

                int index = ReadMenuChoice();

                switch (index)
                {
                    case 0:
                        return;

                    case 1:
                        CreateShape(ShapeType.Ellipse);
                        //Skicka till CreateShape att det ska skapas en Ellipse
                        break;

                    case 2:
                        CreateShape(ShapeType.Rectangle);
                        //Skicka till CreateShape att det ska skapas en Rectangle
                        break; 
                }

            } while (true);

            //anropa ViewDetail och skicka med referensen till objektet i CreateShape som argument.
        }

        private static int ReadMenuChoice()
        {
            int index;
            while (true)
            {

                if (Int32.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 2)
                {
                    return index;
                }
                Console.WriteLine("Fel. Var god ange ett värde mellan 0 och 2.");
                Console.CursorVisible = false;
                Console.ReadKey(true);
                Console.Clear();
                Console.CursorVisible = true;
            }
        }



        void ViewShapeDetail(Shape shape)
        {
            //Den privata statiska metoden ViewShapewDetail() ska presentera en figurs detaljer. 

            //Vid anrop av metoden skickas ett argument med som refererar till figurens vars detaljer ska presenteras. 

            //Parametern shape av typen Shape refererar till figuren. 

            ToString();

            // Genom att utnyttja att basklassen Shape överskuggar metoden ToString() förenklas koden väsentligt 
            //då en figurs längd, bredd, omkrets och area ska presenteras.
        }
    }
}




//A-krav
//1. Applikationen ska kunna beräkna och presentera omkrets och area för en ellips samt 
//rektangel.

//2. Klasserna Shape, Ellips och Rectangle ska implementeras enligt klassdiagrammen i 
//Figur A.2 till Figur A.5.

//3. Klasserna Ellipse och Rectangle ska implementera de abstrakta ”read-only”-
//egenskaperna Area och Perimeter i basklassen Shape. Area och omkrets ska för repsktive 
//typ av figur beräknas enligt uttrycken under rubriken ”Formelsamling för area och omkrets” 
//på sidan 5.

//4. Egenskaper som har en set-metod ska validera datat innan det tilldelas fältet egenskapen 
//kapslar in.

//5. Klassen Program och den uppräkningsbara typen ShapeType ska implementeras enligt 
//klassdiagrammet i Figur A.6.

//6. Metoden Main() i klassen Program ska se till att en meny visas där användaren kan välja 
//för vilken typ av figur beräkningar av omkrets och area ska göras. Användaren ska via ett 
//menyalternativ kunna välja att avsluta applikationen.

//7. Metoden ViewShapeDetail() i klassen Program ska använda metoden ToString() i 
//klassen Shape för att presentera en figurs läng, bredd, omkrets och area.

//8. Fel som inträffar i applikationen ska tas om hand och relevanta felmeddelanden ska visas


//TIPS FRÅN SKYPE =)
//2.3
// Konstruktorn
//Publik konstruktor som genom anrop av basklassens konstruktor ser till att det nya objektets längd och 
//bredd sätts.

//körde med Ellipse(bla, bla)
//                    :base (bla, bla)
//Doxbox har gjort rätt

