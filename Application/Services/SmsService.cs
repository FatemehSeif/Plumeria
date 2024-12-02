using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SmsService
    {
        public async Task Send(string phoneNumber, string code)
        {
            // ایجاد آدرس پایه API ملی پیامک
            Uri apiBaseAddress = new Uri("https://console.melipayamak.com");

            // استفاده از HttpClient برای ارسال درخواست
            using (HttpClient client = new HttpClient { BaseAddress = apiBaseAddress })
            {
                // ارسال درخواست به API با استفاده از روش POST و پارامترهای ورودی
                var result = await client.PostAsJsonAsync("api/send/otp/cc77e0d415a146979443e51e93e39f67", new
                {
                    to = phoneNumber,  // شماره تلفن گیرنده
                    code = code        // کد تایید
                });

                // خواندن پاسخ API
                var response = await result.Content.ReadAsStringAsync();

                // مدیریت پاسخ یا خطا
                if (result.IsSuccessStatusCode)
                {
                    Console.WriteLine("پیام با موفقیت ارسال شد");
                }
                else
                {
                    Console.WriteLine($"خطا در ارسال پیام: {response}");
                }
            }
        }

    }
}
