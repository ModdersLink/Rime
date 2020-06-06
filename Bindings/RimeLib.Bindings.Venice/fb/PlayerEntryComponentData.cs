///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class PlayerEntryComponentData : 
		EntryComponentData
	{
		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AnimationAccelerationMultiplier { get; set; } = new Vec3(); // 0xC0 (192)
		
		[ContainerField(208)]
		public AntEntryIdEnum AntEntryId { get; set; } = new AntEntryIdEnum(); // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable]
		public string AntEntryID { get; set; } // 0xD4 (212)
		
		[ContainerField(216)]
		public CtrRef<AntEnumeration> AntEntryEnumeration { get; set; } = new CtrRef<AntEnumeration>(); // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float ShieldedTransitionExitTime { get; set; } // 0xDC (220)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 893003770:
					AnimationAccelerationMultiplier = (Vec3) p_Value;
					break;

				case 3749795303:
					AntEntryId = (AntEntryIdEnum) Enum.ToObject(typeof(AntEntryIdEnum), p_Value);
					break;

				case 3749795271:
					AntEntryID = (string) p_Value;
					break;

				case 1819698227:
					AntEntryEnumeration = (CtrRef<AntEnumeration>) p_Value;
					break;

				case 3020329377:
					ShieldedTransitionExitTime = (float) p_Value;
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
				case 893003770:
					return AnimationAccelerationMultiplier;

				case 3749795303:
					return AntEntryId;

				case 3749795271:
					return AntEntryID;

				case 1819698227:
					return AntEntryEnumeration;

				case 3020329377:
					return ShieldedTransitionExitTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 893003770:
					return typeof(PlayerEntryComponentData).GetProperty(nameof(AnimationAccelerationMultiplier));

				case 3749795303:
					return typeof(PlayerEntryComponentData).GetProperty(nameof(AntEntryId));

				case 3749795271:
					return typeof(PlayerEntryComponentData).GetProperty(nameof(AntEntryID));

				case 1819698227:
					return typeof(PlayerEntryComponentData).GetProperty(nameof(AntEntryEnumeration));

				case 3020329377:
					return typeof(PlayerEntryComponentData).GetProperty(nameof(ShieldedTransitionExitTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
