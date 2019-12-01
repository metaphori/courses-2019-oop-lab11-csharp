using System;

/*
 * == README ==
 * 
 * 1) Analizzare la classe Card e trasformare i metodi presenti in proprietà.
 * 2) Comprendere il meccanismo di "string interpolation" presente nel metodo ToString() della classe Card.
 * 3) La classe Deck rappresenta il mazzo di carte. Completare i metodi Initialize() e Print().
 * 4) Definire un indicizzatore sulla classe Deck in modo da poter ottenere una carta dal mazzo specificando seme e valore.
 * 5) Qualora si volesse definire una nuova classe "FrenchDeck" che contempli un mazzo di carte francesi (semi: picche, quadri, fiori, cuori)
 *    come protebbe essere modellato? Si noti che in tale mazzo sono presenti anche le  carte jolly, non appartenenti a nessun seme.
 *    Si poronga un'implementazione indipendentemente da quanto già esistente (ragionare su come poter implementare l'indicizzatore...)
 *    (si cerchi di evitare l'uso dei generici, oggetto della prossima lezione di teoria)
 */

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            deck.Initialize();
            deck.Print();

            Console.WriteLine("== Alcune Carte ==");

            //Card assobastoni = deck[ItalianSeed.BASTONI, ItalianValue.ASSO];
            //Console.WriteLine(assobastoni.ToString());
        }
    }
}
