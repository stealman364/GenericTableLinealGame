using System.Collections.Generic;

namespace OcaBorracha.interfaces
{
    internal interface IDices
    {
        public List<int> DropDices();

        public List<int> DropDices(int numberDices);
    }
}