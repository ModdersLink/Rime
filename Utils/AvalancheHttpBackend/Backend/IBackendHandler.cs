using System.Collections.Specialized;
using System.Net;

namespace AvalancheHttpBackend.Backend
{
	public interface IBackendHandler
	{
		void Request(HttpListenerContext p_Ctx, string p_LeftPath, NameValueCollection p_Params);
	}
}