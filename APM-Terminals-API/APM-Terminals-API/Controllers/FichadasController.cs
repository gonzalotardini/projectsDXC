using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APM_Terminals_API.Controllers
{
   
    public class FichadasController : ApiController
    {

        [HttpGet]
        [ActionName("File")]
        public string File(string param1, string param2)
        {
            FichadasBLL fichadasBll = new FichadasBLL();
            return fichadasBll.ObtenerFichadas();
        }

        // GET: api/Fichadas

        [HttpGet]
        [ActionName("Hola")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Fichadas/5
       
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Fichadas
        
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Fichadas/5
      
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Fichadas/5
       
        public void Delete(int id)
        {
        }
    }
}
