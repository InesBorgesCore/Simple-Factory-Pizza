using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple_Factory_Pizza.Pizzas;

namespace Simple_Factory_Pizza.Pizzas
{
    class SimpleFactory
    {
        public Pizza createPizza(String type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
