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
            //Den privata statiska metoden CreateShape ska läsa in en figurs längd och bredd, skapa objektet och 
            //returnera en referens till det. Metoden ska ha en parameter av typen ShapeType vars värde bestämmer 
            //om en ellips eller rektangel ska skapas.
        }

        static void Main(string[] args)
        {
            //Metoden Main ska anropa metoden ViewMenu() för att visa en meny. Väljer användaren att inte 
            //avsluta applikationen ska med metoden CreateShape() anropas som skapar och returnerar en referens 
            //till ett Ellips- eller Rectangle-objekt. Referensen till objektet används sedan vid anrop av 
            //ViewDetail() som presenterar figurens detaljer. Då en beräkning är gjord ska menyn visas på nytt.
            //Meny alternativen är numrerade från 0 till 2 och väljer inte användaren ett värde i det slutna intervallet 
            //mellan 0 och 2 ska ett felmeddelande visas och användaren uppmanas att trycka på en tangent för att 
            //få en ny chans att ange ett korrekt menyalternativ.
        }

        double ReadDoubleGreaterThanZero(string promt)
        {
            //Den privata statiska metoden ReadDoubleGreaterThanZero() ska returnera ett värde av typen 
            //double som är större än 0. Till metoden ska det vara möjligt att skicka med ett argument. Argument 
            //ska vara en sträng med information som ska visas i anslutning till där inmatningen av värdet sker. I 
            //Figur A.9 har argumenten "Ange längden: " skickats med som argument vid anropet av metoden.
            //Om det inmatade inte kan tolkas som ett korrekt värde ska användaren få en chans att göra en ny 
            //inmatning efter att ett tydligt felmeddelande presenterats
        }
        
        private static void Viewmenu()
        {
            //Den privata statiska metoden ViewMenu() ska bara presentera en meny. Någon inläsning ska inte 
            //göras av metoden.
        }

        void ViewShapeDetail(Shape shape)
        {
            //Den privata statiska metoden ViewShapewDetail() ska presentera en figurs detaljer. Vid anrop av 
            //metoden skickas ett argument med som refererar till figurens vars detaljer ska presenteras. Parametern 
            //shape av typen Shape refererar till figuren. Genom att utnyttja att basklassen Shape överskuggar 
            //metoden ToString() förenklas koden väsentligt då en figurs längd, bredd, omkrets och area ska 
            //presenteras.
        }
    }
}
