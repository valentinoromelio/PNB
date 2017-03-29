using System;
using System.Collections.Generic;
using System.Linq;

namespace Proj1
{
    public class Program
    {
        protected HashSet<string> ListToBeFiltered = new HashSet<string>(new List<string> { "abcdef", "abcdef", "cdef", "abc", "def", "bcdefg", "defabc" });

        static void Main(string[] args)
        {
            Program prog1 = new Program();
            List<string> result = prog1.Filter(prog1.ListToBeFiltered);
            foreach (var item in result)
            {
                Console.WriteLine("Filtered item: " + item);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Usage
        /// Input:      list of strings to be Filtered
        /// Output:     list of valid string 
        /// </summary>
        /// <returns></returns>
        public List<string> Filter(HashSet<string> listToBeFiltere)
        {
            List<string> results = new List<string>();

            bool foundX = false, foundY = false;

            /*
             * Only select strings with length 6 are possible outcomes
             */
            foreach (var compareItem in listToBeFiltere.Where(e=>e.Length==6))
            {
                /*
                 * The subItems can be only length 6 and if the first part is found, within the current iteration the second one does 
                 * not need to be found
                 */
                foreach (var item in listToBeFiltere.Where(e=>e.Length==3))
                {
                    if (compareItem.StartsWith(item))
                        foundX = true;
                    else if (compareItem.EndsWith(item))
                        foundY = true;

                    /*
                     * Only if the first and the second part is found, all the conditions are true
                     * In that case, add the compareItem to the list to be displayed and exit current iteration
                     */
                    if (foundX && foundY )
                    {
                        results.Add(compareItem);
                        foundX = false;
                        foundY = false;
                        continue;
                    }
                }
                //reset found flags
                foundX = false;
                foundY = false;
            }

            return results;
        }
    }
}
