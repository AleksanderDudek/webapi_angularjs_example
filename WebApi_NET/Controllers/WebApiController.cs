using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_NET.Models;
using WebApi_NET.Repositories;

namespace WebApi_NET.Controllers
{
    public class WebApiController : ApiController
    {

        private ParcelRepository _repo;
       

        public WebApiController()
        {
            _repo = new ParcelRepository();
        }


       

        // GET: api/WebApi
        public IEnumerable<Parcel> Get()
        {
            var parcels = _repo.GetAllParcels();
            return parcels;
        }

       
        // POST: api/WebApi
        public HttpResponseMessage Post([FromBody]Parcel model)
        {

            //model.Id = (int)_repo.GetAllParcels().Count<Parcel>() + 1;

            if (ModelState.IsValid)
            {
                model.RegistrationDate = DateTime.Now;

                _repo.Add(model); 
                _repo.SaveChanges();
                var response = Request.CreateResponse<Parcel>(HttpStatusCode.Created, model);
                string uri = Url.Route(null, new { id = model.Id });
                response.Headers.Location = new Uri(Request.RequestUri, uri);
                return response;
            }
            else
            {
                var response = Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                return response;
            }
        }

      
    }
}
