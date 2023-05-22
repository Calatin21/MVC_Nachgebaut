using MVC_Nachgebaut.Controller;
using MVC_Nachgebaut.View;

namespace MVC_Nachgebaut {
    internal class Program {
        static void Main(string[] args) {
            Browser browser = new Browser();
            Controller_01 controller = new Controller_01();
            bool ergebnis = true;
            while (ergebnis) {
                ergebnis = controller.MenuEingabe(browser.Menu(), browser);
            }
        }
    }
}