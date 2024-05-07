using System;
using System.ComponentModel;
using System.Numerics;

namespace SwinAdventure
{
    public class LookCommand : Command
    {
        public LookCommand(): base(new string[] { "look" }) { }

     
        public override string Execute(Player p, string[] text)
        {
            IhaveInventory container;
            string thingId;

            if (text.Length != 3 && text.Length != 5)
            {
                return "I don't know how to look like that";
            }

            if (text[0] != "look")
            {
                return "Error in look input";
            }

            if (text[1] != "at")
            {
                return "What do you want to look at?";
            }

            if (text.Length == 5 && text[3] != "in")
            {
                return "What do you want to look in?";
            }

            if (text.Length == 3)
            {
                container = p;
            }

            else
            {
                container = FetchContainer(p, text[4]);
            }


            if (container == null)
            {
                return $"I can't find the {text[4]}";
            }

            thingId = text[2];

            return LookAtIn(thingId, container);

        }


        private IhaveInventory FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IhaveInventory;
        }



        private string LookAtIn(string thingId, IhaveInventory container)
        {
            if (container.Locate(thingId) == null)
            {
                return $"I can't find the {thingId}";
            }
            else
            {
                return container.Locate(thingId).FullDescription;
            }
        }


    }

}

