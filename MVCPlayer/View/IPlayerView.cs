using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPlayer
{
    //TODO upgrade logic!!!!
    public interface IPlayerView
    {
        string playerName { get; set; }
        int ID { get; set; }
        float XP { get; set; }
        float HP { get; set; }
        int Level { get; set; }
        int LevelMax { get; set; }
        float MaxXp { get; set; }
        bool isGameOver { get; set; }
        
        //Observing part of code
        void Update(IModel observedModel);

    }
}

