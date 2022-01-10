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
	[ContainerType(4, 36)]
	public class PrefabBlueprint : 
		Blueprint
	{
		[ContainerField(32)]
		public List<CtrRef<GameObjectData>> Objects { get; set; } = new();

		public static void Deserialize(PrefabBlueprint p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Objects.Clear();
			(RimeReader Reader, uint Count) s_Objects = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Objects.Count; ++i)
			{
				var s_CtrRef = new CtrRef<GameObjectData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Objects.Reader.ReadUInt32()));
				p_Instance.Objects.Add(s_CtrRef);
			}
			
			s_Objects.Reader.Dispose();
		}

	}
}
