using System;

namespace HelloWorld
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Message myMessage;
			Message[] messages;	/* Declare an aray */
			string name;

			myMessage = new Message ("Hello World! - from Message Object");
			myMessage.Print();

			messages = new Message[4]; /* Initialise an array with four elements */

			messages[0] = new Message("Hello genius, welcome back!");
			messages[1] = new Message("Why what a fancy name you have!");
			messages[2] = new Message("Well, I guess that name's ok...");
			messages[3] = new Message("Oh, who are you?");

			Console.WriteLine("What are you called: ");
			name = Console.ReadLine(); 

			if (name.ToLower() == "caitlyn")
				messages [0].Print ();
			else if (name.ToLower() == "gary")
				messages [1].Print ();
			else if (name.ToLower() == "michael")
				messages [2].Print ();
			else
				messages [3].Print ();

			Console.ReadLine();
		}
	}
}
