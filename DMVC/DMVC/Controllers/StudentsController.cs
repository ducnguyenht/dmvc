using DMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMVC.Controllers
{
    public class StudentsController : Controller
    {
        public static List<Student> studentList;
        // GET: Students
        public ActionResult Index()
        {
            if (studentList==null)
            {
                studentList = new List<Student>{ 
                            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                            new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                            new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 } 
                        };
            }
            
            return View(studentList);
        }

        // GET: Students/Details/5
        public ActionResult Details(int id)
        {
            var student = studentList.Where(o=>o.StudentId == id).FirstOrDefault();
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                // TODO: Add insert logic here
                student.StudentId = studentList.Count() + 1;
                studentList.Add(student);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = studentList.Where(o => o.StudentId == id).FirstOrDefault();
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);   
        }

        // POST: Students/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                int index = studentList.FindLastIndex(o => o.StudentId == id);
                if(index != -1)
                {
                    studentList[index] = student;
                }
                //var employee = studentList.Where(o => o.StudentId == id).FirstOrDefault();
                //studentList.Remove(employee);
                //studentList.Add(student);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Students/Delete/5
        //public ActionResult Delete(int id=null)
        //{
        //    Student employee = studentList.Where(o => o.StudentId == id).FirstOrDefault();
        //    if (employee == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(employee); 
        //}

        // POST: Students/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                Student employee = studentList.Where(o => o.StudentId == id).FirstOrDefault();
                studentList.Remove(employee);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
