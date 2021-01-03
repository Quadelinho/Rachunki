using Rachunki.DBContext;
using Rachunki.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachunki.Controller
{
    public class BillsProcessor : IDisposable
    {
        public Bill[] GetUnpaidBills()
        {
            Bill[] billsToReturn = new Bill[0];
            using (var context = new DatabaseContext())
            {
                var now = DateTime.Now.ToShortDateString();
                billsToReturn = context.Bills.Where(b => b.IsPaid == 0)
                    .OrderBy(b => b.PaymentDate).ToArray()
                    .Where(b => b.IsPaid == 0 && DateTime.Parse(b.PaymentDate) <= DateTime.Now).ToArray();
            }

            return billsToReturn;
        }

        public Bill[] GetIncommingBills()
        {
            Bill[] billsToReturn = new Bill[0];
            
            using (var context = new DatabaseContext())
            {
                DateTime now = DateTime.Now;
                DateTime todayDate = new DateTime(now.Year, now.Month, now.Day);
                string todayDateString = todayDate.ToShortDateString();
                string week = todayDate.AddDays(7).ToShortDateString();
                billsToReturn = context.Bills
                     .Where(b => b.IsPaid == 0)
                     .OrderBy(b => b.PaymentDate).ToArray()
                     .Where(b => DateTime.Parse(b.PaymentDate) >= todayDate && DateTime.Parse(b.PaymentDate) <= todayDate.AddDays(7))
                     .ToArray();
            }

            return billsToReturn;
        }

        public void CreateNewInstancesOfBills()
        {
            using (var context = new DatabaseContext())
            {
                //foreach (Bill billEntry in context.Bills.Select(b => b.Label))
                //{
                    
                //}
            }
            //for each Label create a new instance for the next payment (if not exist)
        }

        public string GetNextPaymentDate(string recentDate, int monthsToAdd)
        {
            return DateTime.Parse(recentDate)
                .AddMonths(monthsToAdd)
                .ToShortDateString();
        }

        public string[] GetBillsLabels(bool sort)
        {
            using (var context = new DatabaseContext())
            {
                var labels = context.Bills.Select(b => b.Label).Distinct().ToArray<string>();
                if (sort)
                {
                    Array.Sort(labels, StringComparer.Create(CultureInfo.CurrentCulture, true));
                }
                return labels;
                //return sort ? context.Bills.Select(b => b.Label).Distinct().OrderBy(label => label, StringComparer.Create(new System.Globalization.CultureInfo("pl_PL"), true)).ToArray<string>() :
                //return sort ? context.Bills.Select(b => b.Label).Distinct().OrderBy(label => label, StringComparer.Create(CultureInfo.CurrentCulture, true)).ToArray<string>() :
                //    context.Bills.Select(b => b.Label).Distinct().ToArray<string>();
            }
        }

        public Bill GetBillEntry(string label)
        {
            using (var context = new DatabaseContext())
            {
                return context.Bills.Where(b => b.Label == label).OrderByDescending(b => b.PaymentDate).FirstOrDefault();
            }
        }

        public List<Bill> GetBillsForLabel(string label)
        {
            List<Bill> bills;
            using (var context = new DatabaseContext())
            {
                bills = context.Bills.Where(b => b.Label == label).OrderByDescending(b => b.PaymentDate).ToList();
            }
            return bills != null ? bills : new List<Bill>();
        }

        public bool MarkBillAsPaid(int id)
        {
            bool success = false;
            using (var context = new DatabaseContext())
            {
                Bill entry = context.Bills.FirstOrDefault(b => b.Id == id);
                if(entry != null)
                {
                    entry.IsPaid = 1;
                    context.SaveChanges();
                    success = true;
                }
            }
            return success;
        }

        public void UpdateBill(Bill entryToUpdate)
        {
            using (var context = new DatabaseContext())
            {
                Bill entry = context.Bills.FirstOrDefault(b => b.Id == entryToUpdate.Id);
                if (entry != null)
                {
                    context.Entry<Bill>(entry).CurrentValues.SetValues(entryToUpdate);
                    context.SaveChanges();
                }
            }
        }

        public void Dispose()
        {
            
        }
    }
}
