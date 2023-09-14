// See https://aka.ms/new-console-template for more information
using Agenda.Messages.Services;
using System.Net;
using System.Net.Mail;
using System.Text;
using AE.Net.Mail;

namespace TesteEnvioEmail;
class Program
{
    static ImapClient imapClient;
    static string username = "convisa2023@gmail.com"; //"inscricoes@convisario.com.br";
    static string password = "!viS@2022At!"; //"Ivisa@76528";

    static void Main(string[] args)
    {
        #region SendMail

        //string to = "marcoscariaga@gmail.com";
        //string subject = "Teste de Envio de Email";
        //StringBuilder htmlString = new StringBuilder();
        //htmlString.Append("<html>");
        //htmlString.Append("<body>");
        //htmlString.Append("<div>");
        //htmlString.Append($"<p>Olá <strong>{to}</strong>, sua inscrição no CONVISA-RIO 2023 foi feita com sucesso.</p>");
        //htmlString.Append("<p></p>");
        //htmlString.Append("<p>Atenciosamente,</p>");
        //htmlString.Append("<p>Equipe CONVISA-RIO 2023</p>");
        //htmlString.Append("<img src = 'https://i.imgur.com/PWD7nBU.png' alt = 'Imagem' width = '500' />");
        //htmlString.Append("</div>");
        //htmlString.Append("</body>");
        //htmlString.Append("</html>");

        //EmailMessageService enviaEmail = new EmailMessageService();
        //enviaEmail.SendMessage(to, subject, htmlString.ToString());

        //Console.WriteLine("Email enviado!");

        #endregion

        #region ReadMail

        try
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            //ImapClient imapClient = new ImapClient("email-ssl.com.br", username, password, AuthMethods.Login, 993, true);
            ImapClient imapClient = new ImapClient("imap.gmail.com", username, password, AuthMethods.Login, 993, true);
            imapClient.SelectMailbox("INBOX");
            var email = imapClient.GetMessage(0);

            Console.WriteLine("Assunto: " + email.Subject);
            Console.WriteLine("RawHeaders: " + email.RawHeaders);
            Console.WriteLine("Headers: " + email.Headers);
            Console.WriteLine("Body: " + email.Body);
            Console.ReadLine();

        }
        catch(Exception ex)
        {
            throw new Exception("Erro: " + ex.Message);
        }

        #endregion

        Console.ReadLine();
    }
}




