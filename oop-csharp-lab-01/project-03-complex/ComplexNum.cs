using System;

namespace ComplexNumbers
{
    class ComplexNum
    {
        public ComplexNum(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public double Re { get; private set; }
        public double Im { get; private set; }


        // Restituisce il modulo del numero complesso
        public double Module
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        // Restituisce il complesso coniugato del numero complesso (https://en.wikipedia.org/wiki/Complex_conjugate)
        public ComplexNum Conjugate
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        // Restituisce una rappresentazione idonea per il numero complesso
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
