using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// Descrição resumida de Handler
    /// </summary>
    public class Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "texto/simples";
            context.Response.Write("Olá, Mundo");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}