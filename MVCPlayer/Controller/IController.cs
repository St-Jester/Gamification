using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPlayer.Controller
{
    public interface IController
    {
        void AddXp(float _amount);
        void SubtractHP(float _amount);
        void AddHP(float _amount);

        void SetModel(IModel _model);
        void SetView(IPlayerView _view);
    }
}
