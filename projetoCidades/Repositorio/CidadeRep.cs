using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using projetoCidades.Models;

namespace projetoCidades.Repositorio {
    public class CidadeRep {
        AcessaBD bd = new AcessaBD ();
        SqlCommand cmd;
        SqlDataReader rd;
        public List<Cidade> Listar () {
            List<Cidade> list = new List<Cidade> ();
            cmd = new SqlCommand ();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Cidades";
            cmd.Connection = bd.con;
            try {
                bd.Open ();
                rd = cmd.ExecuteReader ();

                while (rd.Read ()) {
                    Cidade cidade = new Cidade ();
                    cidade.Id = Convert.ToInt32 (rd["id"]);
                    cidade.Nome = rd["nome"].ToString ();
                    cidade.Estado = rd["estado"].ToString ();
                    cidade.Habitantes = Convert.ToInt32 (rd["habitantes"]);

                    list.Add (cidade);
                }
            } catch (SqlException se) {
                throw new Exception ("Erro ao manipular BD: " + se.Message);
            } catch (Exception ex) {
                throw new Exception ("Erro ao manipular BD: " + ex.Message);
            } finally {
                bd.Close ();
            }
            return list;
        }
        public void Cadastrar (Cidade cidade) {
            cmd = new SqlCommand ();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Cidades (nome, estado, habitantes) values (@nome, @estado, @habitantes);";
            cmd.Parameters.AddWithValue ("@nome", cidade.Nome);
            cmd.Parameters.AddWithValue ("@estado", cidade.Estado);
            cmd.Parameters.AddWithValue ("@habitantes", cidade.Habitantes);
            cmd.Connection = bd.con;
            try {
                bd.Open ();
                cmd.ExecuteNonQuery ();
                cmd.Parameters.Clear();
            } catch (SqlException se) {
                throw new Exception ("Erro ao manipular BD: " + se.Message);
            } catch (Exception ex) {
                throw new Exception ("Erro ao manipular BD: " + ex.Message);
            } finally {
                bd.Close ();
            }
        }
    }
}