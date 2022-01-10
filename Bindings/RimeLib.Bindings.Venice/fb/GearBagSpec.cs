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
	public class GearBagSpec : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint MaxPrimaryWeapons { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint MaxSecondaryWeapons { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint MaxSidearms { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MaxGadgetsPerSlot { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint GadgetSlots { get; set; }

		[ContainerField(32)]
		public List<CtrRef<GearBagSpec>> ChildSpecs { get; set; } = new();

		public static void Deserialize(GearBagSpec p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxPrimaryWeapons = p_Reader.ReadUInt32();
			p_Instance.MaxSecondaryWeapons = p_Reader.ReadUInt32();
			p_Instance.MaxSidearms = p_Reader.ReadUInt32();
			p_Instance.MaxGadgetsPerSlot = p_Reader.ReadUInt32();
			p_Instance.GadgetSlots = p_Reader.ReadUInt32();
			p_Instance.ChildSpecs.Clear();
			(RimeReader Reader, uint Count) s_ChildSpecs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ChildSpecs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<GearBagSpec>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ChildSpecs.Reader.ReadUInt32()));
				p_Instance.ChildSpecs.Add(s_CtrRef);
			}
			
			s_ChildSpecs.Reader.Dispose();
		}

	}
}
