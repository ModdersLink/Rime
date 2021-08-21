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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 24)]
	public class MixerPresetGroupData : FrostbiteContainer
	{
		[ContainerField(Name: "Group", Offset: 0, NameHash: 208130522, Flags: 53)]
		public CtrRef<MixGroup> Group { get; set; } = new CtrRef<MixGroup>(); // 0x0 (0)
		
		[ContainerField(Name: "State", Offset: 4, NameHash: 230748402, Flags: 137)]
		public MixGroupState State { get; set; } = new MixGroupState(); // 0x4 (4)
		
		[ContainerField(Name: "AttackTime", Offset: 8, NameHash: 1150936440, Flags: 49469), LayoutImmutable, Blittable]
		public float AttackTime { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "ReleaseTime", Offset: 12, NameHash: 892319833, Flags: 49469), LayoutImmutable, Blittable]
		public float ReleaseTime { get; set; } // 0xC (12)
		
		[ContainerField(Name: "Properties", Offset: 16, NameHash: 1506334468, Flags: 65)]
		public List<MixGroupPropertyValue> Properties { get; set; } = new List<MixGroupPropertyValue>(); // 0x10 (16)
		
		[ContainerField(Name: "IsDominant", Offset: 20, NameHash: 2046817989, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsDominant { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 208130522:
					Group = (CtrRef<MixGroup>) p_Value;
					break;

				case 230748402:
						State = (MixGroupState) Enum.ToObject(typeof(MixGroupState), p_Value);
					break;

				case 1150936440:
					AttackTime = (float) p_Value;
					break;

				case 892319833:
					ReleaseTime = (float) p_Value;
					break;

				case 1506334468:
					Properties = (List<MixGroupPropertyValue>) p_Value;
					break;

				case 2046817989:
					IsDominant = (bool) p_Value;
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
				case 208130522:
					return Group;

				case 230748402:
					return State;

				case 1150936440:
					return AttackTime;

				case 892319833:
					return ReleaseTime;

				case 1506334468:
					return Properties;

				case 2046817989:
					return IsDominant;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 208130522:
					return typeof(MixerPresetGroupData).GetProperty(nameof(Group));

				case 230748402:
					return typeof(MixerPresetGroupData).GetProperty(nameof(State));

				case 1150936440:
					return typeof(MixerPresetGroupData).GetProperty(nameof(AttackTime));

				case 892319833:
					return typeof(MixerPresetGroupData).GetProperty(nameof(ReleaseTime));

				case 1506334468:
					return typeof(MixerPresetGroupData).GetProperty(nameof(Properties));

				case 2046817989:
					return typeof(MixerPresetGroupData).GetProperty(nameof(IsDominant));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
