using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6Prac
{

    class Program
    {
        static void Main()
        {
            Console.Write("Введите название города: ");
            string city = Console.ReadLine();
            string Link = $"https://api.openweathermap.org/data/2.5/weather?q={city}&lang=ru&appid=ad89a00dd8809a7615a83ab93e12560b&units=metric";
            HttpWebRequest RequestForWeather = (HttpWebRequest)WebRequest.Create(Link);
            HttpWebResponse ResponseAboutWeather = (HttpWebResponse)RequestForWeather.GetResponse();

            string unswerAbout;

            using (StreamReader streamReader = new StreamReader(ResponseAboutWeather.GetResponseStream()))
            {
                unswerAbout = streamReader.ReadToEnd();
            }
            AboutWeather resultInfo = JsonConvert.DeserializeObject<AboutWeather>(unswerAbout);

            Console.Write($"\nПогода в {resultInfo.Name}: \nТемпература: {resultInfo.Main.temp}°C " +
                          $"\nОщущается как: {resultInfo.Main.feels_like}" +
                          $"\nВетер {resultInfo.wind.speed} м/с, " +
                          $"{ resultInfo.Weather[0].description}\n");
        }
    }
}