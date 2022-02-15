using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.NOT_USE_LiscovSubstitutionPrinciple
{
    public class ProfesionalPlayer : Player
    {
        public override string GetGameDetails(int playerId)
        {
            return "There are used all available strategies";
        }

        public override string GetPlayerDetails(int playerId)
        {
            throw new NotImplementedException();
        }
    }
}
