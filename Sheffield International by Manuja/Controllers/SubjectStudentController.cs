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
    public class SubjectStudentController : Controller
    {
        private readonly IConfiguration _configuration;

        public SubjectStudentController(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                        select student_no, subject_no
                        from 
                       sheffield_international.student_subjects
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("StudentSubjectAppCon");
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
        public JsonResult Post(StudentSubject studentSubject)
        {
            string query = @"
                        insert into sheffield_international.student_subjects 
                        (student_no,subject_no) 
                        values
                         (@StudentId,@SubjectId) ;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("StudentSubjectAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@StudentId", studentSubject.StudentId);
                    myCommand.Parameters.AddWithValue("@SubjectId", studentSubject.SubjectId);
                    

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }


        [HttpPut]
        public JsonResult Put(StudentSubject studentSubject)
        {
            string query = @"
                        update sheffield_international.student_subjects   set 
                        student_no =@StudentId,
                        subject_no =@SubjectId,
                        
                        where student_no = @StudentId and subject_no=@SubjectId;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("StudentSubjectAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@StudentId", studentSubject.StudentId);
                    myCommand.Parameters.AddWithValue("@SubjectId", studentSubject.SubjectId);
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
                        where student_no=@StudentId and subject_no=@SubjectId;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("StudentSubjectAppCon");
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
