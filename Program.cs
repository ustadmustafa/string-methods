namespace string_methods;

class Program
{
    static void Main(string[] args)
    {
        string degisken ="dersimiz c#";
        string degisken2 = "ders c#";

        //Length
        Console.WriteLine(degisken.Length);

        //to upper - to lower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        //concat
        Console.WriteLine(String.Concat(degisken," merhaba"));

        //compare compareto
        Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
        Console.WriteLine(String.Compare(degisken,degisken2,true));
        Console.WriteLine(String.Compare(degisken,degisken2,false));
    }
}
