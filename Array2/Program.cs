using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Array2;
class Program
{

    static void Main(string[] args)
    {

        int a = 4;
        int b = 2;

        try
        {

            Console.WriteLine("the anser is " + a / b);

        }
        catch
        {

            Console.WriteLine("an error has occured ");

        }
        finally
        {

            Console.WriteLine("finally has been called...");
                
        }
    }

}