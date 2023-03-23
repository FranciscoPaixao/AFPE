namespace AFPE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };
            int[] vetorOrdenado = OrdenaVetor(vetor);
            Console.WriteLine("Maior valor: " + vetorOrdenado[vetorOrdenado.Length - 1]);
            Console.WriteLine("Menor valor: " + vetorOrdenado[0]);
            Console.WriteLine("Média da soma dos valores: " + MediaDaSoma(vetorOrdenado));
            Console.WriteLine("3 maiores valores: " + TresMaioresValores(vetorOrdenado));
            Console.WriteLine("Valores negativos: " + ValoresNegativos(vetorOrdenado));
            Console.WriteLine("Valores ordenados: " + ExibirValores(vetorOrdenado));
            Console.WriteLine("Valor removido: " + RemoverValor(ref vetorOrdenado));
        }
        private static int MediaDaSoma(int[] vetor)
        {
            int resultado = 0;
            for(int i = 0; i < vetor.Length; i++) {
                resultado += vetor[i];
            }
            return resultado;
        }
        private static String TresMaioresValores(int[] vetor)
        {
            String resultado = "";
            for(int i = vetor.Length-3; i < vetor.Length; i++)
            {
                resultado += vetor[i] + ", ";
            }
            return resultado;
        }
        private static String ValoresNegativos(int[] vetor)
        {
            String resultado = "";
           for (int i = 0; i < vetor.Length - (vetor.Length - 3); i++)
            {
                if (vetor[i] < 0)
                {
                    resultado += vetor[i] + ", ";
                }
            }
            return resultado;
        }

        private static String ExibirValores(int[] vetor)
        {
            String resultado = "";
            for (int i = 0; i < vetor.Length; i++)
            {
                resultado += vetor[i] + ", ";
            }
            return resultado;
        }

        private static int RemoverValor(ref int[] vetorOrdenado)
        {
            Random removerNumero = new Random();
            int numeroRemovido = removerNumero.Next(vetorOrdenado[0], vetorOrdenado.Length);
            var listaNumeros = vetorOrdenado.ToList();
            listaNumeros.Remove(numeroRemovido);
            vetorOrdenado = listaNumeros.ToArray();
            return numeroRemovido;
        }

        public static int[] OrdenaVetor(int[] vetor)
        {
            int aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 1; j < vetor.Length; j++)
                {
                    if (vetor[j - 1] > vetor[j])
                    {
                        aux = vetor[j - 1];
                        vetor[j - 1] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }

            return vetor;
        }
    }
}