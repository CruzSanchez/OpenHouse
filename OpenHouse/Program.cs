using System;

namespace OpenHouse
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Your Future Dream Home!");
			Console.WriteLine();
			Console.WriteLine("Would you like to come in? " + "Enter: y/n");
			string UserResponse = Console.ReadLine();
			if (UserResponse == "y")
			{
				Console.WriteLine();
				Console.WriteLine("Here we shall see the foyer.");
				Console.WriteLine("You can see the nice stone flooring. Notice the special area for shoes, jackets, etc.");
			}
			else
			{
				Console.WriteLine();
				Console.WriteLine("Then get the hell out and quit wasting my time.");
				Console.ReadLine();
				goto end;
			}

			Console.WriteLine("Would you like to see the living room!? " + "Enter: y/n");
			Console.WriteLine();
			UserResponse = Console.ReadLine();
			if (UserResponse == "y")
			{
				Console.WriteLine("Take note of the extra nice 9ft ceilings!");
				Console.WriteLine("Don't mind that body laying over in the corner >_>....");
				Console.WriteLine();
			}
			else
			{
				goto end;
			}

			Console.WriteLine("So if that didn't freak you out would you like to continue? " + "Enter: y/n");
			UserResponse = Console.ReadLine();
			if (UserResponse == "y")
			{
				Console.WriteLine();
				Console.WriteLine("Here we'll find the fantastic kitchen.");
				Console.WriteLine("We have all stainless steel appliances.");
				Console.WriteLine("Inspect the refridgerator? " + "Enter: y/n");
				UserResponse = Console.ReadLine();
				if (UserResponse == "y")
				{
					Console.WriteLine();
					Console.WriteLine("Get out of the refridgerator Toby, I hate you");
					Console.ReadLine();

				}
				else
				{
					Console.WriteLine("Well lets move on then.");
				}
			}
			else
			{
				goto end;
			}

			Console.WriteLine("Continue to the master bedroom? " + "Enter y/n");
			UserResponse = Console.ReadLine();
			if (UserResponse == "y")
			{
				Console.WriteLine();
				Console.WriteLine("Here is the master bedroom.");
				Console.WriteLine("There's plenty of room for a california king bed!");
				Console.WriteLine("An excellent double door leading to the balcony overlooking the huge backyard.");
				Console.WriteLine();
			}
			else
			{
				goto end;
			}


			Console.WriteLine("Continue to master bathroom? " + "Enter: y/n");
			UserResponse = Console.ReadLine();
			if (UserResponse == "y")
			{
				Console.WriteLine("Beautiful grey tile walls, like a dark grey but not too dark, like you know just the RIGHT amount of dark.");
				Console.WriteLine("Lovely walk-in shower with a rainfall shower head and jets");
				Console.WriteLine("Inspect shower? " + "Enter y/n");
				UserResponse = Console.ReadLine();
				if (UserResponse == "y")
				{
					Console.WriteLine("The shower is broken....");
				}
				else
				{
					Console.WriteLine("Moving on..");
				}
			}
			else
			{
				goto end;
			}

			Console.WriteLine("Continue to theater? " + "Enter: y/n");
			UserResponse = Console.ReadLine();
			if (UserResponse == "y")
			{
				Console.WriteLine("The last room we're showing off is the theater.");
				Console.WriteLine("It has an unbelievible 150 inch projector screen with up to 8k resolution!!");
				Console.WriteLine("All the seats recline, have cup holders, and there's a commercial popcorn maker in the back.");
				Console.WriteLine("Oh and this has every movie ever made built into it. " + "Pretty sweet huh?");
				Console.ReadLine();
			}
			else
			{
				goto end;
			}

			Console.WriteLine();
			Console.WriteLine("So after seeing this excellent house, are you intrested in buying? " + "Enter y/n");
			UserResponse = Console.ReadLine();
			if (UserResponse == "y")
			{
				Console.WriteLine("Great! Lets get you started with a pre-approval right away!!");
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("<_< OK, WOW, THANKS FOR WASTING MY TIME! COME BACK WHEN YOU WANT TO SPEND SOME $$$");
				Console.ReadLine();
			}


			end:;
		}
	}
}
