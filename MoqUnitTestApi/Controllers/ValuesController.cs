using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MoqUnitTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {

        }
        private readonly IMessageManager messageManager;
        public ValuesController(IMessageManager messageManager)
        {
            this.messageManager = messageManager;
        }


        public string Message()
        {
            int sum = this.messageManager.Add(5, 10);
            if(sum > 5)
            {
                return "Values greater than 5";
            }
            else
            {
                return "Values less than 5";
            }
            
        }
    }
}
