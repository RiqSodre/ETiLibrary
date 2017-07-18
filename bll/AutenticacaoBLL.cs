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
        //Variaveis para os métodos de criptografia
        private static byte[] bIV = {0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18,
        0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC};
        private const string chaveAlg ="Q3JpcHRvZ3JhZmlhcyBjb20gUmluamRhZWwgLyBBRVM=";

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
                    return EnviarEmail(email, Convert.ToString(dataTableRecupera.Rows[0][0]), DecripSenha(Convert.ToString(dataTableRecupera.Rows[0][1])));
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
                    if(!(email.Contains(".")) || email.Contains(" "))
                    {
                        return false;
                    }
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
        //Encripta a senha
        public string CripSenha(string txtPuro)
        {
            try
            {              
                byte[] bChave = Convert.FromBase64String(chaveAlg);
                byte[] bTxt = new UTF8Encoding().GetBytes(txtPuro);
                Rijndael rijndael = new RijndaelManaged();                
                rijndael.KeySize = 256;               
                MemoryStream mStream = new MemoryStream();
                CryptoStream encryptor = new CryptoStream(mStream, rijndael.CreateEncryptor(bChave, bIV),
                    CryptoStreamMode.Write);
                encryptor.Write(bTxt, 0, bTxt.Length);
                encryptor.FlushFinalBlock();               
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }     
        //Decripta a senha
        public string DecripSenha(string txtCifrado)
        {
            try
            {               
                    byte[] bChave = Convert.FromBase64String(chaveAlg);
                    byte[] bTxt = Convert.FromBase64String(txtCifrado);             
                    Rijndael rijndael = new RijndaelManaged();              
                    rijndael.KeySize = 256;               
                    MemoryStream mStream = new MemoryStream();    
                    CryptoStream decryptor = new CryptoStream(mStream, rijndael.CreateDecryptor(bChave, bIV),
                        CryptoStreamMode.Write);  
                    decryptor.Write(bTxt, 0, bTxt.Length);     
                    decryptor.FlushFinalBlock();        
                    UTF8Encoding utf8 = new UTF8Encoding();       
                    return utf8.GetString(mStream.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
