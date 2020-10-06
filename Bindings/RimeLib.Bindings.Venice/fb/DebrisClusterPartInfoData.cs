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
	public class DebrisClusterPartInfoData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec3 AngularVelocity { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec3 LinearVelocity { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int NumberOfChildren { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int PartIndex { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float SplitSpeedThreshold { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool InEffectWorldOnly { get; set; } // 0x2C (44)
		
		[ContainerField(45), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool SyncRestPosition { get; set; } // 0x2D (45)
		
		[ContainerField(46), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool SyncContinous { get; set; } // 0x2E (46)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1379775472:
					AngularVelocity = (Vec3) p_Value;
					break;

				case 1252550863:
					LinearVelocity = (Vec3) p_Value;
					break;

				case 798522684:
					NumberOfChildren = (int) p_Value;
					break;

				case 3213901068:
					PartIndex = (int) p_Value;
					break;

				case 2280900007:
					SplitSpeedThreshold = (float) p_Value;
					break;

				case 1269951075:
					InEffectWorldOnly = (bool) p_Value;
					break;

				case 535707627:
					SyncRestPosition = (bool) p_Value;
					break;

				case 618548762:
					SyncContinous = (bool) p_Value;
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
				case 1379775472:
					return AngularVelocity;

				case 1252550863:
					return LinearVelocity;

				case 798522684:
					return NumberOfChildren;

				case 3213901068:
					return PartIndex;

				case 2280900007:
					return SplitSpeedThreshold;

				case 1269951075:
					return InEffectWorldOnly;

				case 535707627:
					return SyncRestPosition;

				case 618548762:
					return SyncContinous;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1379775472:
					return typeof(DebrisClusterPartInfoData).GetProperty(nameof(AngularVelocity));

				case 1252550863:
					return typeof(DebrisClusterPartInfoData).GetProperty(nameof(LinearVelocity));

				case 798522684:
					return typeof(DebrisClusterPartInfoData).GetProperty(nameof(NumberOfChildren));

				case 3213901068:
					return typeof(DebrisClusterPartInfoData).GetProperty(nameof(PartIndex));

				case 2280900007:
					return typeof(DebrisClusterPartInfoData).GetProperty(nameof(SplitSpeedThreshold));

				case 1269951075:
					return typeof(DebrisClusterPartInfoData).GetProperty(nameof(InEffectWorldOnly));

				case 535707627:
					return typeof(DebrisClusterPartInfoData).GetProperty(nameof(SyncRestPosition));

				case 618548762:
					return typeof(DebrisClusterPartInfoData).GetProperty(nameof(SyncContinous));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
