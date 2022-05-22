using System;
using System.Collections.Generic;

namespace _27_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uyarı Mesajları
            // Success : yeşil, başarı
            // Info : mavi, bilgilendirme
            // Warning : turuncu/sarı, uyarı,
            // Error : kırmızı, hata

            Success success=new Success();
            success.Message = "Müşteri başarılı şekilde kaydedildi.";
            //success.WriteMessage();
            //success.WriteMessage("Müşteri başarılı şekilde kaydedildi.");

            Error error=new Error();
            error.Message = "Hata oluştu. Müşteri kaydedilemedi.";

            Warning warning=new Warning();
            warning.Message= "Müşteri bilgisi eksik lütfen tamamlayınız.";

            Info info=new Info();
            info.Message="Sistemde 10 adet müşteri kaydı bulunur.";

            List<INotify> notifies=new List<INotify>();
            notifies.Add(success);
            notifies.Add(error);
            notifies.Add(warning); 
            notifies.Add(info);

            foreach (INotify item in notifies)
            {
                Console.Write(item.GetType().ToString()+" : " );    
                item.WriteMessage();
            }
        }
    }

    public interface INotify: INotifyExtended //İnterface'e yetni bir interface ile yetenek kazandırdık. Bir interface diğer bir interface'ten türeyebilir.
    {
        void WriteMessage(string message);
    }

    public interface INotifyExtended
    {
        string Message { get; set; }
        void WriteMessage();  
    }

    public class Success : INotify
    {
        public string Message { get; set; }
        public void WriteMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-->" + Message);
            Console.ResetColor();
        }
        public void WriteMessage(string message) //Burada method yazdık. Success clasının ne iş yapacapını anlatmak için
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-->" + message);
            Console.ResetColor();   
        }

       
    }
    public class Error : INotify
    {
        public string Message { get; set; }
        public void WriteMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("@@@ " + Message);
            Console.ResetColor();
        }

        public void WriteMessage(string message) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("@@@ " + message);
            Console.ResetColor ();
        }

       
    }
    public class Warning : INotify
    {
        public string Message { get; set; }
        public void WriteMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("!!!" + Message);
            Console.ResetColor();
        }

        public void WriteMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("!!!" + message);
            Console.ResetColor();
        }

    }
    public class Info : INotify
    {
        public string Message { get; set; }
        public void WriteMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("..." + Message);
            Console.ResetColor();
        }
        public void WriteMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("..." + message);
            Console.ResetColor();
        }

       
    }
}
