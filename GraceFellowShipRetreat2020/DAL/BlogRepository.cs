
using BridgelinkDB;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace GraceFellowShipRetreat2020.DAL
{
    public class BlogRepository:BaseRepository
    {

        public List<GraceFellowShipRetreat2020.Models.Article> GetAllArticles()
        {
            

            var query = (from c in Entities.Articles
                         select new GraceFellowShipRetreat2020.Models.Article
                         {
                             ID=c.ID,
                            Title=c.Title,
                            Summary=c.Summary,
                            Contents=c.Contents,
                        
                            ImageSmall=c.ImageSmall,
                            ImageLarge=c.ImageLarge,
                            CreatedMonth=SqlFunctions.DateName("MM",c.CreatedDate),
                             CreatedDay = SqlFunctions.DateName("dd", c.CreatedDate),


                         }).ToList();

            //foreach (GraceFellowShipRetreat2020.Models.Article a in query)
            //{
            //    var Categories = (from c in Entities.Categories
            //                      where a.
            //                     select new GraceFellowShipRetreat2020.Models.CategoryModel
            //                     {
            //                         ID =a.ID,
            //                CategoryName=a.Categories.categoryName
            //                CategoryHTML=

            //            }).ToList();

            //    foreach (GraceFellowShipRetreat2020.Models.CategoryModel c in Categories)
            //    {


            //    }
              
            //}

            return query;
        }
    }
}