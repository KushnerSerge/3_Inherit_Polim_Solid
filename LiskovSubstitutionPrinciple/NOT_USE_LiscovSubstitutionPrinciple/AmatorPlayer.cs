using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.NOT_USE_LiscovSubstitutionPrinciple
{
    public class AmatorPlayer : Player
    {
        public override string GetGameDetails(int playerId)
        {
            return "Not used any of strategies available for gameplay";
        }

        public override string GetPlayerDetails(int playerId)
        {
            return "Details of player is available";
        }
    }
}
