namespace EfCoreCodeFirst.Models.Entities
{
    public class Product:BaseEntity
    {
        public  string ProductName { get; set; } // Burda verinin altında uyarı vermesinin sebebi eski .net sürümlerinde stringler null gecilebilir otamatik olarak geliyordu suanda sadece required veyahur sonuna ? işareti koyabilrisiniz koymasanızda herhangi bir sıkıntı cıkartmıcaktır.
        public decimal UnitPrice { get; set; }
        public int? CategoryID { get; set; } // NULL gecilebilir olamasının sebebi test yaparken daha rahat olucaz 

        //Relational Properties
        public virtual  Catagory Catagory { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
