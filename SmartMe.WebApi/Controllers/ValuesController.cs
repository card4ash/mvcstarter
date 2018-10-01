using log4net;
using SmartMe.Services.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartMe.WebApi.Controllers
{
  public class ValuesController : ApiController
  {
    // GET api/values
    ILog log = log4net.LogManager.GetLogger(typeof(HomeController));
    private readonly IBookService _bookService;

    public ValuesController(
    IBookService bookService)
    {
      _bookService = bookService;
    }
    public IHttpActionResult Get()
    {
      var x = _bookService.GetAllBooks();
      return Ok(x);
    }

    // GET api/values/5
    public string Get(int id)
    {
      return "value";
    }

    // POST api/values
    public void Post([FromBody]string value)
    {
    }

    // PUT api/values/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    public void Delete(int id)
    {
    }
  }
}
