using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExquisiteCMS.Areas.Webpage.Data.Entities
{
    public class Page
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public int ParendId { get; set; }
    }
}