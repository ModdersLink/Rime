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
	public class MixerPresetGroupData
	{
		[ContainerField(0)]
		public CtrRef<MixGroup> Group { get; set; } = new();
		
		[ContainerField(4)]
		public MixGroupState State { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float AttackTime { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float ReleaseTime { get; set; }
		
		[ContainerField(16)]
		public List<MixGroupPropertyValue> Properties { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool IsDominant { get; set; }
		
		public static void Deserialize(MixerPresetGroupData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Group.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.State = (MixGroupState) p_Reader.ReadInt32();
			p_Instance.AttackTime = p_Reader.ReadSingle();
			p_Instance.ReleaseTime = p_Reader.ReadSingle();
			p_Instance.Properties.Clear();
			(RimeReader Reader, uint Count) s_Properties = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Properties.Count; ++i)
			{
				var s_Value = new MixGroupPropertyValue();
				fb.MixGroupPropertyValue.Deserialize(s_Value, s_Properties.Reader, p_Parser);
				p_Instance.Properties.Add(s_Value);
			}
			
			s_Properties.Reader.Dispose();
			p_Instance.IsDominant = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
