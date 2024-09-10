using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace ProductServiceDemo
{
    [ServiceContract]
    interface IProductService
    {
        [OperationContract]
        List<Product> GetAllProducts();

        [OperationContract]
        List<Product> GetAllProductsByID(string id);
    }

    [DataContract]
    class Product
    {
        [DataMember]
        public string pid { get; set; }
        [DataMember]
        public string pname { get; set; }
        [DataMember]
        public int pcost { get; set; }
    }
}
