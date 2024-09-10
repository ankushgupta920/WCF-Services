using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    class CompanyServiceClass : CompanyService
    {

        string CompanyService.GetName()
        {
            return "IT TECH HINDI HUB WORLD";
        }


        string CompanyService.GetCompanyName(string name)
        {
            return name;
        }


        string CompanyService.GetResult(string name, int m1, int m2, int m3)
        {
            double avg = (m1 + m2 + m3) / 3.0;
            if(avg < 50)
            {
                return name + " is FAIL";
            }
            else
            {
                return name + " is PASS";
            }
        }


        int CompanyService.GetMaxNumber(int[] n)
        {
            int max = n[0];
            for(int i = 0; i<n.Length; i++)
            {
                if(max < n[i])
                {
                    max = n[i];
                }
            }
            return max;
        }


        int[] CompanyService.GetUnsortedData(int[] n)
        {
            Array.Sort(n);
            return n;
        }


        string CompanyService.GetEmployee(Employee obj)
        {
            string name = obj.name;
            int jan = obj.jan;
            int feb = obj.feb;
            int march = obj.march;

            int total = jan + feb + march;
            return "Total Sale Done By " + name + " is" + total + " LKHS RS";
        }
    }
}
