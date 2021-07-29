using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using Sheffield_International_by_Manuja.Models;

namespace Sheffield_International_by_Manuja.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IConfiguration configuration;
        public StudentController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                        select studentId,student_name from 
                        sheffield_international.Student
            ";

                    DataTable table = new DataTable();
            string sqlDataSource = configuration.GetConnectionString("Student");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult(table);
        }


        [HttpPost]
        public JsonResult Post(Student stu)
        {
            string query = @"
                        insert into sheffield_international.Student (student_name) values
                                                    (@student_name);
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = configuration.GetConnectionString("StudentAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@student_name", stu.student_name);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }


        [HttpPut]
        public JsonResult Put(Student stu )
        {
            string query = @"
                        update sheffield_international.Student set 
                        student_name =@student_name
                        where id=@id;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = configuration.GetConnectionString("StudentAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@id", stu.id);
                    myCommand.Parameters.AddWithValue("@student_name", stu.student_name);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }



        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                        delete from sheffield_international.Student 
                        where id=@id;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = configuration.GetConnectionString("StudentAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@id", id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }

    }
}
