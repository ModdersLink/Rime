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
	[ContainerType(16)]
	public class PlayerEntryComponentData : 
		EntryComponentData
	{
		protected Vec3 m_AnimationAccelerationMultiplier = new Vec3();
		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(893003770)]
		public Vec3 AnimationAccelerationMultiplier { get { return m_AnimationAccelerationMultiplier; } set { if (OnPropertyChanging("PlayerEntryComponentData." + nameof(AnimationAccelerationMultiplier), this, m_AnimationAccelerationMultiplier, value)) m_AnimationAccelerationMultiplier = value; } } // 0xC0 (192)
		
		protected AntEntryIdEnum m_AntEntryId = new AntEntryIdEnum();
		[ContainerField(208), ContainerFieldNameHash(3749795303)]
		public AntEntryIdEnum AntEntryId { get { return m_AntEntryId; } set { if (OnPropertyChanging("PlayerEntryComponentData." + nameof(AntEntryId), this, m_AntEntryId, value)) m_AntEntryId = value; } } // 0xD0 (208)
		
		protected string m_AntEntryID = string.Empty;
		[ContainerField(212), LayoutImmutable, ContainerFieldNameHash(3749795271)]
		public string AntEntryID { get { return m_AntEntryID; } set { if (OnPropertyChanging("PlayerEntryComponentData." + nameof(AntEntryID), this, m_AntEntryID, value)) m_AntEntryID = value; } } // 0xD4 (212)
		
		protected CtrRef<AntEnumeration> m_AntEntryEnumeration = new CtrRef<AntEnumeration>();
		[ContainerField(216), ContainerFieldNameHash(1819698227)]
		public CtrRef<AntEnumeration> AntEntryEnumeration { get { return m_AntEntryEnumeration; } set { if (OnPropertyChanging("PlayerEntryComponentData." + nameof(AntEntryEnumeration), this, m_AntEntryEnumeration, value)) m_AntEntryEnumeration = value; } } // 0xD8 (216)
		
		protected float m_ShieldedTransitionExitTime = new float();
		[ContainerField(220), LayoutImmutable, Blittable, ContainerFieldNameHash(3020329377)]
		public float ShieldedTransitionExitTime { get { return m_ShieldedTransitionExitTime; } set { if (OnPropertyChanging("PlayerEntryComponentData." + nameof(ShieldedTransitionExitTime), this, m_ShieldedTransitionExitTime, value)) m_ShieldedTransitionExitTime = value; } } // 0xDC (220)
		
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
