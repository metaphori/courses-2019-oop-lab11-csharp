using System;

namespace Cards
{
    class Deck
    {
        private Card[] cards;

        public Deck()
        { 
        }

        public void Initialize()
        {
            /*
             * == README ==
             * 
             * I due enumerati (ItalianSeed e ItalianValue) definiti in fondo a questo file rappresentano rispettivamente semi e valori
             * di un tipo mazzo di carte da gioco italiano.
             * 
             * Questo metodo deve inizializzare il mazzo (l'array cards) considerando tutte le combinazioni possibili.
             * 
             * Nota - Dato un generico enumerato MyEnum:
             *   a) è possibile ottenere il numero dei valori presenti con Enum.GetNames(typeof(MyEnum)).Length
             *   b) è possibile ottenere l'elenco dei valori presenti con (MyEnum[])Enum.GetValues(typeof(MyEnum))
             * 
             */

            throw new NotImplementedException();
        }

        public void Print()
        {
            /*
             * == README  ==
             * 
             * Questo metodo stampa tutte le carte presenti nel mazzo, con una propria rappresentazione a scelta.
             */

            throw new NotImplementedException();
        }

    }

    enum ItalianSeed
    {
        DENARI,
        COPPE,
        SPADE,
        BASTONI
    }

    enum ItalianValue
    {
        ASSO,
        DUE,
        TRE,
        QUATTRO,
        CINQUE,
        SEI,
        SETTE,
        FANTE,
        CAVALLO,
        RE
    }
}
