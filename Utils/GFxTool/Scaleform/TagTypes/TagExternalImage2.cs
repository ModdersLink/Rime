using System.Diagnostics.CodeAnalysis;
using GFxTool.Scaleform.Extension;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace GFxTool.Scaleform.TagTypes
{
	public class TagExternalImage2
		: IFbSerializable
	{
		private uint ImageId { get; set; }
		private uint ImageFormat { get; set; }

		private ushort Width { get; set; }
		private ushort Height { get; set; }

		private string ExportName { get; set; }
		private string FileName { get; set; }

		private bool PackImage { get; set; }


		public TagExternalImage2(RimeReader p_Reader)
		{
			Deserialize(p_Reader);
		}
		public void Deserialize(RimeReader p_Reader)
		{
			ImageId = p_Reader.ReadUInt32();

			ImageFormat = p_Reader.ReadUInt16();
			
			Width = p_Reader.ReadUInt16();
			Height = p_Reader.ReadUInt16();

			ExportName = p_Reader.ReadSwfString();

			FileName = p_Reader.ReadSwfString();

			// related to image packing.
			PackImage = p_Reader.ReadBool();

		}

		public bool Serialize(RimeWriter p_Writer)
		{

			

			return true;
		}
		
		

		public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
		{
			var s_Stream = new MemoryStream();
			using var s_Writer = new RimeWriter(s_Stream);

			if (Serialize(s_Writer))
			{
				p_Data = s_Stream.ToArray();
				return true;
			}

			p_Data = null;
			return false;
		}


		public void Deserialize(byte[] p_Data)
		{
			using var s_Reader = new RimeReader(new MemoryStream(p_Data));
			Deserialize(s_Reader);
		}
	}
}