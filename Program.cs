using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        
        /*DateTime time = DateTime.ParseExact(s, "h:mm:ss tt", CultureInfo.InvariantCulture);
        return time.ToString("HH:mm:ss", CultureInfo.GetCultureInfo("pl-PL"));*/
        DateTime time = DateTime.ParseExact(s, "h:mm:sstt", CultureInfo.InvariantCulture);
        return time.ToString("HH:mm:ss");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);

    }
}
