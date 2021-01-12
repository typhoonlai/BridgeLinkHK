
using GraceFellowShipRetreat2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BridgelinkDB;

namespace GraceFellowShipRetreat2020.DAL
{
    public class SaveDBRepository:BaseRepository
    {
        public bool SaveContact(ContactUsModel cum)
        {
            try
            {
                var val = Entities.ContactUs.Where(x => x.Email == cum.ContactEmail && x.FromLocation == "bridgelinkhk.com").SingleOrDefault();
                if (val != null)
                    Entities.ContactUs.Remove(val);

                ContactUs cu = new ContactUs();
                cu.Name = cum.ContactName;
                cu.Email = cum.ContactEmail;
                cu.Message = cum.ContactMessage;
                cu.OptIn = cum.OptIn;
                cu.FromLocation = "bridgelinkhk.com";
                cu.CreatedDated = DateTime.Now;
                Entities.ContactUs.Add(cu);
                Entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;

            }






        }
    }
}