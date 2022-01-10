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
	[ContainerType(16, 176)]
	public class SoldierEmoteComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SoldierEmoteBinding Binding { get; set; } = new();

		[ContainerField(160)]
		public List<CtrRef<SoldierEmoteNetworkedMessageMapping>> NetworkedMessageMappings { get; set; } = new();

		public static void Deserialize(SoldierEmoteComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.SoldierEmoteBinding.Deserialize(p_Instance.Binding, p_Reader, p_Parser);
			p_Instance.NetworkedMessageMappings.Clear();
			(RimeReader Reader, uint Count) s_NetworkedMessageMappings = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_NetworkedMessageMappings.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoldierEmoteNetworkedMessageMapping>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_NetworkedMessageMappings.Reader.ReadUInt32()));
				p_Instance.NetworkedMessageMappings.Add(s_CtrRef);
			}
			
			s_NetworkedMessageMappings.Reader.Dispose();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
