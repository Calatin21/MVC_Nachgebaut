using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVC_Nachgebaut.View {
    internal class Browser {
        public string Menu() {
            string ergebnis = "";
            Console.WriteLine("1) Information hinzufügen\n2) Information abrufen\n 3) Exit");
            string antwort = Console.ReadLine();
            switch (antwort) {
                case "1":
                ergebnis = "1";
                break;
                case "2":
                ergebnis = "2";
                break;
                case "3":
                ergebnis = "3";
                break;
                default:
                break;
            }
            return ergebnis;
        }
        public void Ausgabe(string[] s) {
            Console.WriteLine("Ausgabe der Datei:");
            foreach (string item in s) {
                Console.WriteLine(item);
            }
        }
    }
}
