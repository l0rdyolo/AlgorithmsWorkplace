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
                // Console.Write(matrix[i, j] + " ");
            }
            // Console.WriteLine();
        }

        return maxValue == s2.Length; 
    }

    static void Main(string[] args) {
           string[,] testCases = {
            {"abcdefg", "cde", "True"},
            {"abcdefg", "xyz", "False"},
            {"abcdefg", "abc", "True"},
            {"abcdefg", "efg", "True"},
            {"abcdefg", "abcdefg", "True"},
            {"abc", "abcdef", "False"},
            {"abcdefg", "e", "True"},
            {"", "a", "False"},
            {"abcdefg", "", "True"}
        };

           Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10}", "Test No", "s1", "s2", "Result", "Expected");

        for (int i = 0; i < testCases.GetLength(0); i++) {
            string s1 = testCases[i, 0];
            string s2 = testCases[i, 1];
            bool expectedResult = bool.Parse(testCases[i, 2]);
            bool result = IsSubString(s1, s2);
            string status = result == expectedResult ? "Pass" : "Fail";
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10} {5}", i + 1, s1, s2, result, expectedResult, status);
        }
    }
}
