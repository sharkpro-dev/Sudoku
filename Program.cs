using System;
using System.Security.Principal;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 7, x = 6, numero = 2;

            //Declarar arreglo
            int[][] sudoku = new int[9][];
            sudoku[0] = new int[9];
            sudoku[1] = new int[9];
            sudoku[2] = new int[9];

            sudoku[3] = new int[9];
            sudoku[4] = new int[9];
            sudoku[5] = new int[9];
            
            sudoku[6] = new int[9];
            sudoku[7] = new int[9];
            sudoku[8] = new int[9];

            //Validar ingreso de datos
            //Ingresar cordenadas
            //ingresar eje X
            //Ingresar eje Y
            //Ingresar numero

            //Validar linea horrizontal
            for(int i = 0; i < 9; i++)
            {
                if(i != x)
                {
                    if(numero == sudoku[i][y])
                    {
                        //Numero repetido
                        break;
                        //Saltar mensaje
                    }
                }
            }

            //Validar Linea vertical
            for (int i = 0; i < 9; i++)
            {
                if (i != x)
                {
                    if (numero == sudoku[x][i])
                    {
                        //Numero repetido
                        break;
                    }
                }
            }

            //Validar cuadro 3 x 3
            Validar3x3(sudoku, x, y, numero);
        }

        private static void Validar3x3(int[][] sudoku, int x, int y, int numero)
        {
            int initX = 0, maximX = 0, initY = 0, maximY = 0;

            if (x > 5 && x < 9)
            {
                initX = 6;
                maximX = 8;
            }
            else if (x > 2)
            {
                initX = 3;
                maximX = 5;
            }
            else if (x < 3)
            {
                initX = 0;
                maximX = 2;
            }
            else
            {
                //Fuera de parametros
            }
            if (y < 3)
            {
                initY = 0;
                maximY = 2;
            }
            for(int i = initX; i <= maximX; i++)
            {
                for(int j = initY; j <= maximY; j++)
                {
                    if (i != x && j != y)
                    {
                        if (numero == sudoku[i][j])
                        {
                            //Numero repetido
                            break;
                        }
                    }
                }
            }
        }
    }
}
