using System;

namespace SwinAdventure
{
	public class GameObject : IdentifiableObject
	{
		string _description;
		string _name;

		public GameObject (string[] ids, string name, string desc): base(ids)
		{
			_name = name;
			_description = desc;
		}

		public string Name
		{
			get { return _name; }
		}

		public string Description
		{
			get { return _description; }
		}

		public string ShortDescription
		{
			get { return $"{_name} ({FirstId})"; }
			
		}

		virtual public string FullDescription
		{
			get { return _description; }
		}
	}
}

