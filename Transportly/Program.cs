using BAL;
internal class Program
{
    private static void Main(string[] args)
    {
        string Code=   args[0];
        if(Code.ToLower()=="orders")
        {
            IOrder ord=new   Order();   
            ord.ShowOrderList();   
            
        }
        else if (Code.ToLower()=="schedule")
        {
            ISchedule sch=new  Schedule(); 
            sch.ShowSchedule();
        }  
        
        Console.WriteLine("Press any key for exit");
        Console.ReadKey();
       }
}