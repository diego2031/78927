using System;
using icalculadora;

namespace calculadora {
    public class Calculadora : iCalculadora  {
        public int F(int a){
            return a = (a*1.8)+32;
        }
        public int C(int b){
            return  b =(b−32)*0.5556;
        }
    }
}