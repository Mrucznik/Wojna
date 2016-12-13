﻿using System;
using System.Collections.Generic;

namespace War.Deck
{
    public class Pack
    {
        private readonly List<Card> _cards;

        public Pack(List<Card> cards)
        {
            _cards = cards;
        }

        public List<Card> DistributeShuffledCards(int ammount)
        {
            //TODO: Throw an exepction when ammount > _cards.length
            var random = new Random();
            var cards = new List<Card>();
            for (int i = 0; i < ammount; i++)
            {
                int index = random.Next(_cards.Count);
                cards.Add(_cards[index]); //probably error xd
                _cards.RemoveAt(index);
            }
            return cards;
        }

        public int CardsAmmount => _cards.Count;

        public void Print()
        {
            foreach (var card in _cards)
            {
                card.Print();
            }
        }
    }
}