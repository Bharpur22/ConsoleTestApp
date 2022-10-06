namespace BAL
{
   public interface IOrder
    {      
        public System.Collections.Generic.List<IBox> OrderList {get;set;}
        public void ShowOrderList(); 
    }

}