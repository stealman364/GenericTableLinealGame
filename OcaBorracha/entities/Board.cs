using OcaBorracha.interfaces;
using System;
using System.Collections.Generic;

namespace OcaBorracha.entities
{
    internal class Board
    {
        private IDashCell dashCell;
        private int[] game;
        private IDices dices;

        public Board(IDashCell dashCell, IDices dices)
        {
            this.dashCell = dashCell;
            this.game = dashCell.GetGame();
            this.dices = dices;
        }

        public string AdvanceSquares(IPlayer player)
        {
            Console.WriteLine($"Player {player.GetProfile()}");
            int sumDices = 0;
            List<int> diceList = this.dices.DropDices();
            diceList.ForEach(x => sumDices += x);
            AdvancePlayer(sumDices, player);
            return dashCell.GetValue(player.getPosition());
        }

        private bool CanAdvance(int diceNumber, IPlayer player) => game.Length - 1 >= player.getPosition() + diceNumber;

        private bool IsWinner(IPlayer player) => game.Length - 1 == player.getPosition();

        private void AdvancePlayer(int diceNumber, IPlayer player)
        {
            if (CanAdvance(diceNumber, player))
            {
                player.advance(diceNumber);
                if (IsWinner(player)) player.Winner(game.Length - 1);
            }
            else player.advance((game.Length - 1) + ((game.Length - 1) - (player.getPosition() + diceNumber)) - player.getPosition());//Boing
        }
    }
}