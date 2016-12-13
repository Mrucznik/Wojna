﻿using System;

namespace War.Cards
{
    public class Card
    {
        private readonly CardColour _color;
        private readonly CardType _type;

        //--- Konstruktor i metody ---
        public Card(CardType type, CardColour color)
        {
            _type = type;
            _color = color;
        }

        public string Name => _type.Name + " " + _color.Name;

        public bool IsStronger(Card card)
        {
            if (_type.IsStronger(card._type))
                return true;
            return _type.IsEqual(card._type) && _color.IsStronger(card._color);
        }

        public bool IsWeaker(Card card)
        {
            if (_type.IsWeaker(card._type))
                return true;
            return _type.IsEqual(card._type) && _color.IsWeaker(card._color);
        }

        public bool IsEqual(Card card) => _type.IsEqual(card._type) && _color.IsEqual(card._color);

        public void Print() => Console.WriteLine(Name);
    }
}