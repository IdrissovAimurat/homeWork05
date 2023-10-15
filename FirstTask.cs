using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork05
{
    /// <summary>
    /// 1.	Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, 
    ///     что произошла ошибка. Программа должна завершиться без ошибок.
    /// </summary>
    public class FirstTask
    {
        /// <summary>
        /// Я не знал как сделать задачу нормально, поэтому спросил у чата, я надеюсь, что вы не разочаровались во мне
        /// в качестве никак в программиста, а как в армянина... Да, я согрешил, так не знал как правильно сделать(
        /// </summary>
      
        public void WebRequest(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string response = client.DownloadString(url);
                    Console.WriteLine("Результат запроса" + response);
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    HttpWebResponse response = (HttpWebResponse)ex.Response;
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        Console.WriteLine("Произошла ошибка: Страница не найдена (HTTP 404)");
                    }
                    else
                    {
                        Console.WriteLine("Произошла другая ошибка HTTP: " + response.StatusDescription);
                    }
                }
                else
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла общая ошибка: " + ex.Message);
            }
        }
    }
}
