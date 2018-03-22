using MVCPlayer.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPlayer
{
    public class View : IPlayerView
    {
        private IModel model = new Player();
        private IController control = new Controller.Controller();

        public float    HP{get;set;}
        public int      ID { get; set; }
        public int      Level { get; set; }
        public int      LevelMax { get; set; }
        public float    MaxXp { get; set; }
        public string   playerName { get; set; }
        public float    XP { get; set; }
        public bool     isGameOver { get; set; }


        //public void GameOver()
        //{
        //    isGameOver = true;
        //}

        public View()
        {
            WireUp(control, model);
        }

        public void WireUp(IController paramControl, IModel paramModel)
        {
            // If we're switching Models, don't keep watching
            // the old one! 
            if (model != null)
            {
                model.RemoveObserver(this);
            }
            model = paramModel;
            control = paramControl;
            control.SetModel(model);
            control.SetView(this);
            model.AddObserver(this);
        }

        public void Update(IModel observedModel)
        {
            Console.WriteLine("\n~~~~~~~~");
            if (isGameOver)
                Console.WriteLine("Game over");
            Console.WriteLine(observedModel.playerName);
            Console.WriteLine("=========");
            Console.WriteLine("HP:" + observedModel.HP);
            Console.WriteLine("XP:" + observedModel.XP);
            Console.WriteLine("Level:" + observedModel.Level + " of " + observedModel.LevelMax);

        }
    }
}
