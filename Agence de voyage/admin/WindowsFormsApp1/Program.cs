﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new user());
            // Application.Run(new Form2());
            // Application.Run(new Maps());
            Application.Run(new Form3());
            //  Application.Run(new Ticket());
           // Application.Run(new VoyageA());
            
        }
    }
}
