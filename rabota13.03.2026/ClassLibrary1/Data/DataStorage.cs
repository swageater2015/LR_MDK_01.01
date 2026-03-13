using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data
{
    public class DataStorage
    {
        public List<Service> Services { get; private set; }

        public DataStorage()
        {
            Services = new List<Service>();

            var s1 = new Service { Name = "Стрижка", Price = 500 };
            s1.DailyStats.Add("Пн", 5); s1.DailyStats.Add("Вт", 3); s1.DailyStats.Add("Ср", 4);
            s1.DailyStats.Add("Чт", 6); s1.DailyStats.Add("Пт", 10); s1.DailyStats.Add("Сб", 15);
            s1.DailyStats.Add("Вс", 8);
            Services.Add(s1);

            var s2 = new Service { Name = "Окрашивание", Price = 2000 };
            s2.DailyStats.Add("Пн", 1); s2.DailyStats.Add("Вт", 2); s2.DailyStats.Add("Ср", 1);
            s2.DailyStats.Add("Чт", 2); s2.DailyStats.Add("Пт", 3); s2.DailyStats.Add("Сб", 4);
            s2.DailyStats.Add("Вс", 2);
            Services.Add(s2);

            var s3 = new Service { Name = "Маникюр", Price = 800 };
            s3.DailyStats.Add("Пн", 4); s3.DailyStats.Add("Вт", 5); s3.DailyStats.Add("Ср", 6);
            s3.DailyStats.Add("Чт", 5); s3.DailyStats.Add("Пт", 8); s3.DailyStats.Add("Сб", 10);
            s3.DailyStats.Add("Вс", 7);
            Services.Add(s3);
        }
    }
}
