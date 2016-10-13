using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    class DecoratorOrigin
    {
    }


    abstract class Component
    {
        public abstract void Operation();
    }

    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Specific object operation");
        }
    }

    abstract class Decorator : Component
    {
        protected Component component;
        
        public void SetComponent(Component comp)
        {
            this.component = comp;
        }

        public override void Operation()
        {
            if(this.component != null)
            {
                component.Operation();
            }
        }
    }

    class ConcreteDecoratorA : Decorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("object A Operation");
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehaviour();
            Console.WriteLine("object B Operation");
            
        }

        private void AddedBehaviour()
        {

        }
    }

}
