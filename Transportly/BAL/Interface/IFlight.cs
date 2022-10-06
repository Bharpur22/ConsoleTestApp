  namespace  BAL
{
    public interface IFlight
    {
        public int FlightNo{get;set;}
        public int DayNo{get;set;}
        public IAirport Departure{get;set;} 
        public IAirport Arrival{get;set;} 

    }
}