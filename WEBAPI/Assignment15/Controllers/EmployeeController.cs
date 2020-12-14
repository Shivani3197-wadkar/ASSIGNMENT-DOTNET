using Assignment15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment15.Controllers
{
    public class EmployeeController : ApiController
    {
        TrainingDBEntities db = new TrainingDBEntities();
        //api/user
        public IEnumerable<employee> GetUsers()
        {
            return db.employees.ToList();
        }

        [HttpPost]
        public HttpResponseMessage AddUser(employee model)
        {
            try
            {
                db.employees.Add(model);
                db.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }
        }

        [HttpPut]
        public HttpResponseMessage UpdateUser(int id, employee model)
        {
            try
            {
                if (id == model.empno)
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                    return response;
                }
                else
                {
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotModified);
                    return response;
                }
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }
        }

        public HttpResponseMessage DeleteUser(int id)
        {
            employee user = db.employees.Find(id);
            if (user != null)
            {
                db.employees.Remove(user);
                db.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                return response;
            }
            else
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotFound);
                return response;
            }
        }

    }
}

