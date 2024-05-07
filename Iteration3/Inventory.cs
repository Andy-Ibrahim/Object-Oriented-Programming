using System;

namespace SwinAdventure
{
	public class Inventory 
	{
		private List<Item> _items;

		public Inventory()
		{
			_items = new List<Item>();
		}

		public string ItemList
		{
			get
			{
				string list = "";
				foreach (Item i in _items)
				{
                    list += i.ShortDescription;
                }

				return list;
			} 
		}

		public bool HasItem(string id)
		{
			foreach (Item i in _items)
			{
				if (i.AreYou(id)){
					return true;

				}
			}

			return false;

		}

		public void Put (Item itm)
		{
            _items.Add(itm);

        }

		public Item Take(string id)
		{
			Item take_item = Fetch(id);
			_items.Remove(take_item);
			return take_item;
		}

		public Item Fetch(string id)
		{
			foreach (Item i in _items)
			{
				if (i.AreYou(id))
				{
					return i;
				}
			}

			return null;
		}

	}
}

