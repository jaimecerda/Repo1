using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    public class Algorithm
    {

        public List<string> GetResults(int StartNumber,int EndNumber)
        {
            List<string> theResults = new List<string>();

            for (int i = StartNumber; i < EndNumber + 1; i++)
            {

                //Divisible Validation

                if (((i % 5) == 0) && ((i % 3) == 0))
                {
                    theResults.Add("fizzbuzz");
                }
                else
                {
                    if ((i % 5) == 0)
                    {
                        theResults.Add("buzz");
                    }
                    else
                    {
                        if ((i % 3) == 0)
                        {
                            theResults.Add("fizz");
                        }
                        else
                        {
                            theResults.Add(i.ToString());
                        }
                    }
                }
            }

            return theResults;
        }

        public string GetDivisibleInfo(int CurrentNumber)
        {
            //Divisible Validation
            string result;

            if (((CurrentNumber % 5) == 0) && ((CurrentNumber % 3) == 0))
                {
                    result="fizzbuzz";
                }
                else
                {
                    if ((CurrentNumber % 5) == 0)
                    {
                        result="buzz";
                    }
                    else
                    {
                        if ((CurrentNumber % 3) == 0)
                        {
                            result="fizz";
                        }
                        else
                        {
                            result=CurrentNumber.ToString();
                        }
                    }
            }

            return result;
        }


        public List<DivisibleInfo> GetCompressedResults(int StartNumber, int EndNumber)
        {
            List<DivisibleInfo> theResults = new List<DivisibleInfo>();

            for (int i = StartNumber; i < EndNumber + 1; i++)
            {

                //Divisible Validation

                if (((i % 5) == 0) && ((i % 3) == 0))
                {
                    theResults.Add(new DivisibleInfo{TheNumber=i,TheCodeWord="fizzbuzz"});
                }
                else
                {
                    if ((i % 5) == 0)
                    {
                        theResults.Add(new DivisibleInfo{TheNumber=i,TheCodeWord="buzz"});
                    }
                    else
                    {
                        if ((i % 3) == 0)
                        {
                            theResults.Add(new DivisibleInfo { TheNumber = i, TheCodeWord = "fizz" });
                        }
                    }
                }
            }

            return theResults;
        }
    }
}
