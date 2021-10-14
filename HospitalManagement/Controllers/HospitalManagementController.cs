using HospitalManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace HospitalManagement.Controllers
{
    public class HospitalManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AddUserView()
        {
            return PartialView("_SignUp");
        }   

        public IActionResult Home()
        {
            Models.HospitalMgmtViewModel userViewModel = new Models.HospitalMgmtViewModel();
            SqlConnection sqlConnection = new SqlConnection(Utilities.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand(Utilities.Procedures.GetCounts, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet != null)
            {
                if (dataSet.Tables.Count > 0)
                {
                    userViewModel.Count.DoctorsCount = dataSet.Tables[0].Rows[0]["DoctorCount"].ToString();
                    userViewModel.Count.HospitalsCount = dataSet.Tables[1].Rows[0]["HospitalCount"].ToString();
                    userViewModel.Count.CitiesCount = dataSet.Tables[2].Rows[0]["CityCount"].ToString();
                    userViewModel.Count.PatientsCount = dataSet.Tables[3].Rows[0]["UserCount"].ToString();

                    foreach (DataRow dataRow in dataSet.Tables[4].Rows)
                    {
                        userViewModel.DoctorsList.Add(dataRow.ItemArray[0].ToString());
                    } 
                    foreach (DataRow dataRow in dataSet.Tables[5].Rows)
                    {
                        userViewModel.HospitalsList.Add(dataRow.ItemArray[0].ToString());
                    } 
                    foreach (DataRow dataRow in dataSet.Tables[6].Rows)
                    {
                        userViewModel.PatientsList.Add(dataRow.ItemArray[0].ToString());
                    }

                }
            }

            return View(userViewModel);
        }

        [IgnoreAntiforgeryToken]
        [HttpGet]
        public JsonResponse AddUpdate(User user)
        {
            JsonResponse response = new JsonResponse();
            if (ModelState.IsValid)
            {              
                SqlConnection con = new SqlConnection(Utilities.ConnectionString);
                SqlCommand cmd = new SqlCommand(Utilities.Procedures.AddUpdate, con);
                cmd.CommandType = CommandType.StoredProcedure;        
                cmd.Parameters.AddWithValue("@Username", user.Username.ToString());
                cmd.Parameters.AddWithValue("@Phone", user.Phone.ToString());
                cmd.Parameters.AddWithValue("@Email", user.Email.ToString());
                cmd.Parameters.AddWithValue("@Password", user.Password.ToString());
                cmd.Parameters.AddWithValue("@ConfirmPassword", user.ConfirmPassword.ToString());
                cmd.Parameters.AddWithValue("@DoctorID", Convert.ToInt32(user.DoctorID));
                cmd.Parameters.AddWithValue("@HospitalID", Convert.ToInt32(user.HospitalID));
                cmd.Parameters.AddWithValue("@LocationID", Convert.ToInt32(user.LocationID));
                con.Open();
                int id = cmd.ExecuteNonQuery();
                if (id != 1)
                {
                    response.Status = "F";
                    response.Message = "Failed To Inserted";
                }
                else
                {
                    response.Status = "S";
                    response.Message = "SuccessFully Inserted";
                }
            }
            else
            {
                response.Status = "F";
                response.Message = "Failed To Insert";

            }

            return response;
        }

        public PartialViewResult SearchDoctor()
        {
            return PartialView("SearchDoctor");
        }
        
        public PartialViewResult _AppointmentPartialView()
        {
            return PartialView("_AppointmentPartialView");
        }

        [IgnoreAntiforgeryToken]
        [HttpGet]
        public JsonResult GetSummaryDetails(int Flag) 
        {          
            List<Common> DoctorSummary = new List<Common>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand(Utilities.Procedures.GetSummaryDetails, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Flag", Convert.ToInt32(Flag));
            sqlConnection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(ds);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        DoctorSummary.Add(new Common
                        {
                            ID = Convert.ToInt32(item["ID"])
                            ,
                            Name = Convert.ToString(item["DoctorName"])
                            ,
                            HospitalName = Convert.ToString(item["HospitalName"])
                            ,
                            LocationName = Convert.ToString(item["CityName"])
                        });
                    }
                }             
            }
            return Json(DoctorSummary);
        }


        [IgnoreAntiforgeryToken]
        [HttpGet]
        public JsonResponse GetDropdownDetails(string Json)
        {
            //var JSONObj = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(Json);
            dynamic JSONObj = JsonConvert.DeserializeObject(Json);
            JsonResponse jsonResponse = new JsonResponse();
            List<SelectListItem> DropdownData = new List<SelectListItem>();
            SqlConnection sqlConnection = new SqlConnection(Utilities.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand(Utilities.Procedures.GetDropdownDetails,sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Flag",Convert.ToInt32(JSONObj["Flag"]));
            sqlCommand.Parameters.AddWithValue("@CityID",Convert.ToInt32(JSONObj["CityID"]));
            sqlCommand.Parameters.AddWithValue("@HospitalID",Convert.ToInt32(JSONObj["HospitalID"]));
            sqlConnection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataSet);
            if (dataSet != null)
            {
                if (dataSet.Tables.Count > 0)
                {
                    if (dataSet.Tables.Count == 1)
                    {
                        if (JSONObj["Flag"] == 1) {
                            foreach (DataRow item in dataSet.Tables[0].Rows)
                            {
                                DropdownData.Add(new SelectListItem
                                {
                                    Text = Convert.ToString(item["CityName"]),
                                    Value = Convert.ToString(item["ID"])
                                });
                            }
                           
                        }
                        else if (JSONObj["Flag"] == 2)
                        {
                            foreach (DataRow item in dataSet.Tables[0].Rows)
                            {
                                DropdownData.Add(new SelectListItem
                                {
                                    Text = Convert.ToString(item["HospitalName"]),
                                    Value = Convert.ToString(item["ID"])
                                });
                            }                         
                        }
                        else if (JSONObj["Flag"] == 3)
                        {
                            foreach (DataRow item in dataSet.Tables[0].Rows)
                            {
                                DropdownData.Add(new SelectListItem
                                {
                                    Text = Convert.ToString(item["DoctorName"]),
                                    Value = Convert.ToString(item["ID"])
                                });
                            }
                        }
                        jsonResponse.Status = "S";
                        jsonResponse.Message = "Success";
                        jsonResponse.Data = DropdownData;
                    }
                  
                }
                else 
                {
                    jsonResponse.Status = "F";
                    jsonResponse.Message = "Failed";
                }
            }
            return jsonResponse;
        }

        [IgnoreAntiforgeryToken]
        [HttpGet]
        public JsonResponse AddUpdateAppointment(string json)           
        {
            dynamic JSONObj = JsonConvert.DeserializeObject(json);
            JsonResponse jsonResponse = new JsonResponse();
            SqlConnection sqlConnection = new SqlConnection(Utilities.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand(Utilities.Procedures.AddUpdateAppointment,sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Flag",Convert.ToInt32(1));         
            sqlCommand.Parameters.AddWithValue("@Name", Convert.ToString(JSONObj["Name"]));
            sqlCommand.Parameters.AddWithValue("@Phone", Convert.ToString(JSONObj["Phone"]));
            sqlCommand.Parameters.AddWithValue("@Email", Convert.ToString(JSONObj["Email"]));
            sqlCommand.Parameters.AddWithValue("@CityID", Convert.ToInt32(JSONObj["CityID"]));
            sqlCommand.Parameters.AddWithValue("@HospitalID", Convert.ToInt32(JSONObj["HospitalID"]));
            sqlCommand.Parameters.AddWithValue("@DoctorID", Convert.ToInt32(JSONObj["DoctorID"]));
            sqlCommand.Parameters.AddWithValue("@DateOfAppointment", Convert.ToDateTime(JSONObj["DateOfAppointment"]));
            sqlCommand.Parameters.AddWithValue("@HealthQueries", Convert.ToString(JSONObj["HealthQueries"]));
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable != null)
            {
                if (dataTable.Columns.Count > 0)
                {
                    jsonResponse.Status = dataTable.Rows[0]["STATUS"].ToString();

                    jsonResponse.Message = dataTable.Rows[0]["MESSAGE"].ToString();
                }
                else
                {
                    jsonResponse.Status = "F";
                    jsonResponse.Message = "FAILED";
                }
            }
            else
            {
                jsonResponse.Status = "F";
                jsonResponse.Message = "FAILED";
            }

            return jsonResponse;


        }

    }
}
