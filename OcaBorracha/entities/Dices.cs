using OcaBorracha.interfaces;
using System;
using System.Collections.Generic;

namespace OcaBorracha.entities
{
    internal class Dices : IDices
    {
        private readonly Random rnd = new Random();
        public int diceFaces { get; }
        public int numberDices { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dices"/> class.
        /// </summary>
        /// <param name="face">The caras.</param>
        public Dices(int face, int numberDices)
        {
            this.diceFaces = face;
            this.numberDices = numberDices;
        }

        /// <summary>
        /// Drops the dices.
        /// </summary>
        /// <param name="numberDices">The cantidad dados.</param>
        /// <returns>A list of int.</returns>
        public List<int> DropDices(int numberDices)
        {
            List<int> listDicesResult = new List<int>();
            for (var i = 1; i <= numberDices; i++)
            {
                listDicesResult.Add(CalculateDices);
            }
            return listDicesResult;
        }

        public List<int> DropDices()
        {
            List<int> listDicesResult = new List<int>();
            for (var i = 1; i <= numberDices; i++)
            {
                listDicesResult.Add(CalculateDices);
            }
            PrintDices(listDicesResult);
            return listDicesResult;
        }

        /// <summary>
        /// Gets the calculate dices.
        /// </summary>
        private int CalculateDices => rnd.Next(1, diceFaces);

        private async void PrintDices(List<int> listDices)
        {
            listDices.ForEach(x => Console.WriteLine($"dado => {x}"));
        }
    }
}