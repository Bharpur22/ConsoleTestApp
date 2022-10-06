  namespace  BAL
{
    public class Flight : IFlight
    {
        public int FlightNo{get;set;}
        public int DayNo{get;set;}
        public IAirport Departure{get;set;} 
        public IAirport Arrival{get;set;} 

       public Flight(int _FlightNo, int _DayNo, IAirport _departure, IAirport _Arrival)
        {
            this.FlightNo=_FlightNo;
            this.DayNo=_DayNo;
            this.Departure=_departure;
            this.Arrival=_Arrival;
        }
    }
}