using System;
using System.Windows;
using NXOpen;
using NXOpen.Features;

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
            GetPartInfo(part);
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

        private static void GetPartInfo(Part part)
        {
            FeatureCollection features = part.Features;
            Feature[] allFeatures = features.GetFeatures();
            Feature extrude = allFeatures[5];
            Feature[] allChildren = extrude.GetAllChildren();
            Feature[] allParents = extrude.GetParents();
        }

    }
}
