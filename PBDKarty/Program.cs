using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBDKarty
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* using (var zx = new Kartyv0Entities())
             {
                 var newInstructor = new Gracz
                 {
                     ID_Gracza = 4,
                     Data_Dolaczenia = DateTime.Now,
                     Data_Urodzin = DateTime.Now,
                     E_mail = "Instructor"
                 };
                 zx.Gracz.Add(newInstructor);
                 Console.WriteLine("Added {0} {1} to the context.",
             newInstructor.ID_Gracza, newInstructor.E_mail);
                 zx.SaveChanges();
             }*/
            using (var db = new Kartyv1Entities())
             {

                 var query = from b in db.Gracz
                             orderby b.ID_Gracza
                             select b;

                 Console.WriteLine("All All student in the database:");

                 foreach (var item in query)
                 {
                     Console.WriteLine(item.ID_Gracza + " " + item.Data_Urodzin);
                 }
                 
            Console.WriteLine("Press any key to exit...");
                Console.Read();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new BazaDanych());
            }
        }
    }
}
