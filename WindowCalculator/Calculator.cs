using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowCalculator
{
    class Calculator
    {
        private double firstNumber { get; set; }

        private double secondNumber { get; set; }


        public double calculatorResult()
        {
            return firstNumber + secondNumber;
        }

        public double calculatorResult()
        {
            return firstNumber - secondNumber;
        }

        public double calculatorResult()
        {
            return firstNumber * secondNumber;
        }
        public double calculatorResult()
        {
            return firstNumber / secondNumber;
        }

        public class AddCommand : Command
        {
            private Calculator _calculator;
            public AddCommand(Calculator calculator )
            {
                _calculator = calculator;
            }
            public override int Execute()
            {
                return _calculator.Add();
            }
        }
        public class SubtractCommand : Command
        {
            private Calculator _calculator;
            public SubtractCommand(Calculator calculator) :
            base(calculator)
            {
                _calculator = calculator;
            }
            public override int Execute()
            {
                return _calculator.Subtract();
            }
        }
        public class MultiplyCommand : Command
        {
            private Calculator _calculator;
            public MultiplyCommand(Calculator calculator) :
            base(calculator)
            {
                _calculator = calculator;
            }
            public override int Execute()
            {
                return _calculator.Multiply();
            }
        }
        public class DivideCommand : Command
        {
            private Calculator _calculator;
            public DivideCommand(Calculator calculator) :
            base(calculator)
            {
                _calculator = calculator;
            }
            public override int Execute()
            {
                return _calculator.Divide();
            }
        }


        public class user
        {
            private Command _command;
            public void SetCommand(Command command)
            {
                _command = command;
            }
            public int Execute()
            {
                return _command.Execute();
            }
        }
        

    }
}

