using System.Collections.Generic;
using System.IO;
using System.Text;
using RimeLib.IO;

namespace RimeLib.Utils;

public class RiffFile
{
	public class Chunk
	{
		
		// a riff chunk should be 2 byte aligned..
		public uint Tag { get; set; }
		public byte[] Data { get; set; } = new byte[0];


		public string TagStr {
			get
			{
				return Encoding.ASCII.GetString(new byte[4]
				{
					(byte)((Tag >> (8 * 0)) & 0xFF),
					(byte)((Tag >> (8 * 1)) & 0xFF),
					(byte)((Tag >> (8 * 2)) & 0xFF),
					(byte)((Tag >> (8 * 3)) & 0xFF),
				});
			}
			set
			{
				Tag = 0;
				
				var s_Bytes = Encoding.ASCII.GetBytes(value);
				for (var s_Index = 0; s_Index < System.Math.Min(s_Bytes.Length, 4); s_Index++)
					Tag |= ((uint)s_Bytes[s_Index] << (s_Index * 8));
			}
		}


		public uint TotalSize => (uint)Data.Length + 4;

		public void Deserialize(RimeReader p_Reader)
		{
			Tag = p_Reader.ReadUInt32();
			
			var s_Size = p_Reader.ReadUInt32();
			
			var s_Align = ((uint)s_Size & 1);
			if (s_Align != 0)
				s_Size += s_Align;
			
			Data = p_Reader.ReadBytes((int) s_Size);
		}

		public void Serialize(RimeWriter p_Writer)
		{
			p_Writer.Write(Tag);

			var s_Size = (uint)Data.Length;
			
			var s_Align = (s_Size & 1);
			if (s_Align != 0)
				s_Size += s_Align;
			
			p_Writer.Write(s_Size);
			p_Writer.Write(Data);
			p_Writer.WriteNullBytes(s_Align);
		}
	}


	private static readonly uint c_MagicLittle = 0x46464952;

	public uint Type { get; set; }
	public string TypeStr {
		get
		{
			return Encoding.ASCII.GetString(new byte[4]
			{
				(byte)((Type >> (8 * 0)) & 0xFF),
				(byte)((Type >> (8 * 1)) & 0xFF),
				(byte)((Type >> (8 * 2)) & 0xFF),
				(byte)((Type >> (8 * 3)) & 0xFF),
			});
		}
		set
		{
			Type = 0;
			
			var s_Bytes = Encoding.ASCII.GetBytes(value);
			for (var s_Index = 0; s_Index < System.Math.Min(s_Bytes.Length, 4); s_Index++)
				Type |= ((uint)s_Bytes[s_Index] << (s_Index * 8));
		}
	}

	public List<Chunk> Chunks { get; set; } = new();


	public void Add(string p_Chunk, byte[] p_Data)
	{
		Chunks.Add(new Chunk()
		{
			TagStr = p_Chunk,
			Data = p_Data
		});
	}


	public void Deserialize(RimeReader p_Reader)
	{
		var s_Magic = p_Reader.ReadUInt32();

		if (s_Magic != c_MagicLittle)
			throw new InvalidDataException("RIFF file is not a little endian riff file!");
		
		
		var s_Size = p_Reader.ReadUInt32();
		Type = p_Reader.ReadUInt32();

		uint s_Offset = 0;
		while (s_Offset < s_Size)
		{
			var s_Chunk = new Chunk();
			s_Chunk.Deserialize(p_Reader);

			Chunks.Add(s_Chunk);
			
			s_Offset += s_Chunk.TotalSize;
		}
	}
	
	public void Serialize(RimeWriter p_Writer)
	{
		using var s_ChunksStream = new MemoryStream();
		using var s_ChunkStreamWriter = new RimeWriter(s_ChunksStream);

		foreach (var s_Chunk in Chunks)
			s_Chunk.Serialize(s_ChunkStreamWriter);
			
		
		p_Writer.Write(c_MagicLittle);
		p_Writer.Write((uint)s_ChunksStream.Position);
		p_Writer.Write(Type);

		s_ChunksStream.Seek(0, SeekOrigin.Begin);
		s_ChunksStream.CopyTo(p_Writer);
	}
}