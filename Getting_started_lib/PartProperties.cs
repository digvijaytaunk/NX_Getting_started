using NXOpen;
using NXOpen.UF;


namespace Getting_started_lib
{
    static class PartProperties
    {
        public static double GetPartWeigth(Part part)
        {
            UFSession ufs = UFSession.GetUFSession();

            UFWeight.Properties weight;
            UFWeight.UnitsType units = UFWeight.UnitsType.UnitsKm;
            Tag cur_part_tag = part.Tag;
            ufs.Weight.AskProps(cur_part_tag, units, out weight);
            return weight.mass;
        }
    }
}
