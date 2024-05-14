using EfCoreCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreCodeFirst.Models.Configuration
{
    public abstract class BaseConfiguration<T>:IEntityTypeConfiguration<T> where T :BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder) // buraya virtual yazmamızın sebebi diger congig lerimizde  ana tanımlarımızdaki ayarlamaları override metoduyla hızlı bir şekilde getirmek için.
        {
            builder.Property(x => x.CreatedDate).HasColumnName("YaratılmaTatihi");

        }
    }
}
