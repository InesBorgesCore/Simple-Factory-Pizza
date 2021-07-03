using Simple_Factory_Pizza.Pizzas;
using System;

namespace Simple_Factory_Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFactory simpleFactory = new SimpleFactory();
            PizzaStore pizzaStore = new PizzaStore(simpleFactory);
            pizzaStore.orderPizza("cheese");
        }
    }
}
