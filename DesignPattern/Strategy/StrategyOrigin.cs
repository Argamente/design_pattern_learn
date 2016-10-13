using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class StrategyOrigin
    {
    }

    abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }

    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Algorithm A");
        }
    }

    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Algorithm B");
        }
    }


    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Algorithm C");
        }
    }

    
    class Context
    {
        Strategy strategy;
        public Context(Strategy _strategy)
        {
            this.strategy = _strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }

}
