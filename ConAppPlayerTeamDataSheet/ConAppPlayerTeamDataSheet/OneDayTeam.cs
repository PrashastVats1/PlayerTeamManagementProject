using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppPlayerTeamDataSheet
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam()
        {
            oneDayTeam = new List<Player>();
        }
        public void Add(Player player)
        {
            if (oneDayTeam.Count < 11)
            {
                oneDayTeam.Add(player);
                Console.WriteLine("Player is successfully added");
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players");
            }
        }
        public void Remove(int playerId)
        {
            Player playerToRemove = oneDayTeam.FirstOrDefault(p=>p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine("Player is successfully removed");
            }
            else
            {
                Console.WriteLine("Player not found");
            }
        }
        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.FirstOrDefault(p=> p.PlayerId == playerId);
        }
        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.FirstOrDefault(p => p.PlayerName == playerName);
        }
        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
