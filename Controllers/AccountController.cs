using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApp.Models;

namespace WebApp.Controllers
{
    
        public class AccountController : Controller
        {
            public ActionResult Login()
            {
                return View();
            }

            public ActionResult Logout()
            {
                FormsAuthentication.SignOut();

                return RedirectToAction("Account", "Login");



            }



            public ActionResult AppStore()
            {
                return View();
            }
            [HttpPost]


            public ActionResult Login(LoginViewModel lc)
            {

            String connection = "Data Source=LAPTOP-MSG3CVJQ;Initial Catalog=TataPower;Integrated Security=True";
                using (SqlConnection sqlcon = new SqlConnection(connection))
                {
                    String sql_query = "select UserId, Pwd from [dbo].[Login] where UserId=@UserId and Pwd=@Pwd";
                    using (SqlCommand sqlcom = new SqlCommand(sql_query, sqlcon))
                    {
                        sqlcon.Open();
                        SqlCommand sqlcomm = new SqlCommand(sql_query, sqlcon);
                        sqlcomm.Parameters.AddWithValue("@UserId", lc.UserId);
                        sqlcomm.Parameters.AddWithValue("@Pwd", lc.Pwd);
                    SqlDataReader sdr = sqlcomm.ExecuteReader();

                        if (sdr.Read())
                        {
                           return RedirectToAction("AddCards", "App");
                        }
                        else
                        {
                            ViewBag.Message = "Invalid Credentials";
                        }

                        sdr.Close();
                        return View();
                    }
                }
            }
        }
    }