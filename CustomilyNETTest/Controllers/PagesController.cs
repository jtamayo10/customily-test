using CustomilyNETTest.AccessData;
using CustomilyNETTest.Models;
using CustomilyNETTest.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomilyNETTest.Controllers
{
    public class PagesController : ApiController
    {
        // GET: api/Pages
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pages/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pages
        public IHttpActionResult Post([FromBody]Item value)
        {
            try
            {
                var context = new AppicationContext();
                context.Items.Add(value);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
            return Ok();       
        }

        [HttpPost]
        [Route("api/pages/GetByPosition/")]
        public IHttpActionResult GetByPosition([FromBody] PositionRequest value)
        {
            var context = new AppicationContext();
            var imagesQuery = (from item in context.Items
                             join img in context.Images on item.Id equals img.ItemId
                               where img.X >= value.X && img.Y >= value.Y
                             select item.Title).ToList();

            var textsQuery = (from item in context.Items
                             join txt in context.Texts on item.Id equals txt.ItemId
                              where txt.X >= value.X && txt.Y >= value.Y
                             select item.Title).ToList();

            var result = imagesQuery.Concat(textsQuery);

            return Ok(result.Distinct().ToList());
        }

        // PUT: api/Pages/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pages/5
        public void Delete(int id)
        {
        }
    }
}
