using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KharkivPhotoes.Controllers
{
    [Produces("application/json")]
    [Route("api/KharkivPhotoes")]
    public class KharkivPhotoesController : Controller
    {
        public void PhotoDelete(int photoId)
        {

        }
    }
}