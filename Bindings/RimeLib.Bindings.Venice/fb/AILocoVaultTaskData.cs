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
	[ContainerType(16), MemberInfoFlag(41), ContainerSize(48), ContainerStruct]
	public class AILocoVaultTaskData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec3 StartPoint { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float DistanceBeforeVault { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float HeightBeforeVault { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float HeightAfterVault { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float LengthOfVaultableObject { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float WorldAngle { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float DistanceAfterVault { get; set; } // 0x24 (36)
		
		[ContainerField(40), MemberInfoFlag(137)]
		public WaypointVaultType VaultType { get; set; } = new WaypointVaultType(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool UseClientPosition { get; set; } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2755831849:
					StartPoint = (Vec3) p_Value;
					break;

				case 3862494437:
					DistanceBeforeVault = (float) p_Value;
					break;

				case 3431098489:
					HeightBeforeVault = (float) p_Value;
					break;

				case 2025884548:
					HeightAfterVault = (float) p_Value;
					break;

				case 1652501653:
					LengthOfVaultableObject = (float) p_Value;
					break;

				case 612547046:
					WorldAngle = (float) p_Value;
					break;

				case 1369021080:
					DistanceAfterVault = (float) p_Value;
					break;

				case 4073516007:
						VaultType = (WaypointVaultType) Enum.ToObject(typeof(WaypointVaultType), p_Value);
					break;

				case 430257222:
					UseClientPosition = (bool) p_Value;
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
				case 2755831849:
					return StartPoint;

				case 3862494437:
					return DistanceBeforeVault;

				case 3431098489:
					return HeightBeforeVault;

				case 2025884548:
					return HeightAfterVault;

				case 1652501653:
					return LengthOfVaultableObject;

				case 612547046:
					return WorldAngle;

				case 1369021080:
					return DistanceAfterVault;

				case 4073516007:
					return VaultType;

				case 430257222:
					return UseClientPosition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2755831849:
					return typeof(AILocoVaultTaskData).GetProperty(nameof(StartPoint));

				case 3862494437:
					return typeof(AILocoVaultTaskData).GetProperty(nameof(DistanceBeforeVault));

				case 3431098489:
					return typeof(AILocoVaultTaskData).GetProperty(nameof(HeightBeforeVault));

				case 2025884548:
					return typeof(AILocoVaultTaskData).GetProperty(nameof(HeightAfterVault));

				case 1652501653:
					return typeof(AILocoVaultTaskData).GetProperty(nameof(LengthOfVaultableObject));

				case 612547046:
					return typeof(AILocoVaultTaskData).GetProperty(nameof(WorldAngle));

				case 1369021080:
					return typeof(AILocoVaultTaskData).GetProperty(nameof(DistanceAfterVault));

				case 4073516007:
					return typeof(AILocoVaultTaskData).GetProperty(nameof(VaultType));

				case 430257222:
					return typeof(AILocoVaultTaskData).GetProperty(nameof(UseClientPosition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
