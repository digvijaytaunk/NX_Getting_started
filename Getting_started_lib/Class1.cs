using System;
using System.Windows;
using Getting_started_lib;
using NXOpen;


public class Class1
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
    public int GetUnloadOption(String dummy)
    {
        return (int)Session.LibraryUnloadOption.Immediately;
    }

}

