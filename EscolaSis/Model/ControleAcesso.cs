using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EscolaSis.Model
{
    class ControleAcesso
    {
        public bool SenhaAutentica { get; }
        public string MensagemRetorno { get; set; }

        public ControleAcesso(string usuario, string senha)
        {
            // burcar usuario e senha no banco
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Senha FROM ControleAcesso WHERE " +
                "Usuario = @Usuario";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Usuario", usuario);

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                // Usuário padrão: Admin
                // Senha padrão: AdminSistem
                string senhaCadastrada = dt.Rows[0]["Senha"].ToString();
                string senhaPassada = EncriptaSenha(senha);
                if (senhaCadastrada == senhaPassada)
                {
                    SenhaAutentica = true;
                    MensagemRetorno = "Usuário autenticado com sucesso.";
                }
                else
                {
                    SenhaAutentica = false;
                    MensagemRetorno = "Senha inválidade.";
                }
            }
            else
            {
                SenhaAutentica = false;
                MensagemRetorno = "Usuário não localizado.";
            }

        }
        public void MudarSenha(string usuario, string senha)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE ControleAcesso SET Senha = @Senha " +
                "WHERE Usuario = @Usuario";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Senha", EncriptaSenha(senha));
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            DB.ExecCommand(cmd);
            MensagemRetorno = "Senha trocada com sucesso!";
        }
        private string EncriptaSenha(string senha)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(senha);
            byte[] inArray = System.Security.Cryptography.HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }
    }
}
