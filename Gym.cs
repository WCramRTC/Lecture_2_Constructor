using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Constructor
{
    internal class Gym
    {
        // Fields
        List<string> _equipment;
        List<string> _facilities;
        string _name;
        string _location;
        double _fee;
        int _opening;
        int _closing;
        bool _isOpen;

        // Constructors
        // Default Constructors
        // Is a constructor that takes no arguments

        // Overloaded Constructor
        public Gym(double fee)
        {
            _fee = fee;
        }

        public Gym(double fee, int opening, int closing)
        {
            _fee = fee;
            _opening = opening;
            _closing = closing;
        }

        // Brought back the default constructor
        public Gym()
        {
            _name = "Unassigned";
            _fee = -1;
            _opening = _closing = 0;
        }

        // Default Values

        // Properties

        // Methods

        public void CheckIfOpen(int currentTime)
        {
            if(currentTime >= _opening && currentTime <= _closing)
            {
                _isOpen = true;
            }
            else
            {
                _isOpen = false;
            }
        }

        // How to override your class to String
        public override string ToString()
        {
            return $"{_name} : Location {_location} : Hours {_opening} - {_closing} : Fee {_fee}";
        }

    }
}
