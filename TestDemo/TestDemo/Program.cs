using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set start and end numbers
            int StartNumber = -100;
            int EndNumber = 100;


            Console.WriteLine("Starting Test.  Press any key to start");
            Console.WriteLine("Starting Method 1");
            Console.ReadLine();

            Algorithm myAlgorithm = new Algorithm();

            //Method 1 --Memory consuming
            List<string> myResults;
            myResults = myAlgorithm.GetResults(StartNumber, EndNumber);

            foreach (string res in myResults)
            {
                Console.WriteLine(res);
            }


            //Method 2 -- On demand call to library.  
            //Source of solution: This one I figured out just after hanging up.
            Console.WriteLine("Starting Method 2.  Press any key to start");
            Console.ReadLine();
            for (int i = StartNumber; i < EndNumber + 1; i++)
            {
                Console.WriteLine(myAlgorithm.GetDivisibleInfo(i));
            }


            //Method 3 -- Compressed.  
            //Source of solution: This one I "cheated". I was having a conversation with a coworker and I got an idea to only return the divisibles, instead of all the numbers, 
            //hence it´s some kind of "compression".
            Console.WriteLine("Starting Method 3.  Press any key to start");
            Console.ReadLine();

            List<DivisibleInfo> myCompressedResults = new List<DivisibleInfo>();
            DivisibleInfo tempResult = new DivisibleInfo();
            myCompressedResults = myAlgorithm.GetCompressedResults(StartNumber, EndNumber);
            for (int i = StartNumber; i < EndNumber + 1; i++)
            {
                tempResult = myCompressedResults.Find(z => z.TheNumber == i);
                if (tempResult != null)
                {
                    Console.WriteLine(tempResult.TheCodeWord);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            //Method 4 --Paging / batch processing.
            //Source of solution: I made some research on the web and came up with this way of handling pages or batches of data.
            Console.WriteLine("Starting Method 4.  Press any key to start");
            Console.ReadLine();
            //Set Page size
            
            int pageSize = 100;

            int totalPages = (EndNumber - StartNumber + 1) / pageSize;

            List<string> pagedResults = new List<string>();

            //See if there's a decimal value that would represent a need for an extra page.  During testing saw this also works for when the results are less than a page.
            if ((EndNumber - StartNumber +1) % pageSize != 0)
            {
                totalPages++;
            }

            int tempStartNumber=StartNumber;
            int tempEndNumber = StartNumber + pageSize-1;

            for (int i = 1; i <= totalPages; i++)   //Without the nervousness from the test I realized that i<totalPages + 1 could be the same as i<=totalPages ... in this line of code I used the first way just to be consistent through all the code.
            {
                pagedResults = myAlgorithm.GetResults(tempStartNumber, tempEndNumber);

                //Show results from page
                foreach (string res in pagedResults)
                {
                    Console.WriteLine(res);
                }
                
                //"Change page"
                tempStartNumber = tempEndNumber+1;
                tempEndNumber = tempStartNumber + pageSize-1;
                if (tempEndNumber > EndNumber)
                {
                    tempEndNumber = EndNumber;
                }
            }
            Console.ReadLine();
        }
    }
}
