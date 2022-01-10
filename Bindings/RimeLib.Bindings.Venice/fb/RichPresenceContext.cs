///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class RichPresenceContext : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12)]
		public List<CtrRef<RichPresenceContextValue>> Values { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<RichPresenceContextValue> DefaultValue { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public sbyte Index { get; set; }

		public static void Deserialize(RichPresenceContext p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Values.Clear();
			(RimeReader Reader, uint Count) s_Values = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Values.Count; ++i)
			{
				var s_CtrRef = new CtrRef<RichPresenceContextValue>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Values.Reader.ReadUInt32()));
				p_Instance.Values.Add(s_CtrRef);
			}
			
			s_Values.Reader.Dispose();
			p_Instance.DefaultValue.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Index = p_Reader.ReadSByte();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
