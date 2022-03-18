using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Pessoal.conection
{
    public class conexao
    {
        MySqlConnection cn = new MySqlConnection("Server=localhost; DataBase=Projeto_Pessoal; User=root; pwd=admin123");

        public static string msg;
        public MySqlConnection MyConectarBD() //Método: MyConectarBD()
        {

            try //
            {
                cn.Open();
            }

            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return cn;
        }


        public MySqlConnection MyDesConectarBD()  //Método: MyDesConectarBD()
        {
            try
            {
                cn.Close();
            }

            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return cn;
        }

    }
}