class Program 
{
    static void Main(string[] args)
    {
        DateTime myvalue = DateTime.Now;
        //Console.WriteLine(myvalue.ToString());
        //Console.WriteLine(myvalue.ToShortDateString());
        //Console.WriteLine(myValue.ToShortTimeString());
        //Console.WriteLine(myvalue.ToLongDateString());
        //Console.WriteLine(myvalue.ToLongTimeString());

        //Console.WriteLine(myvalue.AddDays(3).ToLongDateString());
        //Console.WriteLine(myvalue.AddHours(3).ToLongTimeString());
        //Console.WriteLine(myvalue.AddDays(-3).ToLongDateString());
        //Console.WriteLine(myvalue.Month);

        //DateTime myBirthday = new DateTime(1969, 12, 7);
        //Console.WriteLine(myBirthday.ToShortDateString());

        DateTime myBirthday = DateTime.Parse("12/7/1969");
        TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
        Console.WriteLine(myAge.TotalDays);
        
        Console.ReadLine();
    }
}
