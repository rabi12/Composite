using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Composite
{
    public class Cliente
    {
        public void Main()
        {
            UA ua = new UA("1");
            CP cp1 = new CP(1,100,100,100,100);
            CP cp2 = new CP(2, 100, 100, 100, 100);
            CP cp3 = new CP(3, 100, 100, 100, 100);
            ClavePresupuestal clavePresupuestal = new ClavePresupuestal();
            clavePresupuestal.setCP(cp1);
            ClavePresupuestal clavePresupuestal2 = new ClavePresupuestal();
            clavePresupuestal2.setCP(cp2);
            ClavePresupuestal clavePresupuestal3 = new ClavePresupuestal();
            clavePresupuestal3.setCP(cp3);
            ua.agregarComponente(clavePresupuestal);
            ua.agregarComponente(clavePresupuestal2);
            ua.agregarComponente(clavePresupuestal3);

            UA ua2 = new UA("2");
            CP cp4 = new CP(1, 200, 100, 100, 100);
            CP cp5 = new CP(2, 200, 100, 100, 100);
            CP cp6 = new CP(3, 200, 100, 100, 100);
            ClavePresupuestal clavePresupuestal4 = new ClavePresupuestal();
            clavePresupuestal4.setCP(cp4);
            ClavePresupuestal clavePresupuestal5 = new ClavePresupuestal();
            clavePresupuestal5.setCP(cp5);
            ClavePresupuestal clavePresupuestal6 = new ClavePresupuestal();
            clavePresupuestal6.setCP(cp6);
            ua2.agregarComponente(clavePresupuestal4);
            ua2.agregarComponente(clavePresupuestal5);
            ua2.agregarComponente(clavePresupuestal6);

            var resultado=ua.getTotal();
            var resultado2 = ua2.getTotal();

            //Console.WriteLine(resultado);
        }
    }
}
