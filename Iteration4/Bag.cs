using System;

namespace SwinAdventure
{
    public class Bag : Item, IhaveInventory
    {
        private Inventory _inventory;

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (this.AreYou(id))
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(id);
            }
        }

        public override string FullDescription
        {
            get { return $"in the {this.Name} you can see:" + _inventory.ItemList;}
                             
        }

        public Inventory Inventory
        {
            get { return _inventory; }
            
        }
    }

}

