using System.Collections.Generic;

namespace OcaBorracha.enums
{
    internal static class PositionValueTableOca
    {
        public static readonly Dictionary<OcaEnum, string> OcaComuns
        = new Dictionary<OcaEnum, string>
        {
            { OcaEnum.Abstemic, "Posada del Abstemio !no se bebe!" },
            { OcaEnum.Drink, "¡A beber!" },
            { OcaEnum.BattleDices, "Se reta al número de jugadores indicado en la casilla a que tiren el dado. El que saque el número menor bebe" },
            { OcaEnum.Ocas, "Se salta a la siguiente oca y se bebe un vaso" },
            { OcaEnum.Labyrinth, "Te quedas aquí hasta que saques un 5 o un 6, sino bebes 1 vaso por turno" },
            { OcaEnum.Rules, "Se pone una norma adicional, la cuál afecta a todos los jugadores hasta que se cambie por otra norma" },
            { OcaEnum.CulturalQuestion, "El jugador hace una pregunta con varias respuestas posibles para elegir, y el que falle bebe" },
            { OcaEnum.Hipnosis, "Durante un turno bebes la mitad de las deudas de un jugador. Por ejemplo si un jugador tiene que beber 4 vasos, tú bebes 2 y él otros 2" },
            { OcaEnum.Jail, "Se tiran los dados, y la suma de los dos números son la fianza para salir de la cárcel. Hay que beberse esa cantidad de vasos o esperar a que otro jugador caiga en la cárcel para poder salir" },
        };

        public enum OcaEnum
        {
            Abstemic,
            Drink,
            BattleDices,
            Ocas,
            Labyrinth,
            Rules,
            CulturalQuestion,
            Hipnosis,
            Jail
        }
    }
}