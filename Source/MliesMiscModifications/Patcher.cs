using RimWorld;
using System.Linq;
using Verse;

namespace MliesMiscModifications
{
    [StaticConstructorOnStartup]
    class Patcher
    {
        static Patcher()
        {
            var list = DefDatabase<FactionDef>.AllDefs.ToList();
            foreach (FactionDef factionDef in list)
            {
                factionDef.canSiege = false;
            }
        }
    }
}
