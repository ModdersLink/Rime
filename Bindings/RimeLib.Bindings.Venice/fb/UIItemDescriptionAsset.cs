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
	public class UIItemDescriptionAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<UIItemDescriptionAsset>> Children { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<UIItemDescription>> Items { get; set; } = new();

		public static void Deserialize(UIItemDescriptionAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Children.Clear();
			(RimeReader Reader, uint Count) s_Children = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Children.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UIItemDescriptionAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Children.Reader.ReadUInt32()));
				p_Instance.Children.Add(s_CtrRef);
			}
			
			s_Children.Reader.Dispose();
			p_Instance.Items.Clear();
			(RimeReader Reader, uint Count) s_Items = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Items.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UIItemDescription>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Items.Reader.ReadUInt32()));
				p_Instance.Items.Add(s_CtrRef);
			}
			
			s_Items.Reader.Dispose();
		}

	}
}
