using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachunki.Model
{
    public class Bill
    {
        public int Id { get; set; }
        public string PaymentDate { get; set; }
        public string Label { get; set; }
        public int Frequency { get; set; }
        public int IsPaid { get; set; }
        public decimal Value { get; set; }
        public string MarkedAsPaidDate { get; set; }
    }
}
