﻿/*
Write a function:

class Solution { public int solution(int[] A); }

that, given a non-empty zero-indexed array A of N integers, returns the minimal positive integer (greater than 0) that does not occur in A.

For example, given:

  A[0] = 1
  A[1] = 3
  A[2] = 6
  A[3] = 4
  A[4] = 1
  A[5] = 2
the function should return 5.

Assume that:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].
Complexity:

expected worst-case time complexity is O(N);
expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).
Elements of input arrays can be modified.*/

using System;
class Solution {
	public int solution(int[] A) {

		bool[] data = new bool[A.Length+1];

		for (int i=0; i < A.Length; i++)
		{
			if (A[i] > 0 && A[i] <= A.Length+1 && !data[A[i]-1])
			{
				data[A[i]-1] = true;
			}
		}

		for (int i=0; i < A.Length+1; i++)
		{
			if (!data[i])
				return i+1;
		}
		return 1;
	}

	static void Main(string[] args)
	{
		Solution s = new Solution();

		int[] TestCase = new int[6] {1,3,6,4,1,2};
		Console.WriteLine(s.solution(TestCase));

	}
}
