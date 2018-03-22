using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPlayer
{
    public class Player: IModel
    {
        //for observer
        private List<IPlayerView> observerList = new List<IPlayerView>();

        public string playerName { get; set; }
        public float XP { get; set; }
        public float HP { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public bool isGameOver { get; set; }

        public int LevelMax { get; set; }
        public float MaxXpPerLevel { get; set; }
        public float MaxHP { get; set; }

        public void SetStartingStats(
            string _Name, 
            int _LevelMax, 
            float _XpPerLvl, 
            float _MaxHp)
        {
            playerName = _Name;
            LevelMax = _LevelMax;
            MaxXpPerLevel = _XpPerLvl;
            MaxHP = _MaxHp;
            HP = MaxHP;
        }

        public void AddXp(float _amount)
        {
            XP += _amount;
            if(XP>MaxXpPerLevel)
            {
                AddLevel();
            }
        }
        public void AddLevel()
        {
            int levelsToAdd = (int)(XP / MaxXpPerLevel);
            Level += levelsToAdd;
            XP %= MaxXpPerLevel;
        }


        public void AddHP(float _amount)
        {
            HP += _amount;
            if(HP>=MaxHP)
            {
                HP = MaxHP;
            }
        }


        public void SubtractHP(float _amount)
        {
            HP -= _amount;
            if(HP<=0)
            {
                HP = 0;
                GameOver();
            }
        }
        public void GameOver()
        {
            isGameOver = true;
        }

        public void AddObserver(IPlayerView observingView)
        {
            observerList.Add(observingView);
        }

        public void RemoveObserver(IPlayerView observingView)
        {
            observerList.Remove(observingView);
        }

        public void NotifyObservers()
        {
            foreach (var obs in observerList)
            {
                obs.Update(this);
            }
        }
    }
}

