using System.Text.Json;

namespace BAL
{
    public class Order : IOrder
    {
        public List<IBox> OrderList { get; set; }
        public Order()
        { 
            ISchedule sch=new  Schedule(); 
            OrderList=new List<IBox>();
            string json = File.ReadAllText(@"C:\Orders\coding-assigment-orders.JSON"); 
            Dictionary<string,orderDestination> oList = JsonSerializer.Deserialize<Dictionary<string,orderDestination>>(json);
           
            //Assign orders
            if (oList != null)
            {
                foreach(var key in oList )
                {
                    if (key.Key !=  null )
                    {     
                        IBox objOrder=new Box(key.Key ,null);       
                        foreach(var  flight in sch.FlightSchedule.Where(t=> t.Arrival.AirportCode==key.Value.destination).OrderBy(t=>t.FlightNo).ToList())
                        {
                            //Check if order count exceed from 20 for this
                            if(OrderList.Count(t=> t.flight!=null && t.flight.FlightNo==flight.FlightNo)>=20 )
                                continue;
                            else
                             {
                                objOrder.flight=flight;
                                break;
                             }
                        }
                        //Adding Orders into orderlist
                        OrderList.Add(objOrder);
                    }

                }
            }
        }
        public void ShowOrderList()
        {
            foreach(var ord in this.OrderList)
            {
                if (ord.flight==null)
                    Console.WriteLine("order: {0}, flightNumber: {1}",ord.OrderNum,"Not Scheduled");
                else
                    Console.WriteLine("order: {0}, flightNumber: {1}, departure: {3}, arrival: {4}, day: {2}",ord.OrderNum,ord.flight.FlightNo,ord.flight.DayNo,ord.flight.Departure.AirtportName,ord.flight.Arrival.AirtportName);
            }
        }
    }
}