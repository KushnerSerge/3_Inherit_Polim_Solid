// See https://aka.ms/new-console-template for more information


// Not use Liscov Substitution Principle
using LiskovSubstitutionPrinciple.NOT_USE_LiscovSubstitutionPrinciple;

List<Player> playerList = new List<Player>();
playerList.Add(new AmatorPlayer());
playerList.Add(new ProfesionalPlayer());

foreach (Player player in playerList)
{
    player.GetPlayerDetails(123);
}
