namespace RotateMatrix;

class Program
{
    static void PrintMatrix(int[,] matrix, int matrix_row, int matrix_col)
    {
        int matrix_totalCell = matrix_row * matrix_col;
        int i = -1, j = 0;
        for (int loop = 0; loop < matrix_totalCell; loop++)
        {
            if (j % matrix_col == 0)
            {
                j = 0;
                i++;
                System.Console.WriteLine();
            }
            j++;
            System.Console.Write(matrix[i, j - 1] + " ");
        }
        System.Console.WriteLine();
    }

    static void RotateMatrix(int[,] original_matrix, int[,] rotated_matrix, int matrix_row, int matrix_col)
    {
        int matrix_totalCell = matrix_row * matrix_col;
        int i = -1, j = 0;
        for (int loop = 0; loop < matrix_totalCell; loop++)
        {
            if (j % matrix_col == 0)
            {
                j = 0;
                i++;
            }
            rotated_matrix[j, matrix_row - 1 - i] = original_matrix[i, j];
            j++;
        }
    }

    static void Main(string[] args)
    {
        int matrix_row = 3;
        int matrix_col = 4;

        int[,] original_matrix =  {
                { 0, 1, 0 ,0 },
                { 0, 1, 1 ,1 },
                { 0 ,1, 0 ,0 },
            };
        int[,] rotated_matrix = new int[matrix_col, matrix_row];

        RotateMatrix(original_matrix, rotated_matrix, matrix_row, matrix_col);
        PrintMatrix(rotated_matrix, matrix_col, matrix_row);  
    }
}
