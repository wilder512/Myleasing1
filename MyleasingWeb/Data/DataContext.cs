using Microsoft.EntityFrameworkCore;
using MyleasingWeb.Data.Entities;

namespace MyleasingWeb.Data
{
    public class DataContext : DbContext
    {
        //creamos contructor de la clase, 
        //creamos inyecion  dbcontex y se la pasamos a la clase heredada. 

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //creamos propiedad tipo dbset para controlar los Owners para tratarlo como propiedad
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Lessee> Lessees { get; set; }
        public DbSet<Property> Propesties { get; set; }
        public DbSet<PropertyImages> PropertyImages { get; set; }
        public DbSet<PropertyType> PropertyType { get; set; }


    }
}
