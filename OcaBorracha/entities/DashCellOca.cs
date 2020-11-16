using OcaBorracha.enums;
using OcaBorracha.interfaces;
using static OcaBorracha.enums.PositionValueTableOca.OcaEnum;

namespace OcaBorracha.entities
{
    internal class DashCellOca : IDashCell
    {
        private readonly int lengthNumber = campos.Length;
        private string description = "Juego de la Ocalimoxo";

        public int[] GetGame()
        {
            return new int[lengthNumber];
        }

        public string GetValue(int position)
        {
            return campos[position];
        }

        public string GetInfoGame()
        {
            return description;
        }

        private static readonly string[] campos = {
            "jurar fidelidad al alcohol que tomareis",
            "Bebemos Todos para empezar",
            "Mandas Beber a dos personas",
            PositionValueTableOca.OcaComuns[Rules],
            "Bebe 2 y pasas a la casilla 17",
            "Por el culo te la inco, todos bebemos",
            PositionValueTableOca.OcaComuns[Abstemic],
            PositionValueTableOca.OcaComuns[Drink],
            "Cantar en voz alto o beber",
            PositionValueTableOca.OcaComuns[BattleDices],
            PositionValueTableOca.OcaComuns[Ocas],
            PositionValueTableOca.OcaComuns[Labyrinth],
            "Beben los que tengan el movil en la mano",
            PositionValueTableOca.OcaComuns[CulturalQuestion],
            PositionValueTableOca.OcaComuns[Drink],
            "No puedes fumar hasta que se acabe el juego o beberas",
            PositionValueTableOca.OcaComuns[Hipnosis],
            PositionValueTableOca.OcaComuns[Ocas],
            PositionValueTableOca.OcaComuns[BattleDices],
            PositionValueTableOca.OcaComuns[Abstemic],
            "Bebes tu y el de tu izquierda",
            PositionValueTableOca.OcaComuns[Drink],
            PositionValueTableOca.OcaComuns[Rules],
            "DeadRoyale Bebeis lo que os queda en el vaso, el perdedor retrocede 4 casillas",
            "FIN"
        };
    }
}