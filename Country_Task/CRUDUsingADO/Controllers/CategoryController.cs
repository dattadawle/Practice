using CRUDUsingADO.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDUsingADO.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {

            List<Category> categories = new List<Category>();

            //SqlConnection connection= new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

            // SqlCommand cmd = new SqlCommand("Select * from Category",connection);
         
            SqlConnection connection = null;
            connection = new SqlConnection(DbConstants.ConnectionString);
            SqlCommand cmd = new SqlCommand(DbConstants.spGetCategories, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            

            if (dataReader != null)
            {
               if(dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                       Category category = new Category()
                        {
                            Id = (int)dataReader["Id"],
                            Name = (string)dataReader["Name"],
                            Rating = (int)dataReader["Ratings"]

                        };
                        categories.Add(category);
                    }
                   
                }
            }
            connection.Close();
           

            return View(categories);
        }
    }
}