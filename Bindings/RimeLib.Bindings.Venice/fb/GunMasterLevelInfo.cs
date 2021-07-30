///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class GunMasterLevelInfo : FrostbiteContainer
	{
		[ContainerField(Name: "CustomizeData", Offset: 0, NameHash: 1994334608, Flags: 53)]
		public CtrRef<CustomizeSoldierData> CustomizeData { get; set; } = new CtrRef<CustomizeSoldierData>(); // 0x0 (0)
		
		[ContainerField(Name: "KillsNeeded", Offset: 4, NameHash: 2408595391, Flags: 49405), LayoutImmutable, Blittable]
		public int KillsNeeded { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1994334608:
					CustomizeData = (CtrRef<CustomizeSoldierData>) p_Value;
					break;

				case 2408595391:
					KillsNeeded = (int) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1994334608:
					return CustomizeData;

				case 2408595391:
					return KillsNeeded;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1994334608:
					return typeof(GunMasterLevelInfo).GetProperty(nameof(CustomizeData));

				case 2408595391:
					return typeof(GunMasterLevelInfo).GetProperty(nameof(KillsNeeded));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
