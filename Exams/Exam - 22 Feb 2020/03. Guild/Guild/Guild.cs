using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Player> Roster { get; set; }
        public int Count
        {
            get
            {
                return Roster.Count;
            }
        }

        public void AddPlayer(Player player)
        {
            if (Capacity > Roster.Count)
            {
                Roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            foreach (var player in Roster)
            {
                if (player.Name == name)
                {
                    Roster.Remove(player);
                    return true;
                }
            }
            return false;
        }

        public void PromotePlayer(string name)
        {
            foreach (var player in Roster)
            {
                if (player.Name == name)
                {
                    player.Rank = "Member";
                }
            }
        }

        public void DemotePlayer(string name)
        {
            foreach (var player in Roster)
            {
                if (player.Name == name)
                {
                    player.Rank = "Trial";
                }
            }
        }

        public Player[] KickPlayersByClass(string clas)
        {
            List<Player> kickedPlayers = new List<Player>();
            foreach (var player in Roster)
            {
                if (player.Class == clas)
                {
                    kickedPlayers.Add(player);
                }
            }
            foreach (var player in kickedPlayers)
            {
                Roster.Remove(player);
            }
            return kickedPlayers.ToArray();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (var player in Roster)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString();
        }
    }
}
