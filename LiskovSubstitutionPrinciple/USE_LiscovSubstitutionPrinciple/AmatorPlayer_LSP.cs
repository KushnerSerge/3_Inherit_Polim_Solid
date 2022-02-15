using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.USE_LiscovSubstitutionPrinciple
{
    internal class AmatorPlayer_LSP : IGame, IPlayer
    {
        public string GetGameDetails(int playerId)
        {
            return "Not used any of strategies available for gameplay";
        }

        public string GetPlayerDetails(int playerId)
        {
            return "Details of player is available";
        }
    }
}
