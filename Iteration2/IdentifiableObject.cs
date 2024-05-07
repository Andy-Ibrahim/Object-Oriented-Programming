using System;

namespace SwinAdventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();


        public IdentifiableObject(string[] idents)
        {
            for (int i = 0; i < idents.Length; i++)
            {
                _identifiers.Add(idents[i].ToLower());
            }
        }


        public bool AreYou(string id)
        {
            foreach (string i in _identifiers)
            {
                if (i == id.ToLower())
                {
                    return true;
                }
            }

            return false;

        }

        public string FirstId
        {
            get
            {
                if (_identifiers.Count == 0)
                {
                    return "";
                }
                else
                {
                    return _identifiers.First();
                }
            }
        }

        public void Addidentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }

    }
}



