   namespace  BAL
{
    public class Airport : IAirport
    {
        public string AirportCode{get;set;}
        public string AirtportName{get;set;}
       public Airport(string _airportCode, string _airportName)
        {
            this.AirportCode=_airportCode;
            this.AirtportName=_airportName;
        }
    }
}