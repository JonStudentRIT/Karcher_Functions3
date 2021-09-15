using System;

namespace Functions3
{
    /* Class: Program
     * Author: Jonathan Karcher
     * Purpose: Impersonate the Console.ReadLine() function
     * Restrictions: None
     */
    class Program
    {
        // create a delegate function
        delegate string impersonate();
        static void Main(string[] args)
        {
            // create a string variable
            string s = "";
            // assign the delegated funciton to the imposter method
            impersonate imposter = new impersonate(Imposter);
            // use the imposter to store information from the user
            s = imposter();
            // output the information the user entered
            Console.WriteLine(s);
        }
        /* Method: Imposter
         * Purpose: Return anything the user entered when called
         * Restrictions: None
         */
        static public string Imposter()
        {
            return Console.ReadLine();
        }
    }
}
