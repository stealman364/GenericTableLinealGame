namespace OcaBorracha.interfaces
{
    internal interface IPlayer
    {
        void advance(int count);

        int getPosition();

        string GetProfile();

        bool Winner(int lengthGame);

        bool Win();
    }
}