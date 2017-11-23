using System;
using System.Security.Cryptography;
using System.Text;

namespace SysLog {
    class Program {
        static void Main (string[] args) {
            string op = "";
            string usuario = "";
            string senha = "";
            Usuario us = new Usuario ();

            do {
                Console.WriteLine ("Escolha uma das opções");
                Console.WriteLine ("1 - Cadastro\n2 - Logar\n9 - Sair");
                op = Console.ReadLine ();

                switch (op) {
                    case "1":
                        Console.Write ("Digite o usuário: ");
                        usuario = Console.ReadLine ();
                        Console.Write ("Digite a senha: ");
                        senha = Console.ReadLine ();
                        Console.WriteLine (us.Cadastrar (usuario, senha));
                        break;

                    case "2":
                        Console.Write ("Digite o usuário: ");
                        usuario = Console.ReadLine ();
                        Console.Write ("Digite a senha: ");
                        senha = Console.ReadLine ();
                        Console.WriteLine (us.Logar (usuario, senha));

                        break;

                    default:
                        break;
                }
            } while ((op) != "9");
        }
    }
}