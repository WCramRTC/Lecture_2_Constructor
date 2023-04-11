using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Constructor
{
    internal class Player
    {
        float _hp;

        public Player(float hp)
        {
            _hp = hp;
        }

        public void OnImpact(Bullet attack)
        {
            _hp -= attack.Damage;
        }

        public float Hp { get => _hp; set => _hp = value; }
    }
}
