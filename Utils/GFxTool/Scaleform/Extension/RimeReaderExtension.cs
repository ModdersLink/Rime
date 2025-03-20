using RimeLib.IO;

namespace GFxTool.Scaleform.Extension
{
	public static class RimeReaderExtension
	{
		public static string ReadSwfString(this RimeReader p_Reader)
		{
			var s_StringLength = p_Reader.ReadByte();

			return p_Reader.ReadFixedLengthString(s_StringLength);
		}
	}
}