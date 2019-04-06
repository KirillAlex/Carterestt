using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
<<<<<<< HEAD
    /// <summary>
    /// Този клас описва връзка между марка и публикация
    /// </summary>
    /// <remarks>
    ///     Автор: Бюлент Казали
    /// </remarks>
    public class BrandPost
    {   
=======
    public class BrandPost
    {
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int PostId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Post Post { get; set; }

    }
}
