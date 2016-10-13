using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double numberA
        {
            get
            {
                return this._numberA;
            }
            set { this._numberA = value; }
        }

        public double numberB
        {
            get { return this._numberB; }
            set { this._numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return this.numberA + this.numberB;
        }
    }

    class OperationSub : Operation
    {
        public override double GetResult()
        {
            return numberA - numberB;
        }
    }

    class OperationMul : Operation
    {
        public override double GetResult()
        {
            return numberA * numberB;
        }
    }

    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (numberB == 0)
            {
                throw new Exception("NumberB Can not be 0");
            }
            return numberA / numberB;
        }
    }


    public class OperationFactory
    {
        public static Operation CreateOperation(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }
            return oper;
        }
    }
    
}
