using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibWeb.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreateAt { get; set; }

        public IList<CategoryDocument> CategoryDocument { get; set; }
        public Category()
        {
            this.CreateAt = DateTime.Now;
        }
    }
}
