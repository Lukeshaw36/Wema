using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.Bit.Model
{
    public class Payments
    {
        public int PaymentId { get; set; }
        public int UserId { get; set; } 
        public int PayAmount { get; set; }    
    }
}
