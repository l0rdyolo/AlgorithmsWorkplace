using System;
namespace SubString;

class Program
{
    static bool IsSubString(string s1, string s2) {
        int l_s1 = s1.Length + 1; 
        int l_s2 = s2.Length + 1;
        int[,] matrix = new int[l_s1, l_s2];
        int maxValue = 0;

        for (int i = 1; i < l_s1; i++) {
            for (int j = 1; j < l_s2; j++) {
                
                if (s1[i - 1] == s2[j - 1]) {
                    matrix[i, j] = matrix[i - 1, j - 1] + 1;
                    if (matrix[i, j] > maxValue) {
                        maxValue = matrix[i, j];
                    }
                }
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        return maxValue == s2.Length; 
    }

    static void Main(string[] args) {
        string s1 = "abcdefg";
        string s2 = "bcde";

        Console.WriteLine(IsSubString(s1, s2));
    }
}
