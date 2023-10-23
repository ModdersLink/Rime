using System;
using System.Collections.Specialized;
using System.Net;

namespace AvalancheHttpBackend.Backend
{
	public abstract class BackendFsHandler
		: IBackendHandler
	{
		
		// CSV 
		public abstract void RequestFiles(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params);
		
		// Header only
		public abstract void RequestInfo(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params);
		
		
		// Delete..
		public abstract void RequestDelete(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params);
		public abstract void RequestPut(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params);
		// Header + Data
		public abstract void RequestGet(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params);
		
		public void Request(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params)
		{

			switch (p_Ctx.Request.HttpMethod)
			{
				case "GET":
					if (p_Params.Get("query-dir")?.Equals("1") ?? true)
						RequestFiles(p_Ctx, p_Path, p_Params);
					else
						RequestGet(p_Ctx, p_Path, p_Params);
					
					break;
				case "PUT":
					RequestPut(p_Ctx, p_Path, p_Params);
					break;
				case "HEAD":
					RequestInfo(p_Ctx, p_Path, p_Params);
					break;
				case "DELETE":
					RequestDelete(p_Ctx, p_Path, p_Params);
					break;
				
				default:
					Console.WriteLine($"Unknown request {p_Ctx.Request.HttpMethod}");
					break;
			}
		}
	}
}