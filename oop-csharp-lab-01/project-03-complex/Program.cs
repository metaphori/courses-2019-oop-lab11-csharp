using System;

/*
 * == README ==
 * 
 * 1) Analizzare e completare la classe ComplexNum
 * 2) Ridefinire gli operatori "+", "-", "*", "/" per la classe ComplexNum
 * 3) Supponendo di non poter modificare ulteriormente la classe ComplexNum, generare il metodo estensione Invert() il quale,
 *    se invocato su un numero complesso, ne restituisca l'inverso (https://it.wikipedia.org/wiki/Inverso_di_un_numero_complesso).
 * 4) Modificare/estendere il Main per verifciare il corretto funzionamento di quanto svolto per i punti 2) e 3).
 */

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNum c1 = new ComplexNum(2, 3);
            
            Console.WriteLine("c1: " + c1.ToString());
            Console.WriteLine("c1 (module): " + c1.Module);
            Console.WriteLine("c1 (conjugate): " + c1.Conjugate);

            ComplexNum c2 = new ComplexNum(1, -5);

            Console.WriteLine("c2: " + c2.ToString());

            //ComplexNum cSum = c1 + c2;
            //ComplexNum cSub = c1 - c2;
            //ComplexNum cMul = c1 * c2;
            //ComplexNum cDiv = c1 / c2;

            //c1.Invert();
        }
    }
}
