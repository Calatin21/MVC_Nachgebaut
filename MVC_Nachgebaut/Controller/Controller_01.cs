using MVC_Nachgebaut.Model;
using MVC_Nachgebaut.View;

namespace MVC_Nachgebaut.Controller {
    internal class Controller_01 {
        public bool MenuEingabe(string s, Browser br) {
            bool ergebnis = true;
            switch (s) {
                case "1":
                Console.Write("Bitte String eingeben: ");
                //string eingabe = Console.ReadLine();
                //Persistenz.Speichern(Persistenz.SpeichernVorbereiten(eingabe));
                Persistenz.Speichern(Persistenz.SpeichernVorbereiten(Console.ReadLine()));
                return ergebnis;
                break;
                case "2":
                //string[] datei = Persistenz.Laden();
                //br.Ausgabe(datei);
                br.Ausgabe(Persistenz.Laden());
                return ergebnis;
                break;
                case "3":
                ergebnis = false;
                return ergebnis;
                break;
                default:
                return ergebnis;
                break;
            }
        }
    }
}
