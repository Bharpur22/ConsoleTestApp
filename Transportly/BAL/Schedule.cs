namespace BAL
{
   public class Schedule : ISchedule
    {
         public System.Collections.Generic.List<IFlight> FlightSchedule {get;set;}
      public Schedule()
        {
            this.FlightSchedule=new System.Collections.Generic.List<IFlight>();
            this.FlightSchedule.Add(new Flight(1,1,new Airport("YUL","Montreal") ,new BAL.Airport("YYZ","Toronto")));            
            this.FlightSchedule.Add(new Flight(2,1,new Airport("YUL","Montreal") ,new BAL.Airport("YYC","Calgary")));
            this.FlightSchedule.Add(new Flight(3,1,new Airport("YUL","Montreal") ,new BAL.Airport("YVR","Vancouver")));
            this.FlightSchedule.Add(new Flight(4,2,new Airport("YUL","Montreal") ,new BAL.Airport("YYZ","Toronto")));
            this.FlightSchedule.Add(new Flight(5,2,new Airport("YUL","Montreal") ,new BAL.Airport("YYC","Calgary")));
            this.FlightSchedule.Add(new Flight(6,2,new Airport("YUL","Montreal") ,new BAL.Airport("YVR","Vancouver"))); 
        } 
        public void ShowSchedule()
        { 
            foreach(var obj in this.FlightSchedule)
            {
                Console.WriteLine("Flight: {0}, departure: {2}, arrival: {3}, day: {1}",obj.FlightNo,obj.DayNo,obj.Departure.AirtportName,obj.Arrival.AirtportName);
            }
        }
    }
}