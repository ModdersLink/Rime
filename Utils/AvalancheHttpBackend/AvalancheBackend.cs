using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Web;
using System.Linq;
using AvalancheHttpBackend.Backend;
using RimeLib.Content.Mounting;

namespace AvalancheHttpBackend
{
	public class AvalancheBackend
	{
		public AvalancheBackend(string p_Database)
		{
			DatabaseId = p_Database;
		}

		private string DatabaseId { get; set; }

		public Dictionary<string, IBackendHandler> Handlers { get; set; } = new();

		public void Start()
		{
			var s_Listener = new HttpListener();
            s_Listener.Prefixes.Add("http://*:1338/");
            s_Listener.Start();
            
            while (true)
            {
                var s_Ctx = s_Listener.GetContext();

                ThreadPool.QueueUserWorkItem((_) =>
                {
                    Console.WriteLine(s_Ctx.Request.Url);
                    
                    var s_Segments = s_Ctx.Request.Url.Segments;

                    if (s_Segments.Length < 4)
                    {
                        s_Ctx.Response.Close();
                        return;
                    }
                    if (s_Segments[1].Replace("/", "").ToLower() != "db")
                    {
                        s_Ctx.Response.Close();
                        return;
                    }


                    // application/directory = Dir
                    
                    // this would be "VeniceXpack5RetailPc" in this case
                    var s_Database = s_Segments[2].Replace("/", "");
                    if (s_Database.ToLower() != DatabaseId.ToLower())
                    {
	                    s_Ctx.Response.Close();
	                    return;
                    }
                    
                    // layout - sends layout.toc. probably not used?
                    // fs - should link to game Data dir. Only Data/win32_initfs should be used. 
                    
                    // chunks - has support for "offset" and "length" url paths. 
                    // bundles - Mounted as /bundles. Might be dbx/xml?
                    // bundlesEbx - Mounted as /bundles. This should be path to raw ebx file.
                    var s_RequestType = s_Segments[3].Replace("/", "").ToLower();


                    var s_RestUrl = "";

                    if (s_Segments.Length > 4)
	                    s_RestUrl = string.Join("", s_Segments.Skip(4));
                    
                    var s_Params = HttpUtility.ParseQueryString(s_Ctx.Request.Url.Query);
                    
                    
                    Console.WriteLine(s_RestUrl);
                    Console.WriteLine(s_Params);
                    Console.WriteLine();
                    
					if (Handlers.TryGetValue(s_RequestType, out var s_Handler))
						s_Handler.Request(s_Ctx, s_RestUrl, s_Params);
					else
						s_Ctx.Response.Close();
                });
            }
		}
	}
}