using Simple_Factory_Pizza.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory_Pizza
{
    class PizzaStore
    {
        SimpleFactory factory;
        public PizzaStore(SimpleFactory fac)
        {
            factory = fac;
        }

        public Pizza orderPizza(String type)
        {
            Pizza pizza;

            pizza = factory.createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
