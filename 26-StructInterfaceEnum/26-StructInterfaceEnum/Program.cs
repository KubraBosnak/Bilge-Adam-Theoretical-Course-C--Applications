using System;

namespace _26_StructInterfaceEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //StructSample();
            
            // interface li class ın kullanımı

            SMSSender smsSender = new SMSSender();
            smsSender.From = "0 538 024 96 88";
            smsSender.To = "0 534 279 08 09";
            smsSender.Subject = "Reklam";

            smsSender.Send();
            //enum kullanımı
            Console.ForegroundColor = ConsoleColor.Red; // ConsoleColor bir enumdur. Enumlar sabit değer listeleridir. Renkler gibi.

            Renkler renk1 = Renkler.Yesil;
            Renkler renk2 = Renkler.Kirmizi;

            Console.WriteLine((int)renk1);
            Console.WriteLine(renk2);

        }

        private static void StructSample()
        {
            //STRUCT 
            Structs exportExcelParameters = new Structs();
            exportExcelParameters.encoding = "utf-8";
            exportExcelParameters.fileFormat = "xls";

            ExportExcel(exportExcelParameters);
        }

        public static void ExportExcel(Structs parameters)
        {

        }

    }
    
    public enum Renkler
    {
        Mavi=100,
        Sari=101,
        Yesil=102,
        Beyaz=103,
        Kirmizi=104
    }
    public class SenderBase
    {
        public string TransactionId { get; set; }
    }

    public class SMSSender:IMessageSenderProps,IMessageSender
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }

        public void Send()
        {
            //SMS GÖNDERME KODLARI
        }
    }
    public class EmailSender : SenderBase, IMessageSenderProps,IMessageSender,IEmailMessageSenderProps, IEmailSmtpMessageSenderProps //interface class ının içinde yer alan propertylerin hepsini EmailSender class ının içine enjekte etmek zorunda bıraktı.
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }

    public class SmtpEmailSender : SenderBase, IMessageSender, IMessageSenderProps, IEmailMessageSenderProps
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }
    interface IMessageSenderProps    // Kod blokları ve access modifiersler interfacelerin içine yazılmaz
    {
        string From { get; set; }
        string To { get; set; }
        string Subject { get; set; }
    }

    interface IEmailMessageSenderProps
    {
        string Host { get; set; }
        int Port { get; set; }
   

    }

    interface IEmailSmtpMessageSenderProps
    {
        
        string Username { get; set; }
        string Password { get; set; }

    }
    interface IMessageSender 
    { 
        void Send(); 
    }
}
// INTERFACE NEDİR?
// 