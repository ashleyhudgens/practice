using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class PerformArithmetic : ISetupPerformArithmetic
    {
        public string operand { get; set; }
        public double total { get; set; }
        public void getOperand(PerformFileOperations x)
        {
            switch(x.typeOfArithmetic)
            {
                case "add":
                    operand = "+";
                    break;
                case "subtract":
                    operand = "-";
                    break;
                case "multiply":
                    operand = "*";
                    break;
                case "divide":
                    operand = "/";
                    break;
                default:
                    Console.Write("Unable to get operand");
                    break;
            }
        }

        public void getTotal(PerformFileOperations y)
        {
            if (y.typeOfArithmetic == "add")
            {
                total = y.firstOperand + y.secondOperand;
            }
            else if (y.typeOfArithmetic == "subtract")
            {
                total = y.firstOperand - y.secondOperand;
            }
            else if (y.typeOfArithmetic == "multiply")
            {
                total = y.firstOperand * y.secondOperand;
            }
            else if (y.typeOfArithmetic == "divide")
            {
                total = y.firstOperand / y.secondOperand;
            }
            else
            {
                Console.Write("Unable to calculate total");
            }
        }
    }
}
