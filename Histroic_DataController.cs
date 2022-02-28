using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Plant_Digitization_api.Controllers
{
    public class Histroic_DataController : Controller
    {
        //private string connectionstring = ConfigurationManager.ConnectionStrings["con"].ToString();
        //// GET: Histroic_Data
        //[System.Web.Http.HttpPost]
        //[CustomAuthenticationFilter]
        //public IHttpActionResult Add_Update_Category(Models.Skill_Category R)
        //{
        //    using (SqlConnection con = new SqlConnection(connectionstring))
        //    {
        //        string response = string.Empty;
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("sp_skillcategory", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
              
        //        cmd.Parameters.Add("@QueryType", SqlDbType.NVarChar, 150).Value = R.QueryType;
        //        cmd.Parameters.Add("@Companycode", SqlDbType.NVarChar, 150).Value = R.Companycode;
        //        cmd.Parameters.Add("@Plantcode", SqlDbType.NVarChar, 150).Value = R.Plantcode;
        //        cmd.Parameters.Add("@C", SqlDbType.NVarChar, 150).Value = R.Category_name;
        //        SqlParameter SQLReturn = new SqlParameter("@SQLReturn", SqlDbType.NVarChar, 50);
        //        SQLReturn.Direction = ParameterDirection.Output;
        //        cmd.Parameters.Add(SQLReturn);
        //        cmd.ExecuteNonQuery();
        //        response = SQLReturn.Value.ToString().Trim();
        //        return Ok(response);

        //    }

        //}
    }
}