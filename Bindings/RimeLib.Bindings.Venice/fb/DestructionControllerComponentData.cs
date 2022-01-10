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
	[ContainerType(16, 112)]
	public class DestructionControllerComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public List<CtrRef<ObjectBlueprint>> DebrisClusters { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool AttachToNearbyObjects { get; set; }

		public static void Deserialize(DestructionControllerComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DebrisClusters.Clear();
			(RimeReader Reader, uint Count) s_DebrisClusters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_DebrisClusters.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ObjectBlueprint>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_DebrisClusters.Reader.ReadUInt32()));
				p_Instance.DebrisClusters.Add(s_CtrRef);
			}
			
			s_DebrisClusters.Reader.Dispose();
			p_Instance.AttachToNearbyObjects = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
