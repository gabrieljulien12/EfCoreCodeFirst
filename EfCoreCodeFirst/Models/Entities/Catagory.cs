namespace EfCoreCodeFirst.Models.Entities
{
    public class Catagory:BaseEntity
    {
        public string CatagoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual List<Product> Products { get; set; } // bir katagori birden fazla ürünü içere bilicegi için burda onu list olarak verdik.
    }

    
}
