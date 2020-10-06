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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(20), ContainerStruct]
	public class GunSwayLagData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MoveStrafeModifier { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MoveForwardModifier { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RotateYawModifier { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RotatePitchModifier { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float ReleaseModifier { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3886718324:
					MoveStrafeModifier = (float) p_Value;
					break;

				case 3166800568:
					MoveForwardModifier = (float) p_Value;
					break;

				case 2055262564:
					RotateYawModifier = (float) p_Value;
					break;

				case 3243027341:
					RotatePitchModifier = (float) p_Value;
					break;

				case 2602876219:
					ReleaseModifier = (float) p_Value;
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
				case 3886718324:
					return MoveStrafeModifier;

				case 3166800568:
					return MoveForwardModifier;

				case 2055262564:
					return RotateYawModifier;

				case 3243027341:
					return RotatePitchModifier;

				case 2602876219:
					return ReleaseModifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3886718324:
					return typeof(GunSwayLagData).GetProperty(nameof(MoveStrafeModifier));

				case 3166800568:
					return typeof(GunSwayLagData).GetProperty(nameof(MoveForwardModifier));

				case 2055262564:
					return typeof(GunSwayLagData).GetProperty(nameof(RotateYawModifier));

				case 3243027341:
					return typeof(GunSwayLagData).GetProperty(nameof(RotatePitchModifier));

				case 2602876219:
					return typeof(GunSwayLagData).GetProperty(nameof(ReleaseModifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
