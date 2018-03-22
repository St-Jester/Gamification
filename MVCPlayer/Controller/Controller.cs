using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPlayer.Controller
{
    public class Controller : IController
    {
        private IModel model;
        private IPlayerView view;

        public Controller()
            {
            }

        public Controller(IModel paramModel, IPlayerView paramView)
        {
            this.model = paramModel;
            this.view = paramView;
        }

        public void AddHP(float _amount)
        {
            if(model != null)
            {
                model.AddHP(_amount);
                
                SetView();
                
            }
        }
        public void SubtractHP(float _amount)
        {
            model.SubtractHP(_amount);
            SetView();

        }

        public void AddXp(float _amount)
        {
            model.AddXp(_amount);
            SetView();

        }

        public void SetModel(IModel _model)
        {
            model = _model;
        }

        public void SetView(IPlayerView _view)
        {
            view = _view;
        }


        private void SetView()
        {
            if (view != null)
            {
                view.HP = model.HP;
                view.XP = model.XP;
                view.Level = model.Level;
                //isgameover
            }
            else
                throw new Exception("No view!");
        }

    }
}

