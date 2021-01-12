using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using GraceFellowShipRetreat2020.Models;

namespace GraceFellowShipRetreat2020.Models
{
    public class Article
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Categories { get; set; }
        public List<CategoryModel> lstCategories { get; set; }
        public string Contents { get; set; }
        public string ImageSmall { get; set; }
        public string ImageLarge { get; set; }
        public string CreatedDay { get; set; }
        public string CreatedMonth { get; set; }
    }
}