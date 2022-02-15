
using LiskovSubstitutionPrinciple.USE_LiscovSubstitutionPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.NOT_USE_LiscovSubstitutionPrinciple
{
    public class ProfesionalPlayer_LSP : IGame

    {
        public string GetGameDetails(int playerId)
        {
            return "There are used all available strategies";
        }
    }
}
