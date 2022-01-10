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
	[ContainerType(16, 224)]
	public class SoldierEntryComponentData : 
		EntryComponentData
	{
		[ContainerField(192)]
		public AimingConstraintsData AimingConstraints { get; set; } = new();

		[ContainerField(208)]
		public CtrRef<AntEnumeration> AntEntryEnumeration { get; set; } = new();

		[ContainerField(212), LayoutImmutable, Blittable]
		public bool AlignConstraintsToEntity { get; set; }

		public static void Deserialize(SoldierEntryComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AimingConstraintsData.Deserialize(p_Instance.AimingConstraints, p_Reader, p_Parser);
			p_Instance.AntEntryEnumeration.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AlignConstraintsToEntity = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
