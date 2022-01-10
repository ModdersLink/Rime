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
	public class EffectEntityData : 
		SpatialEntityData
	{
		[ContainerField(80)]
		public List<CtrRef<GameObjectData>> Components { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public uint MaxInstanceCount { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float CullDistance { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float StartDelay { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool HighEndPc { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable]
		public bool MediumPc { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable]
		public bool LowEndPc { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable]
		public bool ResetInstanceWhenStarted { get; set; }

		public static void Deserialize(EffectEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Components.Clear();
			(RimeReader Reader, uint Count) s_Components = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Components.Count; ++i)
			{
				var s_CtrRef = new CtrRef<GameObjectData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Components.Reader.ReadUInt32()));
				p_Instance.Components.Add(s_CtrRef);
			}
			
			s_Components.Reader.Dispose();
			p_Instance.MaxInstanceCount = p_Reader.ReadUInt32();
			p_Instance.CullDistance = p_Reader.ReadSingle();
			p_Instance.StartDelay = p_Reader.ReadSingle();
			p_Instance.HighEndPc = p_Reader.ReadBool();
			p_Instance.MediumPc = p_Reader.ReadBool();
			p_Instance.LowEndPc = p_Reader.ReadBool();
			p_Instance.ResetInstanceWhenStarted = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
