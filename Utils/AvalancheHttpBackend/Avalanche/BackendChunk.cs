using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using AvalancheHttpBackend.Backend;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;

namespace AvalancheHttpBackend.Avalanche
{
	public class BackendChunk
		: BackendFsHandler
	{
		public BackendChunk(IEngineMounter p_Engine)
		{
			Engine = p_Engine;
		}

		private IEngineMounter Engine { get; set; }

		// CSV 
		public override void RequestFiles(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params)
		{
		

			p_Ctx.Response.StatusCode = (int) HttpStatusCode.OK;
			SetHeaderInfo(p_Ctx.Response);

			p_Ctx.Response.Close();
		}
		
		// Header only
		public override void RequestInfo(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params)
		{
			var s_Guid = new GUID(p_Path);
			
			if (!Engine.TryGetChunk(s_Guid, out var s_Chunk))
			{
				p_Ctx.Response.StatusCode = (int) HttpStatusCode.NotFound;
				p_Ctx.Response.Close();
				return;
			}

			long s_Offset = 0;
			long s_Length = s_Chunk.FirstVariant.GetSize();

			if (p_Params.Get("offset") != null)
			{
				if (!long.TryParse(p_Params.Get("offset")!, out s_Offset))
				{
					p_Ctx.Response.StatusCode = (int) HttpStatusCode.BadRequest;
					
					p_Ctx.Response.OutputStream.Write(Encoding.ASCII.GetBytes($"Invalid offset [{p_Params.Get("offset")!}]"));
					p_Ctx.Response.Close();
					return;
				}
			}
			
			if (p_Params.Get("length") != null)
			{
				if (!long.TryParse(p_Params.Get("length")!, out s_Length))
				{
					p_Ctx.Response.StatusCode = (int) HttpStatusCode.BadRequest;
					
					p_Ctx.Response.OutputStream.Write(Encoding.ASCII.GetBytes($"Invalid length [{p_Params.Get("length")!}]"));
					p_Ctx.Response.Close();
					return;
				}
			}


			s_Length = Math.Min(s_Length, s_Chunk.FirstVariant.GetSize() - s_Offset);

			SetHeaderInfo(p_Ctx.Response, s_Length);

			p_Ctx.Response.Close();
		}
		
		
		// Delete..
		public override void RequestDelete(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params)
		{
			Console.WriteLine("Got delete request!");
			
			p_Ctx.Response.StatusCode = (int) HttpStatusCode.OK;
			SetHeaderInfo(p_Ctx.Response);
			
			p_Ctx.Response.Close();

		}

		public override void RequestPut(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params)
		{
			// This should basicly be a file relase thing.
			
			Console.WriteLine("Got delete request!");
			
			p_Ctx.Response.StatusCode = (int) HttpStatusCode.OK;
			SetHeaderInfo(p_Ctx.Response);
			
			p_Ctx.Response.Close();
		}
		
		// Header + Data
		public override void RequestGet(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params)
		{
			var s_Guid = new GUID(p_Path);
			
			if (!Engine.TryGetChunk(s_Guid, out var s_Chunk))
			{
				p_Ctx.Response.StatusCode = (int) HttpStatusCode.NotFound;
				p_Ctx.Response.Close();
				return;
			}

			long s_Offset = 0;
			long s_Length = s_Chunk.FirstVariant.GetSize();

			if (p_Params.Get("offset") != null)
			{
				if (!long.TryParse(p_Params.Get("offset")!, out s_Offset))
				{
					p_Ctx.Response.StatusCode = (int) HttpStatusCode.BadRequest;
					
					p_Ctx.Response.OutputStream.Write(Encoding.ASCII.GetBytes($"Invalid offset [{p_Params.Get("offset")!}]"));
					p_Ctx.Response.Close();
					return;
				}
			}
			
			if (p_Params.Get("length") != null)
			{
				if (!long.TryParse(p_Params.Get("length")!, out s_Length))
				{
					p_Ctx.Response.StatusCode = (int) HttpStatusCode.BadRequest;
					
					p_Ctx.Response.OutputStream.Write(Encoding.ASCII.GetBytes($"Invalid length [{p_Params.Get("length")!}]"));
					p_Ctx.Response.Close();
					return;
				}
			}


			s_Length = Math.Min(s_Length, s_Chunk.FirstVariant.GetSize() - s_Offset);

			SetHeaderInfo(p_Ctx.Response, s_Length);

			var s_FileReader = s_Chunk.FirstVariant.GetReader();
			s_FileReader.Seek(s_Offset, SeekOrigin.Begin);

			var s_Data = s_FileReader.ReadBytes((int) s_Length);

			// Hope this works.
			p_Ctx.Response.OutputStream.Write(s_Data);
			p_Ctx.Response.Close();
		}



		private void SetHeaderInfo(HttpListenerResponse p_Response, long p_Length = 0, bool p_IsDirectory = false)
		{
			
			if (p_IsDirectory)
				p_Response.ContentType = "application/directory";
			else
				p_Response.ContentType = "application/octet-stream";

			p_Response.ContentLength64 = p_Length;
		}
	}
}