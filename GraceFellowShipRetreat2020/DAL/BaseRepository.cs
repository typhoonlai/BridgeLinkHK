
using BridgelinkDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraceFellowShipRetreat2020.DAL
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