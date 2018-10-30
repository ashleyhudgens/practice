using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class doWork
    {
        public void work()
        {
            var x = new PerformFileOperations();
            var y = new PerformArithmetic();

            x.readFile();
            y.getOperand(x);
            y.getTotal(x);
            x.writeToFile();
        }
    }
}
