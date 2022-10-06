namespace BAL
{
   public interface ISchedule
    {
        public System.Collections.Generic.List<IFlight> FlightSchedule {get;set;}

        public void ShowSchedule(); 
    }
}