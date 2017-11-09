using System;
using System.IO;

namespace ProjetoEvento.ClassePai.ClassesFilhas {
    public class Show : Evento {
        public string Artista { get; set; }
        public string GeneroMusical { get; set; }

        public Show () { }

        public Show (string titulo, string local, int lotacao, string duracao, int classificacao, DateTime data, string artista, string generomusical) {
            base.Titulo = titulo;
            base.Local = local;
            base.Lotacao = lotacao;
            base.Duracao = duracao;
            base.Classificacao = classificacao;
            base.Data = data;
            this.Artista = artista;
            this.GeneroMusical = generomusical;
        }
        public override bool Cadastrar () {
            bool efetuado = false;
            StreamWriter sw = null;
            FileInfo fi = new FileInfo ("_Show.csv");

            try {
                if (fi.Length == 0) {
                    sw = new StreamWriter ("_Show.csv", true);
                    sw.WriteLine ("Titulo;Local;Duracao;Data;Artista;GeneroMusical;Lotacao;Classificacao");
                    sw.WriteLine (Titulo + ";" + Local + ";" + Duracao + ";" + Data + ";" + Artista + ";" + GeneroMusical + ";" + Lotacao + ";" + Classificacao);
                } else {
                    sw = new StreamWriter ("_Show.csv", true);
                    sw.WriteLine (Titulo + ";" + Local + ";" + Duracao + ";" + Data + ";" + Artista + ";" + GeneroMusical + ";" + Lotacao + ";" + Classificacao);
                }
                efetuado = true;
            } catch (Exception ex) {
                throw new Exception ("Erro ao manipular arquivo: " + ex.Message);
            } finally {
                sw.Close ();
            }
            return efetuado;
        }
    }
}