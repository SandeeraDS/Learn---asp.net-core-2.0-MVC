using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {
        [Route("")] //when see the /about direct to PhoneController
        public string Phone() {
            return "07788136950";
        }

        [Route("[action]")]
        public string Address()
        {
            return "dsd,dsds,dsdsd,dsdsdsdsdsd";
        }
    }
}
