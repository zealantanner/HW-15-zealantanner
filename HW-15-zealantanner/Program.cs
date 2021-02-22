

using System;


///<summary>
/// This is the program class and it does some stuff. YAY
///</summary>
class Program
{
    ///<summary>
    /// Displays text in the <mark>console</mark>
    ///</summary>
    ///<param name= "obj"> the text is here</param>


    public static void Display(object obj)
    {
        Console.WriteLine(obj);
    }

    ///<summary>
    /// Does some <i>funky</i> math to <strong>a</strong>, <strong>b</strong>
    ///</summary>
    ///<returns>
    /// Your <i>funky</i> number
    ///</returns>
    ///<date>January 1, 2000</date>*
    ///<param name= "a"> This is "a", the first digit</param> 
    ///<param name= "b"> This is "b", the second digit</param> 


    public static double DoSomeFunkyMathTo(double a, double b)
    {
        return (a*b-3+a+b+a+b-b/6/b/a+a*b-3+b/b*b+a*8-b*b*b+a+5-a*b/a+b*b-a/a+b*a-7-b/a*a+b);
    }

    static void Main(string[] args)
    {
        Display(DoSomeFunkyMathTo(5,Math.PI));
    }
}
