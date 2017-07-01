using DAL;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class AutenticacaoBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Autentica o usuario
        public int AutenticarUsuario(string login, string senha)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Login", login);
                acesso.AdicionarParametros("@Senha", senha);
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
        public string RecuperarUsuario(string email)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Email", email);
                DataTable dataTableRecupera = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspLoginRecuperar");
                if (dataTableRecupera.Rows.Count == 0)
                {
                    return "O Email informado não possui cadastro no sistema.";
                }
                else
                {
                    return EnviarEmail(email, Convert.ToString(dataTableRecupera.Rows[0][0]), Convert.ToString(dataTableRecupera.Rows[0][1]));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Envia Email para o usuario
        private string EnviarEmail(string email, string login, string senha)
        {
            try
            {
                SmtpClient cliente = new SmtpClient();
                cliente.Host = "smtp.gmail.com";
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential("Essentialstech@Gmail.com", "etecteam123");
                MailMessage mail = new MailMessage();
                mail.Sender = new MailAddress("Essentialstech@Gmail.com", "ETi Library");
                mail.From = new MailAddress("Essentialstech@Gmail.com", "ETi Library");
                mail.To.Add(new MailAddress(email, "Usuário"));
                mail.Subject = "Recuperação de Conta";
                mail.Body = " Essentials Technology - Trabalhando Idéias. <br/> Email : " + "suporte@essentialstech.com.br" + "<br/>" + "Foi solicitada a recuperação de sua conta:<br/>" + "Login : " + login + "<br>   Senha : " + senha;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                cliente.Send(mail);
                return "Dados do usuario enviado para o email solicitado.";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Validar Email
        public bool ValidarEmail(string email)
        {
            try
            {
                try
                {
                    var mail = new MailAddress(email);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Validar CPF
        public bool ValidarCPF(string cpf)
        {
            try
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf, digito;
                int soma, resto;

                tempCpf = cpf.Substring(0, 9);
                soma = 0;
                for (int cont = 0; cont < 9; cont++)
                {
                    soma += int.Parse(tempCpf[cont].ToString()) * multiplicador1[cont];
                }
                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int cont = 0; cont < 10; cont++)
                {
                    soma += int.Parse(tempCpf[cont].ToString()) * multiplicador2[cont];
                }
                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito = digito + resto.ToString();
                return cpf.EndsWith(digito);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Criptografar Senha
        public string CripSenha(string txtBase)
        {
            try
            {
                byte[] resultado, chaveAlg, bitsTxtPuro;

                UTF8Encoding UTF8 = new UTF8Encoding();
                MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
                chaveAlg = HashProvider.ComputeHash(UTF8.GetBytes("122628"));
                TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
                TDESAlgorithm.Key = chaveAlg;
                TDESAlgorithm.Mode = CipherMode.ECB;
                TDESAlgorithm.Padding = PaddingMode.PKCS7;
                bitsTxtPuro = UTF8.GetBytes(txtBase);
                try
                {
                    ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                    resultado = Encryptor.TransformFinalBlock(bitsTxtPuro, 0, bitsTxtPuro.Length);
                }
                finally
                {
                    TDESAlgorithm.Clear();
                    HashProvider.Clear();
                }
                return Convert.ToBase64String(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }          
        }
        //Descriptografar Senha
        public string DescripSenha(string txtBase)
        {
            try
            {
                byte[] resultado, chaveAlg, bitsTxtPuro;

                UTF8Encoding UTF8 = new UTF8Encoding();
                MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
                chaveAlg = HashProvider.ComputeHash(UTF8.GetBytes("122628"));
                TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
                TDESAlgorithm.Key = chaveAlg;
                TDESAlgorithm.Mode = CipherMode.ECB;
                TDESAlgorithm.Padding = PaddingMode.PKCS7;
                bitsTxtPuro = Convert.FromBase64String(txtBase);
                try
                {
                    ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                    resultado = Decryptor.TransformFinalBlock(bitsTxtPuro, 0, bitsTxtPuro.Length);
                }
                finally
                {
                    TDESAlgorithm.Clear();
                    HashProvider.Clear();
                }
                return UTF8.GetString(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }          
        }
    }
}
