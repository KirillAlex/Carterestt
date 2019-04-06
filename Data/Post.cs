using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
<<<<<<< HEAD
    /// <summary>
    /// Този клас описва публикация
    /// </summary>
    /// <remarks>
    ///     Автор: Бюлент Казали
    /// </remarks>
    public class Post
    { 
=======
    public class Post
    {
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public string FileName { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<BrandPost> BrandPosts { get; set; }

    }
}
