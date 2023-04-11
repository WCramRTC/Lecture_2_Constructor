using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Constructor
{
    internal class Bullet
    {
        string _name;
        float _x;
        float _y;
        float _velocity;
        float rotation;
        string _visual;
        float _radius;
        float _damage;

        public float Damage { get => _damage; set => _damage = value; }

        public Bullet(string name, float x, float y , float velocity, float dmg)
        {
            _name = name;
            _x = x;
            _y = y;
            _velocity = velocity;
            _damage = dmg;
        }

        public void UpdateLocation()
        {
            _x += _velocity;
            _y += _velocity;
        }

        public override string ToString()
        {
            return $"Bullet {_name} : X:{_x} - Y:{_y} : V : {_velocity}";
        }

    }
}
