using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coorier.Models.Entities
{
    public class User
    {
        public String Id { get; }
        private List<Package> packages = null;

        public User()
        {
            this.Id = Guid.NewGuid().ToString("N");
            this.packages = new List<Package>();
        }





        public String getPackageStatus(String pckgId)
        {
            Package package = packages.Find(delegate (Package item) { return item.Id.Equals(pckgId); });
            return package.Status;
        }
        public void setPackageStatus(String pckgId, String status)
        {
            packages.Find(delegate (Package item) { return item.Id.Equals(pckgId); }).Status = status;
        }



        public List<String> getAllStatuses()
        {
            List<String> statuses = new List<String>();
            foreach (Package pckg in packages)
            {
                statuses.Add(pckg.Status);
            }
            return statuses;
        }




        public List<Package> getPackagesWithStatus(String status)
        {
            List<Package> pckgsList = new List<Package>();
            foreach (Package pckg in this.packages)
            {
                if (pckg.Status.Equals(status))
                {
                    pckgsList.Add(pckg);
                }
            }
            return pckgsList;
        }




        public void addPackage(String pckgId)
        {
            packages.Add(new Package(pckgId));
        }

        public void removePackage(String pckgId)
        {
            packages.Remove(new Package(pckgId));
        }

    }
}
