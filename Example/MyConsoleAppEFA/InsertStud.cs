using Microsoft.Identity.Client;
using MyConsoleAppEFA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleAppEFA
{
    public  class InsertStud
    {
        public void Insert()
        {
            using(var context = new TrainingDbContext())
            {
                Company obj = new Company();
                {
                    int cnt = 10;
                    int count = 10;
                    while (cnt > 0)
                    {
                        List<Company> lstcompany = new List<Company>();

                        for (int i = 0; i < count; i++)
                        {

                            Company company = new Company()
                            {
                                //CompId = 1,
                                CompEmail = string.Format("email{0}@yopmail.com", i.ToString()),
                                CompName = string.Format("Companyname{0}", i.ToString()),
                                CompAddress = string.Format("pune{0}", i.ToString()),
                                CompPhone = 1234,
                                                               
                            };

                            lstcompany.Add(company);
                            
                        }
                        context.AddRange(lstcompany);
                        context.SaveChanges();
                        cnt--;
                    }
                }

            }
        }
    }
}
