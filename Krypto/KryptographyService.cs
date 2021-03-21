using System;
using System.Collections.Generic;
using System.Text;

namespace Krypto
{
    public class KryptographyService
    {
        public string DecodeRail(string input, int key)
        {
            char[,] matrix = new char[key, input.Length];

            int row = 0, col = 0;
            bool move_down = true;

            for(int i = 0; i < input.Length; i++)
            {
                if(row == 0)
                {
                    move_down = true;
                }
                if(row == key - 1)
                {
                    move_down = false;
                }

                matrix[row, col] = '*';
                col++;

                if (move_down)
                {
                    row++;
                }
                else
                {
                    row--;
                }
            }

            int index = 0;
            for(int i = 0; i < key; i++)
            {
                for(int j = 0; j < input.Length; j++)
                {
                    if(matrix[i,j] == '*' && index < input.Length)
                    {
                        matrix[i, j] = input[index];
                        index++;
                    }
                }
            }

            string output = "";
            row = 0;
            col = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (row == 0)
                {
                    move_down = true;
                }
                if (row == key - 1)
                {
                    move_down = false;
                }

                if(matrix[row,col] != '*')
                {
                    output += matrix[row, col];
                }
                col++;
                if (move_down)
                {
                    row++;
                }
                else
                {
                    row--;
                }
            }

            return output;
        } 
        public string EncodeRail(string input, int key)
        {
            char[,] matrix = new char[key, input.Length];

            int row = 0;
            int col = 0;
            bool move_down = true;
            while (col < input.Length)
            {
                matrix[row, col] = input[col];

                if (row == key - 1)
                {
                    move_down = false;
                }
                if(row == 0)
                {
                    move_down = true;
                }

                if (move_down)
                {
                    row++;
                }
                else
                {
                    row--;
                }

                col++;
            }

            string output = string.Empty;

            
            for(int i = 0; i < key; i++)
            {
                for (int j = 0; j < input.Length; j ++)
                {
                    if(matrix[i,j] != '\0')
                    output += matrix[i, j];
                }
            }

            return output;
        }         
        public string EncodeMatrixShift(string input)
        {
            string output = string.Empty;
            int d = 5;

            char[,] matrix = new char[d, d];

            int index = 0;
            int row = 0;
            while(index < input.Length)
            {
                int ptr = index;
                matrix[row, ptr % 5] = input[index];

                index++;

                if (index % 5 == 0 && index != 0)
                    row++;

                
            }

            row = 0;
            index = 0;

            for(int i = 0; i < d; i++)
            {
                if (matrix[row, 2] != '\0')
                {
                    output += matrix[row, 2];
                    index++;
                    if (index >= input.Length)
                        break;
                }

                if (matrix[row, 3] != '\0')
                {
                    output += matrix[row, 3];
                    index++;
                    if (index >= input.Length)
                        break;
                }

                if (matrix[row, 0] != '\0')
                {
                    output += matrix[row, 0];
                    index++;
                    if (index >= input.Length)
                        break;
                }

                if (matrix[row, 4] != '\0')
                {
                    output += matrix[row, 4];
                    index++;
                    if (index >= input.Length)
                        break;
                }

                if (matrix[row, 1] != '\0')
                {
                    output += matrix[row, 1];
                    index++;
                    if (index >= input.Length)
                        break;
                }


                row++;
            }

            return output;
        }         
        public string DecodeMatrixShift(string input)
        {
            string output = string.Empty;

            while (input.Length > 0)
            {
                if (input.Length >= 2)
                {
                    output += input[1];
                }

                if (input.Length >= 5)
                {
                    output += input[4];
                }

                output += input[0];

                if (input.Length >= 4)
                {
                    output += input[3];
                }

                if (input.Length >= 3)
                {
                    output += input[2];
                }

                if (input.Length >= 5)
                {
                    input = input[5..];
                }
                else
                {
                    break;
                }
            }

            return output;
        }         
        public string Encode2b(string input, string key)
        {
            return null;
        } 
        public string Decode2b(string input, string key)
        {
            return null;
        } 
        public string Encode2c(string input, string key)
        {
            return null;
        } 
        public string Decode2c(string input, string key)
        {
            return null;
        } 

        public string EncodeCeaser(string input, int a, int b)
        {
            return null;
        }

        public string DecodeCeaser(string input, int a, int b)
        {
            return null;
        }

        public string EncodeVigenere(string input, string key)
        {
            return null;
        }

        public string DecodeVigenere(string input, string key)
        {
            return null;
        }
    }
}
