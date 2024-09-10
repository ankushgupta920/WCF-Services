using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace ProductServiceDemo
{
    class ProductService : IProductService
    {
        List<Product> IProductService.GetAllProducts()
        {
            List<Product> mylist = new List<Product>();

            string constr = @"data source = LAPTOP-AHFNJFI6\SQLEXPRESS; initial catalog = NewDB; integrated security = true; ";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string query = "select * from Product";
            SqlCommand cm1 = new SqlCommand(query, con);
            SqlDataReader dr;
            dr = cm1.ExecuteReader();
            while(dr.Read())
            {
                Product obj = new Product();
                obj.pid = dr["pid"].ToString();
                obj.pname = dr["pname"].ToString();
                obj.pcost = int.Parse(dr["pcost"].ToString());
                mylist.Add(obj);
            }
            con.Close();

            return mylist;
        }


        List<Product> IProductService.GetAllProductsByID(string id)
        {
            List<Product> mylist = new List<Product>();

            string constr = @"data source = LAPTOP-AHFNJFI6\SQLEXPRESS; initial catalog = NewDB; integrated security = true; ";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string query = "select * from Product where pid = '"+id+"'";
            SqlCommand cm1 = new SqlCommand(query, con);
            SqlDataReader dr;
            dr = cm1.ExecuteReader();
            while (dr.Read())
            {
                Product obj = new Product();
                obj.pid = dr["pid"].ToString();
                obj.pname = dr["pname"].ToString();
                obj.pcost = int.Parse(dr["pcost"].ToString());
                mylist.Add(obj);
            }
            con.Close();

            return mylist;
        }
    }
}
