using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Composite
{
    public class CP
    {
        public int id { get; set; }
        public decimal totalEnero { get; set; }
        public decimal totalFebrero { get; set; }
        public decimal totalMarzo { get; set; }
        public decimal totalAbril { get; set; }

        public CP(int id, decimal totalEnero, decimal totalFebrero, decimal totalMarzo, decimal totalAbril)
        {
            this.id = id;
            this.totalEnero = totalEnero;
            this.totalFebrero = totalFebrero;
            this.totalMarzo = totalMarzo;
            this.totalAbril = totalAbril;
        }
    }
}
