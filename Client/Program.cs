using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPlayer;
using MVCPlayer.Controller;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            View v = new View();
            Player player = new Player();
            player.SetStartingStats("Jedi", 12, 10, 100);
            v.Update(player);

            Controller c = new Controller(player, v);

            c.SubtractHP(15);
            c.AddXp(26);

            v.Update(player);
        }
    }
}
