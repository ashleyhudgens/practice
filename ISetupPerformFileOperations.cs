using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    interface ISetupPerformFileOperations
    {
        string readFromPath { get; set; }
        string[] variables { get; set; }
        string typeOfArithmetic { get; set; }
        double firstOperand { get; set; }
        double secondOperand { get; set; }
        string writeResultsPath { get; set; }
    }
}
