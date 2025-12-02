using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClasses
{
    internal class Report
    {
        private List<ReportRow> rows_ = new List<ReportRow>();

        public void AddRecord(ReportRow row)
        {
            rows_.Add(row);
        }

        public string ConvertRowToString(ReportRow row)
        {
            return row.Product + ";" + row.Quantity + ";" + row.Price;
        }


        public void ToString()
        {
            foreach (ReportRow row in rows_)
            {
                Console.Write(ConvertRowToString(row) + "\n");
            }
        }

        public void CalculateSum()
        {
            double sum = 0;
            foreach (ReportRow row in rows_)
            {
                sum += row.Quantity * row.Price;
            }
            Console.WriteLine("Сумма:" + sum);
        }
    }
}
