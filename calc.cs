using System;
using System.Collections.Generic;

namespace Calculator{

	class Program {

		public static void Main(string[] args){

			Console.Write("Input calc expression: ");

			ConsoleKeyInfo pressedKey;

			double totalResult = 0;

			List<double> summed = new List<double>();

			List<double> extracted = new List<double>();

			string fromInput = string.Empty;

			char currentOp = char.Parse("0");

			do {

				pressedKey = Console.ReadKey();

				if (pressedKey.Key != ConsoleKey.Enter){

				try {

						double isANum = double.Parse(pressedKey.KeyChar.ToString());

						fromInput += isANum.ToString();
				}
				catch {

					if (pressedKey.Key == ConsoleKey.Add & fromInput.Length > 0){

						summed.Add(double.Parse(fromInput));

						currentOp = char.Parse("+");

						fromInput = string.Empty;
					}

					if  (pressedKey.Key == ConsoleKey.Subtract & fromInput.Length > 0){

						extracted.Add(double.Parse(fromInput));

						currentOp = char.Parse("-");

						fromInput = string.Empty;
					}

					else { }
				}}
			}
			while (pressedKey.Key != ConsoleKey.Enter);


			if (currentOp == char.Parse("+")){

				summed.Add(double.Parse(fromInput));
			}

			if (currentOp == char.Parse("-")){

				extracted.Add(double.Parse(fromInput));
			}

			Console.WriteLine("Total operations todo: {1}", summed.Count + extracted.Count);

			if (summed.Count > 0){

				foreach (double inc in summed){

					totalResult += inc;
				}
			}

			if (extracted.Count > 0){

				foreach (double dec in extracted){

					totalResult -= dec;
				}
			}

			Console.WriteLine("Result is : {1}", totalResult);
		}
	}
}
