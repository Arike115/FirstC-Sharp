using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Sharp
{
    //static class/method
    public class Sales
    {
         float _Pi = 3.141f;
         int _Radius;

        //construtor
        // static Teacher (int Radius)
        //{
        //    _Radius = Radius;
        //}

        //method
        public  float calculator(int Radius)
        {
            _Radius = Radius;
            return _Pi * _Radius * _Radius;
        }
    }
}
