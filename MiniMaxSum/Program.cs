using System;
using System.Linq;

class Program
{
	static void MiniMaxSum(int[] arr)
	{
		Array.Sort(arr);
		long minSum = 0, maxSum = 0;

		for (int i = 0; i < 4; ++i)
		{
			minSum += arr[i];
		}

		for (int i = 1; i < 5; ++i)
		{
			maxSum += arr[i];
		}

		Console.WriteLine($"{minSum} {maxSum}");

		for (int i = 0; i < 5; ++i)
		{
			long sum = 0;
			for (int j = 0; j < 5; ++j)
			{
				if (j != i)
				{
					sum += arr[j];
				}
			}
			Console.WriteLine($"If we sum everything except {arr[i]}, our sum is: {sum}");
		}
	}

	static void Main(string[] args)
	{
		int[] arr = new int[5];
		Console.WriteLine("Enter 5 integers separated by spaces: ");
		string input = Console.ReadLine();
		string[] inputArr = input.Split(' ');
		for (int i = 0; i < 5; ++i)
		{
			arr[i] = int.Parse(inputArr[i]);
		}
		MiniMaxSum(arr);
	}
}
