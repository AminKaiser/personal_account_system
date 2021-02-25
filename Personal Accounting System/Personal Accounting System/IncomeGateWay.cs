using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Accounting_System
{
public class IncomeGateWay
    {
        private int sL_No;
        private string source_type;
        private int amount;
        private DateTime date;
        private int total;

        public int SL_No { get; set; }
        public string Source_type { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public int Total { get; set; }
    }
}
