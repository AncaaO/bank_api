using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;
using Bank.Entities;
using System.Data;
using Microsoft.Extensions.Configuration;
using Azure.Identity;

namespace Bank.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IConfiguration Configuration;

        public UserController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

/*        SqlConnection con = null;
*/        SqlCommand cmd = null;
        SqlDataAdapter da = null;

        [HttpPost]
        [Route("Registration")]
        public string Registration(User user)
        {
            string msg = string.Empty;

            try
            {
                SqlConnection con = new SqlConnection(Configuration.GetConnectionString("OperationConnection"));

                cmd = new SqlCommand("usp_Registration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
                con.Open();
                        int i = cmd.ExecuteNonQuery();
                        con.Close();
                        if (i > 0)
                        {
                            msg = "Data inserted";
                        }
                        else
                        {
                            msg = "Error";
                        }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }

        [HttpPost]
        [Route("Login")]
        public string Login(UserCredential credentials)
        {
            string msg = string.Empty;

            try
            {
                SqlConnection con = new SqlConnection(Configuration.GetConnectionString("OperationConnection"));

                da = new SqlDataAdapter("usp_Login", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Name", credentials.Name);
                da.SelectCommand.Parameters.AddWithValue("@PhoneNumber", credentials.PhoneNumber);
                DataTable dt = new DataTable();
                
                da.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    msg = "Valid user";
                }
                else
                {
                    msg = "Invalid user";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }
    }
}
