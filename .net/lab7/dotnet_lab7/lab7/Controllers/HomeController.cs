using lab7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;

namespace lab7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (StreamWriter sw = new StreamWriter("counter.txt", false))
            {
                sw.WriteLine("6");
            }
            return View(new MainModel());
        }

        public IActionResult Privacy()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public IActionResult Index(MainModel data)
        {
            if (data.LastName != null && data.FirstName != null && data.MiddleName != null && data.Email != null)
            {
                string result = data.LastName.Replace("а", "").Replace("о", "");
                bool emailtest = IsValidEmail(data.Email);
                ViewData["result"] = $"Форматоване прізвище: {result}";
                ViewData["emailtest"] = $"Чи є текст в поле email адресою: {emailtest}";
                return View(data);
            }
            else ViewData["result"] = $"Не всі поля заповнені!"; return View(data);
        }
        [HttpPost]
        public IActionResult Privacy(LoginModel data)
        {
            string loginFilePath = "login.txt";
            string passwordFilePath = "password.txt";

            string expectedLogin = data.Login;
            string expectedPassword = data.Password;

            string loginFromFile = ReadFromFile(loginFilePath);
            string passwordFromFile = ReadFromFile(passwordFilePath);

            if (loginFromFile == expectedLogin && passwordFromFile == expectedPassword)
            {
                ViewData["result"] = "Вхід виконано";
            }
            else 
            {
                int counter = int.Parse(ReadFromFile("counter.txt"));
                if (counter == 1)
                {
                    ViewData["result"] = "Спробуйте пізніше";
                }
                else
                {
                    counter--;
                    ViewData["result"] = "Дані входу невірні";
                    ViewData["counter"] = $"Залишилось спроб: {counter}";
                }
                using (StreamWriter sw = new StreamWriter("counter.txt", false)) // false вказує на перезапис файлу
                {
                    sw.WriteLine(counter);
                }

            }
            return View(data);
        }
        private string ReadFromFile(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                return sr.ReadLine();
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}