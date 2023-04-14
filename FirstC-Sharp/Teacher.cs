using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Sharp
{
    //non static or instance class/method
    public class Teacher
    {
        //fields
        float _Pi = 3.141f;
        int _Radius;

        //construtor
        public Teacher(int Radius)
        {
            this._Radius = Radius;
        }

        //method
        public float calculator()
        {
            return _Pi * _Radius * _Radius;
        }
      
    }
}
