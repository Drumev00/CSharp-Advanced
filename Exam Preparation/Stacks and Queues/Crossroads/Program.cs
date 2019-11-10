using System;
using System.Collections;
using System.Collections.Generic;

namespace Crossroads
{
	class Program
	{
		static void Main(string[] args)
		{
			int greenLightDuration = int.Parse(Console.ReadLine());
			int green = greenLightDuration;
			int freeWindow = int.Parse(Console.ReadLine());
			var queuedCars = new Queue<string>();
			string command = string.Empty;
			int passedCars = 0;
			bool crashHappened = false;

			while ((command = Console.ReadLine()) != "END")
			{
				if (command == "green")
				{
					greenLightDuration = green;
					while (queuedCars.Count > 0 || crashHappened)
					{
						if (greenLightDuration <= 0)
							break;
						if (queuedCars.Peek().Length > greenLightDuration && queuedCars.Peek().Length <= greenLightDuration + freeWindow)
						{
							greenLightDuration -= queuedCars.Peek().Length;
							queuedCars.Dequeue();
							passedCars++;
						}
						else if (queuedCars.Peek().Length > greenLightDuration + freeWindow)
						{
							Console.WriteLine($"A crash happened!\n{queuedCars.Peek()} was hit at {queuedCars.Peek()[greenLightDuration + freeWindow]}.");
							crashHappened = true;
							break;
						}
						if (queuedCars.Peek().Length <= greenLightDuration)
						{
							greenLightDuration -= queuedCars.Peek().Length;
							queuedCars.Dequeue();
							passedCars++;
						}
					}
					if (crashHappened)
						break;
					continue;
				}
				queuedCars.Enqueue(command);
			}
			if (!crashHappened)
			{
				Console.WriteLine($"Everyone is safe.\n{passedCars} total cars passed the crossroads.");
			}
		}
	}
}
