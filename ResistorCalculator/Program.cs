using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResistorCalculator
{
    /// <summary>
    /// Niech użytkownik wprowadza dany pasek, wybierając z komponentu ComboBox odpowiedni kolor.
    ///w obiekcie typu Label ma zwracać informację o wielkości obliczonej rezystancji w kΩ(kiloomach).
    ///zobrazować widok tych pasków na rezystorze.Polecam użycie komponentów Panel (polecam property BackColor).
    /// </summary>


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
