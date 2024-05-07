using System;

namespace SwinAdventure
{
	public class Player : GameObject, IhaveInventory
	{
		private Inventory _inventory;

		public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
		{
			_inventory = new Inventory();
		}

        public override string FullDescription
        {
            get { return $"{Name}, {base.FullDescription}, you are carrying: {_inventory.ItemList}"; }

        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }


        public GameObject Locate(string Id)
		{
			if (AreYou(Id) == true)
			{
				return this;
			}
			return _inventory.Fetch(Id);
		}
	
		
	}
}

