using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class PerformFileOperations : ISetupPerformFileOperations
    {
        //set up variables from interface
        public string readFromPath { get; set; }
        public string[] variables { get; set; }
        public string typeOfArithmetic { get; set; }
        public double firstOperand { get; set; }
        public double secondOperand { get; set; }
        public string writeResultsPath { get; set; }

        List<string> listOfTypesOfArithmetic = new List<string>();

        List<double> listOfFirstOperands = new List<double>();

        List<double> listOfSecondOperands = new List<double>();

        //sets up reading the file
        public void readFile()
        {
            //declare read from file path
            readFromPath = "C:\\Users\\ahudgens\\desktop\\testingfiles.txt";
            //verify file exists
            if (File.Exists(readFromPath) == true)
            {
                handleReadFile();
            } else {
                //write out error that file does not exist
                Console.WriteLine("Read from file path not accessible or file does not exist.");
            }
        }
        public void handleReadFile()
        {
            //declare reader to ingest file contents
            StreamReader reader = new StreamReader(readFromPath);
            string readLines;
            while ((readLines = reader.ReadLine()) != null)
            {
                //assign file contents to a string[] variable
                //get array of variables without comma separation
                variables = readLines.Split(',');
                if ((variables[0] == "add") || (variables[0] == "subtract") || (variables[0] == "multiply") || (variables[0] == "divide"))
                {
                    typeOfArithmetic = variables[0];
                    listOfTypesOfArithmetic.Add(typeOfArithmetic);
                    firstOperand = Convert.ToDouble(variables[1]);
                    secondOperand = Convert.ToDouble(variables[2]);

                    double verifyDouble = 0;
                    bool canConvertFirstOperand = double.TryParse(variables[1], out verifyDouble);
                    bool canConvertSecondOperand = double.TryParse(variables[2], out verifyDouble);

                    if (canConvertFirstOperand == true)
                    {
                        if (canConvertSecondOperand == true)
                        {
                            listOfFirstOperands.Add(firstOperand);
                            listOfSecondOperands.Add(secondOperand);
                        } else {
                            Console.WriteLine("Unable to retrieve second number");
                        }
                    } else {
                        Console.WriteLine("Unable to retrieve first number");
                    }
                } else {
                    Console.WriteLine("Invalid input from file. Unable to determine type of arithmetic");
                }
            }
        }
        public void writeToFile()
        {
            writeResultsPath = "C:\\Users\\ahudgens\\desktop\\testResults.txt";
            StreamWriter writer = new StreamWriter(writeResultsPath, append: true);
            using (writer)
            {
                int counter = 0;
                while (counter < (variables.Length + 1))
                {
                    Console.WriteLine(listOfTypesOfArithmetic[counter]);
                    writer.WriteLine("The total of " + listOfFirstOperands[counter] + " " + listOfSecondOperands[counter]);
                    counter++;
                }
            }
        }
    }
}
