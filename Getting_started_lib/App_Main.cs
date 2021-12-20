using System;
using System.Windows;
using NXOpen;

namespace Getting_started_lib
{
    public static class App_Main
    {
   
        public static void Main()
        {
            Session theSession = Session.GetSession();
            Part part = theSession.Parts.Work;
            MessageBox.Show("Full Path " + part.FullPath, "Demo");
            double mass = PartProperties.GetPartWeigth(part);
            MessageBox.Show("Mass is = " + mass.ToString(), "Mass Properties"); 
        }

        /// <summary>
        /// Must have function to unload dll after execution.
        /// </summary>
        /// <param name="dummy"></param>
        /// <returns></returns>
        public static int GetUnloadOption(String dummy)
        {
            return (int)Session.LibraryUnloadOption.Immediately;
        }

    }
}
