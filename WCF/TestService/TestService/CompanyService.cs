using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace TestService
{
    [ServiceContract]
    interface CompanyService
    {
        [OperationContract]
        string GetName();

        [OperationContract]
        string GetCompanyName(string name);

        [OperationContract]
        string GetResult(string name, int m1, int m2, int m3);

        [OperationContract]
        int GetMaxNumber(int[] n);

        [OperationContract]
        int[] GetUnsortedData(int[] n);

        [OperationContract]
        string GetEmployee(Employee obj);
    }
    
    [DataContract]
    class Employee
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int jan { get; set; }
        [DataMember]
        public int feb { get; set; } 
        [DataMember]
        public int march { get; set; }
    }
}
