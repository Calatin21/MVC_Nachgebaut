namespace MVC_Nachgebaut.Model {
    internal static class Persistenz {
        public static void Speichern(string s) {
            s += "\n";
            StreamWriter sw = File.AppendText(@"Sav.dat");
            sw.Write(s);
            sw.Close();
        }
        public static string[] Laden() {       
            string[] ergebnis = File.ReadAllLines(@"Sav.dat");            
            return ergebnis;
        }
    }
}