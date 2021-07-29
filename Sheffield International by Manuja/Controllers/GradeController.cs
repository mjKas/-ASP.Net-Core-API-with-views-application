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
    public class GradeController : Controller
    {
        private readonly IConfiguration _configuration;
        
        public GradeController(IConfiguration configuration)
        {
            _configuration = configuration;
            
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                        select student_id, subject_id, marks, grade
                        from 
                       sheffield_international.grade
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("GradeAppCon");
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
        public JsonResult Post(Grade grade )
        {
            string query = @"
                        insert into sheffield_international.grade 
                        (student_id,subject_id,marks,grade) 
                        values
                         (@StudentId,@SubjectId,@marks,@Grad) ;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("GradeAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@StudentId", grade.StudentId);
                    myCommand.Parameters.AddWithValue("@SubjectId", grade.SubjectId);
                    myCommand.Parameters.AddWithValue("@marks", grade.marks);
                    myCommand.Parameters.AddWithValue("@Grad", grade.Grad);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }


        [HttpPut]
        public JsonResult Put(Grade grade)
        {
            string query = @"
                        update sheffield_international.grade  set 
                        student_id =@StudentId,
                        subject_id =@SubjectId,
                        marks =@marks,
                        grade =@Grad
                        where student_id=@StudentId and subject_id=@SubjectId;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("GradeAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@StudentId", grade.StudentId);
                    myCommand.Parameters.AddWithValue("@SubjectId", grade.SubjectId);
                    myCommand.Parameters.AddWithValue("@marks", grade.marks);
                    myCommand.Parameters.AddWithValue("@Grad", grade.Grad);

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
                        delete from sheffield_international.grade
                        where student_id=@StudentId and subject_id=@SubjectId;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("GradeAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@StudentId", id);

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
