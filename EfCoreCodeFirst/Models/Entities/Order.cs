﻿namespace EfCoreCodeFirst.Models.Entities
{
    public class Order:BaseEntity
    {
        public string ShippedAdres { get; set; }
        public int? AppUserID { get; set; }

        //Relational Properties

        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }


    }
}
