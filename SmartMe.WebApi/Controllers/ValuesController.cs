using log4net;
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
    public IEnumerable<string> Get()
    {
      log.Debug("Debug message");
      log.Warn("Warn message");
      log.Error("Error message");
      log.Fatal("Fatal message");
      return new string[] { "value1", "value2" };
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
