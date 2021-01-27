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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 48)]
	public class DebrisClusterPartInfoData : FrostbiteContainer
	{
		[ContainerField(Name: "AngularVelocity", Offset: 0, NameHash: 1379775472, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AngularVelocity { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "LinearVelocity", Offset: 16, NameHash: 1252550863, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 LinearVelocity { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(Name: "NumberOfChildren", Offset: 32, NameHash: 798522684, Flags: 49405), LayoutImmutable, Blittable]
		public int NumberOfChildren { get; set; } // 0x20 (32)
		
		[ContainerField(Name: "PartIndex", Offset: 36, NameHash: 3213901068, Flags: 49405), LayoutImmutable, Blittable]
		public int PartIndex { get; set; } // 0x24 (36)
		
		[ContainerField(Name: "SplitSpeedThreshold", Offset: 40, NameHash: 2280900007, Flags: 49469), LayoutImmutable, Blittable]
		public float SplitSpeedThreshold { get; set; } // 0x28 (40)
		
		[ContainerField(Name: "InEffectWorldOnly", Offset: 44, NameHash: 1269951075, Flags: 49325), LayoutImmutable, Blittable]
		public bool InEffectWorldOnly { get; set; } // 0x2C (44)
		
		[ContainerField(Name: "SyncRestPosition", Offset: 45, NameHash: 535707627, Flags: 49325), LayoutImmutable, Blittable]
		public bool SyncRestPosition { get; set; } // 0x2D (45)
		
		[ContainerField(Name: "SyncContinous", Offset: 46, NameHash: 618548762, Flags: 49325), LayoutImmutable, Blittable]
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
