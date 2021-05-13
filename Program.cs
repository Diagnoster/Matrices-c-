using System;

namespace MatrizExercicio {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];

            for (int i = 0; i < n; i++) { // percorrer linhas da matriz

                string[] values = Console.ReadLine().Split(' '); // lendo a linha, recortando baseada no espaço em branco, e guardando no vetor values

                for (int j = 0; j < n; j++) { // percorrer colunas da matriz
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i,i] + " ");
            }

            Console.WriteLine();

            int count = 0;
            for ( int i = 0; i < n; i++) { // estrutura basica para percorrer matriz inteira

                for (int j = 0; j < n; j++) {
                    if (mat[i,j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative Numbers: " + count);

        }
    }
}
