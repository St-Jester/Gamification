using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPlayer
{
    public interface IModel
    {
        string  playerName { get; set; }
        float   XP { get; set; }
        float   HP { get; set; }
        string  Name { get; set; }
        int     Level { get; set; }

        bool    isGameOver { get; set; }

        int     LevelMax { get; set; }
        float   MaxXpPerLevel { get; set; }
        float   MaxHP { get; set; }


        void SetStartingStats
            (string _Name,
            int _LevelMax,
            float _XpPerLvl,
            float _MaxHp);

        void AddXp(float _amount);
        void SubtractHP(float _amount);
        void AddHP(float _amount);

        //internal for model
        void AddLevel();
        void GameOver();

        //Observer pattern
        //Model is observed with View
        void AddObserver(IPlayerView observingView);
        void RemoveObserver(IPlayerView observingView);
        void NotifyObservers();
    }
}
