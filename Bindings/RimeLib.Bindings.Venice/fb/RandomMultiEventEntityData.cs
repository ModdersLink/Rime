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
	public class RandomMultiEventEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16)]
		public List<float> RandomEventWeight { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool UniformDistribution { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool ResetOutputsWhenAllHasTriggered { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public bool DisableOutputOnTrigger { get; set; }

		public static void Deserialize(RandomMultiEventEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.RandomEventWeight.Clear();
			(RimeReader Reader, uint Count) s_RandomEventWeight = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_RandomEventWeight.Count; ++i)
			{
				var s_Value = s_RandomEventWeight.Reader.ReadSingle();
				p_Instance.RandomEventWeight.Add(s_Value);
			}
			
			s_RandomEventWeight.Reader.Dispose();
			p_Instance.UniformDistribution = p_Reader.ReadBool();
			p_Instance.ResetOutputsWhenAllHasTriggered = p_Reader.ReadBool();
			p_Instance.DisableOutputOnTrigger = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
