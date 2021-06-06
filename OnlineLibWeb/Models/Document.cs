using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibWeb.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public IList<CategoryDocument> CategoryDocument { get; set; }
    }
}
