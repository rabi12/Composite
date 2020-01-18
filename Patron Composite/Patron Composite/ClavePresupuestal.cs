using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Composite
{
    public class ClavePresupuestal : IComponent
    {
        private CP clavePresupuestal;
        
        public void setCP(CP clavePresupuestal)
        {
            this.clavePresupuestal = clavePresupuestal;
        }
        public decimal getTotal()
        {
            return clavePresupuestal.totalEnero + clavePresupuestal.totalFebrero + 
                clavePresupuestal.totalMarzo + clavePresupuestal.totalAbril;
        }
    }
}
