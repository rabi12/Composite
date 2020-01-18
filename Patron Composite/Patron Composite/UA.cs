using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Composite
{
    public class UA : IComponent
    {
        string id;
        List<IComponent> lista;

        public UA(string id)
        {
            this.id = id;
            lista = new List<IComponent>();
        }

        public decimal getTotal()
        {
            decimal result = 0;

            foreach (IComponent component in lista)
            {
                result += component.getTotal();
            }
            Console.WriteLine("Resultado UA "+ id +":"+result);
            return result;
        }

        public void agregarComponente(IComponent componente)
        {
            this.lista.Add(componente);
        }
    }
}
