using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.NOT_USE_LiscovSubstitutionPrinciple
{
    public abstract class Player
    {
        public virtual string GetPlayerDetails(int playerId)
        {
            return "Universal Player";
        }
        public virtual string GetGameDetails(int playerId)
        {
            return "Universal Game";
        }
    }
}
