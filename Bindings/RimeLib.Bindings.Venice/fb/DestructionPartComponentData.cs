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
	public class DestructionPartComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public List<CtrRef<GameObjectData>> Objects { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public uint PartIndex { get; set; }

		[ContainerField(104)]
		public DestructionConnectivityType ConnectivityType { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool Fixed { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool Fragile { get; set; }

		public static void Deserialize(DestructionPartComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
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
			p_Instance.PartIndex = p_Reader.ReadUInt32();
			p_Instance.ConnectivityType = (DestructionConnectivityType) p_Reader.ReadInt32();
			p_Instance.Fixed = p_Reader.ReadBool();
			p_Instance.Fragile = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
