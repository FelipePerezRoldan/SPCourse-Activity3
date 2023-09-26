using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//usar las carpetas model y clases Cors.
using apiSuperMkD.Models;
using apiSuperMkD.Clases;
using System.Web.Http.Cors;
namespace apiSuperMkD.Controllers
{
    public class servSuperMkdController : ApiController
    {
        modSuperMkD objModMdo = new modSuperMkD();
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        //[EnableCors(origins: "http://localhost:numero de puerto de local host", headers: "*", methods: "*")]
        [EnableCors(origins: "https://localhost:44329/", headers: "*", methods: "*")]
        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public modSuperMkD Post([FromBody] modSuperMkD objModIn)//Discgrepa el in con la guia
        {
            clsOpeMdo objOpe = new clsOpeMdo();
            objOpe.objModMdo = objModIn;
            objOpe.hallarDatos();
            return objModMdo;//Discrepa con la guia
        }

        // PUT api/<controller>/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}