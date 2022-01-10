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
	[ContainerType(4, 20)]
	public class UIColorTemplate : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<UIColor>> Colors { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public bool Active { get; set; }

		public static void Deserialize(UIColorTemplate p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Colors.Clear();
			(RimeReader Reader, uint Count) s_Colors = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Colors.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UIColor>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Colors.Reader.ReadUInt32()));
				p_Instance.Colors.Add(s_CtrRef);
			}
			
			s_Colors.Reader.Dispose();
			p_Instance.Active = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
