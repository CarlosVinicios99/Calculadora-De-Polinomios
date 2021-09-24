using System;

namespace PolinomiosQuadrados{

    class Polinomio{

        private double A;
        private double B;
        private double C;

        private double CalculaDelta(){
            double _delta = Math.Pow(B, 2) - 4 * A * C;
            return _delta;
        }

        public void SetA(double A){
            this.A = A;
        }

        public void SetB(double B){
            this.B = B;
        }

        public void SetC(double C){
            this.C = C;
        }

        public bool DeltaIsZero(){
            bool _isZero = (CalculaDelta() == 0);
            return _isZero;
        }

        public bool DeltaIsNegativo(){
            bool _isNegativo = (CalculaDelta() < 0);
            return _isNegativo;
        }
        
        public double Raiz1(){
            return (-B + Math.Sqrt(CalculaDelta())) / (2 * A);
        }

        public double Raiz2(){
            return (-B - Math.Sqrt(CalculaDelta())) / (2 * A);
        }

    }

}