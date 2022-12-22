using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Shablon1
{
    internal class Salary_account : Account, ICalculateInterest
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
