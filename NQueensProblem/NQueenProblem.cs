

using System.Runtime.CompilerServices;
using System;
using System.Reflection.Metadata;

namespace AlgorithmsWorkplace;

class NQueenProblem
{
    static int QUEENCELL = 1;
    static int EMPTYCELL = 0;

    //N -> queen count
    static void SolveNQueen(int[,] board, int N)
    {
        string noSolution_Message = "No Solution";
            if (N <= 3)
            {
                Console.WriteLine(noSolution_Message);
                return;
            }

        if (PlaceQueens(board, 0 , N))
        {
            PrintBoard(board, N);
        }
        else
        {
            Console.WriteLine(noSolution_Message);
        }
    }

    static bool PlaceQueens(int[,] board, int row, int N)
    {
        if (row >= N)
        {
            return true;
        }
        for (int col = 0; col < N; col++)
        {
            if(IsSafe(board,row,col,N)){
                board[row,col] = 1;
                if(PlaceQueens(board , row + 1 , N)){
                    return true;
                }
                board[row,col] = 0;
            }
        }
        return false;
    }

    static bool IsSafe(int[,] board, int row, int col, int N)
    {
        //checking upper grid cells
        for (int i = 0; i < row; i++)
        {
            if (board[i, col] == 1)
            {
                return false;
            }
        }
        //checking left diagonal grid cells
        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
        {
            if (board[i, j] == 1)
            {
                return false;
            }
        }
        //checking right diagonal grid cells
        for (int i = row - 1, j = col + 1; i >= 0 && j < N; i--, j++)
        {
            if (board[i, j] == 1)
            {
                return false;
            }
        }

        return true;
    }

    static void PrintBoard(int[,] board, int N)
    {
        int row = N;
        int col = row;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(board[i, j] == 1 ? QUEENCELL : EMPTYCELL);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        int N = 8;
        int[,] board = new int[N, N];

        //placing first queen Manually
        int firstQueenColIndex = 0;
        board[0,firstQueenColIndex] = 1;


        SolveNQueen(board,N);

    }
}
