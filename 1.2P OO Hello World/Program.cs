using System;

namespace HelloWorld
{
    class Program
    {
        public static void Main (string[] args)
        {
            Message myMessage = new Message("Hello World");
            myMessage.Print();

            Message[] messages = new Message[5];

            messages[0] = new Message("Welcome Back");
            messages[1] = new Message("What a lovely name");
            messages[2] = new Message("Great name");
            messages[3] = new Message("Oh hi!");
            messages[4] = new Message("Thats a silly name!");

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine().ToLower();
            

            if (name == "manar") {
                messages[0].Print();
            }
            else if (name == "varti") {

                messages[1].Print();
            }
            else if (name == "david")
            {
                messages[2].Print();
            }
            else if (name == "alin")
            {
                messages[3].Print();
            }
            else {
                messages[4].Print();
            }


            Console.ReadLine();

        }
    }
}