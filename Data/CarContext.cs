using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
<<<<<<< HEAD
    /// <summary>
    /// Този клас описва контекст за достъп до БД
    /// </summary>
    /// <remarks>
    ///     Автор: Петър Павлов
    /// </remarks>
    public class CarContext: DbContext
    {   
=======
    public class CarContext: DbContext
    {
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        public CarContext() : base("name=Carterest")
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandPost> BrandPosts { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
