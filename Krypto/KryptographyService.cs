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
            return null;
        }         
        public string DecodeMatrixShift(string input)
        {
            return null;
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

        public string EncodeCeaser(string input, int a,int b)
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
