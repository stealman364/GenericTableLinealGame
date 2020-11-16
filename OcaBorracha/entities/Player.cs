using OcaBorracha.interfaces;
using System;

namespace OcaBorracha.entities
{
    internal class Player : IPlayer
    {
        public readonly string name;
        public readonly int scoore;
        public readonly int level;
        public readonly IProfile profile;
        private int position;
        private bool win;

        public bool Win()
        {
            return win;
        }

        public Player(string name, int scoore, int level, IProfile profile)
        {
            this.name = name;
            this.scoore = scoore;
            this.level = level;
            this.profile = profile;
        }

        public Player(string name)
        {
            this.name = name;
        }

        public void advance(int count)
        {
            position += count;
            Console.WriteLine($"estoy en => {position}");
        }

        public int getPosition() => position;

        public string GetProfile()
        {
            return this.name;
        }

        public bool Winner(int lengthGame)
        {
            this.win = lengthGame == this.position ? true : false;
            Console.WriteLine("GANASTE");
            return this.win;
        }

        public static Player GeneratePlayerConsole()
        {
            Console.WriteLine("\nIndique el numbre del jugador");
            return new Player(Console.ReadLine());
        }
    }
}