  namespace  BAL
{
    public class Box : IBox
    {
        public string OrderNum{get;set;} 
        public IFlight flight{get;set;}  

        public  Box(string _OrderNum, IFlight  _flight)
        {
            this.OrderNum = _OrderNum;
            this.flight = _flight;  

        }
    }
}