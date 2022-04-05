using System;

namespace BoxUnboxing {
    internal class Program {
        static void Main(string[] args) {
                        
            // Exemplo de Boxing: Processo de conversão de um objeto do tipo valor para um objeto tipo referência compatível.
            int x = 20;
            Object obj = x;
            // Nesse caso, x é do tipo valor e é criado na Stack.
            // Já o obj é do tipo Object, que é uma classe, sendo portanto, do tipo referência, sendo criado no heap. 

            // Exemplo de Unboxing: Processo de conversão de um objeto tipo referência para um objeto do tipo valor compatível.
            int y = (int) obj;
        }
    }
}
