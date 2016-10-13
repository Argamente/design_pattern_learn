using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Strategy;
using DesignPattern.Decorator;
using DesignPattern.ProxyPattern;
using DesignPattern.SimpleFactory;
using DesignPattern.FactoryMethod;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ////简单工厂模式
            //Operation oper;
            //oper = OperationFactory.CreateOperation("+");
            //oper.numberA = 1;
            //oper.numberB = 2;
            //double result = oper.GetResult();
            //Console.WriteLine(result);


            ////策略模式
            //Context context;
            //context = new Context(new ConcreteStrategyA());
            //context.ContextInterface();

            //context = new Context(new ConcreteStrategyB());
            //context.ContextInterface();


            ////装饰模式
            //ConcreteComponent c = new ConcreteComponent();
            //ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            //ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            //d1.SetComponent(c);
            //d2.SetComponent(d1);
            //d2.Operation();


            ////代理模式
            //SchoolGirl mm = new SchoolGirl();
            //mm.Name = "JiaoJiao";
            //Proxy daili = new Proxy(mm);
            //daili.GiveDolls();
            //daili.GiveFlowers();
            //daili.GiveChocolate();


            ////工厂方法模式
            //IFactory operFactory = new AddFactory();
            //Operation oper = operFactory.CreateOperation();
            //oper.numberA = 1;
            //oper.numberB = 2;
            //double result = oper.GetResult();
            //Console.WriteLine(result);
            


            Console.Read();
        }
    }
}
