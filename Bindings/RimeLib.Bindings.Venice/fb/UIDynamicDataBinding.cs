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
	[ContainerType(4, 16)]
	public class UIDynamicDataBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public List<UIDataSourceInfo> Bindings { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public bool Refresh { get; set; }

		public static void Deserialize(UIDynamicDataBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Bindings.Clear();
			(RimeReader Reader, uint Count) s_Bindings = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Bindings.Count; ++i)
			{
				var s_Value = new UIDataSourceInfo();
				fb.UIDataSourceInfo.Deserialize(s_Value, s_Bindings.Reader, p_Parser);
				p_Instance.Bindings.Add(s_Value);
			}
			
			s_Bindings.Reader.Dispose();
			p_Instance.Refresh = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
