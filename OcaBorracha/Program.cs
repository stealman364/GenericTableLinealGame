using OcaBorracha.entities;
using OcaBorracha.interfaces;
using System;
using System.Collections.Generic;

namespace OcaBorracha
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IDashCell dashCell = new DashCellOca();
            IDices dices = new Dices(6, 2);
            Board board = new Board(dashCell, dices);
            Console.WriteLine(dashCell.GetInfoGame());
            List<IPlayer> playersList = GetListPlayers(CountPlayers());
            while (!PlayerWin(playersList))
            {
                TurnPlayer(playersList, board);
            }
        }

        private static List<IPlayer> GetListPlayers(int playersCount)
        {
            List<IPlayer> playersList = new List<IPlayer>();
            for (var i = 0; i < playersCount; i++)
            {
                playersList.Add(Player.GeneratePlayerConsole());
            }
            return playersList;
        }

        private static int CountPlayers()
        {
            int numberPlayers = 0;
            while (numberPlayers <= 0)
            {
                Console.WriteLine("\nIndique un numero de jugadores correcto");
                int.TryParse(Console.ReadLine(), out numberPlayers);
            }
            return numberPlayers;
        }

        private static bool PlayerWin(List<IPlayer> playerList)
        {
            bool bandera = false;
            playerList.ForEach(x => { if (x.Win()) bandera = true; });
            return bandera;
        }
        private static bool TurnPlayer(List<IPlayer> playersList, Board board)
        {
            var result = "";
            foreach (var player in playersList)
            {
                result = board.AdvanceSquares(player);
                Console.WriteLine(result);
                if (result == "FIN")
                    return true;
            }
            return false;
        }
    }
}