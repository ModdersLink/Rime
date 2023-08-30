using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using AvalancheHttpBackend.Backend;
using RimeLib;
using RimeLib.Content.Building;
using RimeLib.Content.Mounting;

namespace AvalancheHttpBackend.Avalanche
{
	public class BackendBundleEbx
		: BackendFsHandler
	{
		public BackendBundleEbx(IEngineMounter p_Engine)
		{
			Engine = p_Engine;
		}

		private IEngineMounter Engine { get; set; }

		// CSV 
		public override void RequestFiles(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params)
		{
			var s_Files = Engine.GetPartitions().Where(x => x.Key.StartsWith(p_Path.ToLower()) && x.Key != p_Path.ToLower());


			var s_TempStream = new MemoryStream();

			foreach (var s_Entry in s_Files)
			{
				var s_FixedPath = s_Entry.Key.Substring(p_Path.Length);
				if (s_FixedPath.Length == 0)
					continue;

				if (s_FixedPath[0] == '/')
					s_FixedPath = s_FixedPath.Substring(1);
				
				
				
				if (s_FixedPath.Contains("/"))
					s_TempStream.Write(Encoding.ASCII.GetBytes( $"{s_FixedPath}\n"));
				else
					s_TempStream.Write(Encoding.ASCII.GetBytes( $"{s_FixedPath},{s_Entry.Value.FirstVariant.GetSize()}\n"));

			}

			p_Ctx.Response.StatusCode = (int) HttpStatusCode.OK;
			SetHeaderInfo(p_Ctx.Response, s_TempStream.Length);
			
			// Hope this works.
			p_Ctx.Response.OutputStream.CopyToAsync(s_TempStream).ContinueWith((_) => p_Ctx.Response.Close());
		}
		
		// Header only
		public override void RequestInfo(HttpListenerContext p_Ctx, string p_Path, NameValueCollection p_Params)
		{
			//TODO: Handle directories. filetree probably takes extra memory. not really needed.
			
			//if (!Engine.GetMountedBundles().Contains(p_Path.ToLower()))
			{
				p_Ctx.Response.StatusCode = (int) HttpStatusCode.NotFound;
				p_Ctx.Response.Close();
				return;
			}

			/*
			var s_Descriptor = new BundleDescriptor(p_Path);
			//s_Descriptor.Partitions.Add(Engine.GetPartitionsInBundle(p_Path.ToLower()));
			
			var s_Builder = new BundleManifestBuilder(s_Descriptor);
			s_Builder.Serialize(p_SbWriter);
			
			p_Ctx.Response.StatusCode = (int) HttpStatusCode.OK;

			SetHeaderInfo(p_Ctx.Response, s_Partition.FirstVariant.GetSize());

			p_Ctx.Response.Close();
			*/
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
			if (!Engine.TryGetPartition(p_Path, out var s_Partition))
			{
				p_Ctx.Response.StatusCode = (int) HttpStatusCode.NotFound;
				p_Ctx.Response.Close();
				return;
			}

			SetHeaderInfo(p_Ctx.Response, s_Partition.FirstVariant.GetSize());

			var s_FileReader = s_Partition.FirstVariant.GetReader();

			// Hope this works.
			p_Ctx.Response.OutputStream.CopyToAsync(s_FileReader).ContinueWith((_) => p_Ctx.Response.Close());
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