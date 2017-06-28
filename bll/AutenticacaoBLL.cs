using DAL;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace BLL
{
    public class AutenticacaoBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Autentica o usuario
        public int AutenticarUsuario(string Login, string Senha)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Login", Login);
                acesso.AdicionarParametros("@Senha", Senha);
                DataTable dataTableAutentica = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspLoginValidar");
                if (dataTableAutentica.Rows.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt32(dataTableAutentica.Rows[0]["CodFuncionario"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Recupera login e senha do usuario
        public string RecuperarUsuario(string Email)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Email", Email);

                DataTable dataTableRecupera = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspLoginRecuperar");

                if (dataTableRecupera.Rows.Count == 0)
                {
                    return "O Email informado não possui cadastro no sistema.";
                }
                else
                {
                    return EnviarEmail(Email, Convert.ToString(dataTableRecupera.Rows[0][0]), Convert.ToString(dataTableRecupera.Rows[0][1]));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Envia Email para o usuario
        private string EnviarEmail(string Email, string Login, string Senha)
        {
            try
            {
                SmtpClient cliente = new SmtpClient();
                cliente.Host = "smtp.gmail.com";
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential("Essentialstech@Gmail.com", "etecteam123");
                MailMessage email = new MailMessage();
                email.Sender = new MailAddress("Essentialstech@Gmail.com", "ETi Library");
                email.From = new MailAddress("Essentialstech@Gmail.com", "ETi Library");
                email.To.Add(new MailAddress(Email, "Usuário"));
                email.Subject = "Recuperação de Conta";
                email.Body = " Essentials Technology - Trabalhando Idéias. <br/> Email : " + "suporte@essentialstech.com.br" + "<br/>" + "Foi solicitada a recuperação de sua conta:<br/>" + "Login : " + Login + "<br>   Senha : " + Senha;
                email.IsBodyHtml = true;
                email.Priority = MailPriority.High;
                cliente.Send(email);
                return "Dados do usuario enviado para o email solicitado.";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
