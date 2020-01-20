using System;
using System.Collections.Generic;

namespace ExamenAmazon
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] val = { 0,1,0,0,0,1,1 };

            var algo1 = SetVallue(val, 1);


            Console.ReadLine();

 

        }


        public static  int[] SetVallue(int[] valores, int days)
        {
            var nuevoArray = new List<int>();

            for (int i = 0; i < days; i++)
            { 

                for (int j = 0; j < valores.Length; j++)
                {
                    if (j == valores.GetLowerBound(0))
                    {

                        if (valores[j + 1] == 0)
                        {
                            nuevoArray.Add(0);
                        }
                        else if (valores[j + 1] == 1)
                        {
                            nuevoArray.Add(1);
                        }
                        continue;
                    }

                    if (j == valores.GetUpperBound(0))
                    {

                        if (valores[j - 1] == 0)
                        {
                            nuevoArray.Add(0);
                        }
                        else if (valores[j - 1] == 1)
                        {
                            nuevoArray.Add(1);
                        }
                        continue;
                    }

                    if (valores[j - 1] == valores[j + 1])
                    {
                        nuevoArray.Add(0);
                    }
                    else if (valores[j - 1] != valores[j + 1])
                    {
                        nuevoArray.Add(1);
                    }
                }

                valores = nuevoArray.ToArray();
                  
                }


            return nuevoArray.ToArray();

        }
    }
}