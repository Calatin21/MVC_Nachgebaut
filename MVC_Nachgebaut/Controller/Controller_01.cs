using MVC_Nachgebaut.Model;
using MVC_Nachgebaut.View;

namespace MVC_Nachgebaut.Controller {
    internal class Controller_01 {
        public bool MenuEingabe(string s, Browser br ) {
            bool ergebnis = true;
            switch (s) {
                case "1":
                Console.Write("Bitte String eingeben: ");
                string eingabe = Console.ReadLine();
                eingabe = "***" + eingabe + "!!!";
                Persistenz.Speichern(eingabe);
                return ergebnis;
                break;
                case "2":
                string[] datei = Persistenz.Laden();
                br.Ausgabe(datei);
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
