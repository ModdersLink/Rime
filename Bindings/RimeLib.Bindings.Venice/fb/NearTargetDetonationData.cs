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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class NearTargetDetonationData : FrostbiteContainer
	{
		[ContainerField(Name: "DetonationRadius", Offset: 0, NameHash: 3488213844, Flags: 49469), LayoutImmutable, Blittable]
		public float DetonationRadius { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "MinDetonationDelay", Offset: 4, NameHash: 1672486355, Flags: 49469), LayoutImmutable, Blittable]
		public float MinDetonationDelay { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "MaxDetonationDelay", Offset: 8, NameHash: 23395725, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxDetonationDelay { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "DetonateNearTarget", Offset: 12, NameHash: 2722241128, Flags: 49325), LayoutImmutable, Blittable]
		public bool DetonateNearTarget { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3488213844:
					DetonationRadius = (float) p_Value;
					break;

				case 1672486355:
					MinDetonationDelay = (float) p_Value;
					break;

				case 23395725:
					MaxDetonationDelay = (float) p_Value;
					break;

				case 2722241128:
					DetonateNearTarget = (bool) p_Value;
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
				case 3488213844:
					return DetonationRadius;

				case 1672486355:
					return MinDetonationDelay;

				case 23395725:
					return MaxDetonationDelay;

				case 2722241128:
					return DetonateNearTarget;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3488213844:
					return typeof(NearTargetDetonationData).GetProperty(nameof(DetonationRadius));

				case 1672486355:
					return typeof(NearTargetDetonationData).GetProperty(nameof(MinDetonationDelay));

				case 23395725:
					return typeof(NearTargetDetonationData).GetProperty(nameof(MaxDetonationDelay));

				case 2722241128:
					return typeof(NearTargetDetonationData).GetProperty(nameof(DetonateNearTarget));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
