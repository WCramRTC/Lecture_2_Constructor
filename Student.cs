using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Constructor
{
    internal class Student
    {
        string _name;
        int _csiGrade;
        int _genEdGrade;

        public Student(string name, int csiGrade, int genEdGrade)
        {
            _name = name;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }

        public string Name { get => _name; set => _name = value; }
        public int CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public int GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }


        public double Average()
        {
            return (_csiGrade + _genEdGrade) / 2;
        }


    } // class

    // Average Sum all / Num of Elements
    // (CSI + GenEd ) / 2


}
