using System;
using ClasseInterface;

namespace ExemploInterface {
    class Program {
        static void Main (string[] args) {
            Produto pr = new Produto () {
                Id = 30,
                Nome = "Sabão",
                Descricao = "Em pó",
                Preco = 30
            };
            Console.WriteLine (pr.Cadastro ());
        }
    }
}