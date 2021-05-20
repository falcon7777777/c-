using System;

namespace savarjishoamocanebi {
    class Program {
        static void Main(string[] args) {
            Random n = new Random();
            int[] array = new int[20];
           
            for (int i = 0; i < array.Length; i++) {
                array[i] = n.Next(80);
                Console.Write(array[i] + " ");
            }
            int Even = FindEven(array);
            int Odd = FindOdd(array);

            Console.WriteLine("Even =" + Even);
            Console.WriteLine("Odd =" + Odd);
        }

        static int FindEven(int[] array) {
            int Even = 0;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == (array[i] / 2) * 2) {
                    Even++;
                }
                else {
                    continue;
                }
            }
            return Even;
        }
        static int FindOdd(int[] array) {
            int Odd = 0;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] != (array[i] / 2) * 2) {
                    Odd++;
                }
                else {
                    continue;
                }
            }
            return Odd;
        }
    }
}
