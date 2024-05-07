using System;

namespace SwinAdventure
{
    public interface IhaveInventory
    {
        GameObject Locate(string id);

        public string Name
        {
            get;
        }
    } 

}

