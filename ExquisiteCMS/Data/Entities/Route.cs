using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExquisiteCMS.Data.Entities
{
    public class Route
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Module { get; set; }
    }
}