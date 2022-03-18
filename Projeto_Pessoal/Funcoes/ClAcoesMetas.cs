using MySql.Data.MySqlClient;
using Projeto_Pessoal.conection;
using Projeto_Pessoal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Pessoal.Funcoes
{
    public class ClAcoesMetas
    {
        conexao con = new conexao();
        public void InserirMetas(ClMetas cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbMeta(Codigo, Titulo, Data_Inicial, Data_Final, Descricao) values (Codigo, @Titulo, @Data_Inicial, @Data_Final, @Descricao)", con.MyConectarBD());

            cmd.Parameters.Add("Codigo", MySqlDbType.VarChar).Value = cm.Codigo;
            cmd.Parameters.Add("@Titulo", MySqlDbType.VarChar).Value = cm.Titulo;
            cmd.Parameters.Add("@Data_Inicial", MySqlDbType.VarChar).Value = cm.Data_Inicial;
            cmd.Parameters.Add("@Data_Final", MySqlDbType.VarChar).Value = cm.Data_Final;
            cmd.Parameters.Add("@Descricao", MySqlDbType.VarChar).Value = cm.Descricao;

            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();
        }
    }
}