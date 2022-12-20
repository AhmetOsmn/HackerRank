using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Questions
{
    public static class SudokuSolutionValidator
    {
        public static bool Execute(int[][] board)
        {
            var rows = GetRows(board);
            var columns = GetColumns(board);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (rows[i].Count(x => x == char.Parse(board[i][j].ToString())) > 1 || columns[i].Count(x => x == char.Parse(board[i][j].ToString())) > 1)
                    {
                        return false;
                    }
                    if ((i == 0 || i == 3 || i == 6) && (j == 0 || j == 3 || j == 6))
                    {
                        string subsquare = rows[i].Substring(j, 3) + rows[i + 1].Substring(j, 3) + rows[i + 2].Substring(j, 3);
                        if (subsquare.Count(x => x == char.Parse(board[i][j].ToString())) > 1)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
        public static List<string> GetColumns(int[][] matrix)
        {
            int[][] result = new int[][]{
                    new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
                    new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
                    new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
                    new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
                    new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
                    new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
                    new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
                    new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
                    new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
                };

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    result[j][i] = matrix[i][j];
                }
            }

            List<string> columns = new List<string>();

            for (int i = 0; i < result.Length; i++)

            {
                string row = "";
                for (int j = 0; j < result[i].Length; j++)
                {
                    row += result[i][j];
                }

                columns.Add(row);
            }

            return columns;
        }

        public static List<string> GetRows(int[][] matrix)
        {
            List<string> rows = new List<string>();

            for (int i = 0; i < matrix.Length; i++)

            {
                string row = "";
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    row += matrix[i][j];
                }

                rows.Add(row);
            }

            return rows;
        }


        public static void ShowBoard(List<string> board)
        {
            foreach (var item in board)
            {
                Console.WriteLine(item);
            }
        }
    }
}
