
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ReadMemInfo
{


    static class Program
    {


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bShowWindow = true;

            if(bShowWindow)
            { 
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            } // End if(bShowWindow)


            if (!bShowWindow)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(" --- Press any key to continue --- ");
                Console.ReadKey();
            }
        } // End Sub Main 


    } // End Class Program


} // End Namespace ReadMemInfo
