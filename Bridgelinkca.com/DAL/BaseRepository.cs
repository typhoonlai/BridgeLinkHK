
using BridgelinkDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bridgelinkca.com.DAL
{
    public class BaseRepository
    {
        private BridgelinkDBEntities ent = null;
        public BridgelinkDBEntities Entities
        {
            get
            {
                if (ent == null)
                {
                    ent = new BridgelinkDBEntities();
                }
                return ent;

            }
        }
    }
}