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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class SoldierFootplantEffectComponentData : 
		ComponentData
	{
		protected CtrRef<MaterialContainerPair> m_FootMaterialPair = new CtrRef<MaterialContainerPair>();
		[ContainerField(96), MemberInfoFlag(53), ContainerFieldNameHash(3867460534), ContainerCtrRef]
		public CtrRef<MaterialContainerPair> FootMaterialPair { get { return m_FootMaterialPair; } set { if (OnPropertyChanging("SoldierFootplantEffectComponentData." + nameof(FootMaterialPair), this, m_FootMaterialPair, value)) m_FootMaterialPair = value; } } // 0x60 (96)
		
		protected float m_HeightOverGroundThreshold = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1421561158)]
		public float HeightOverGroundThreshold { get { return m_HeightOverGroundThreshold; } set { if (OnPropertyChanging("SoldierFootplantEffectComponentData." + nameof(HeightOverGroundThreshold), this, m_HeightOverGroundThreshold, value)) m_HeightOverGroundThreshold = value; } } // 0x64 (100)
		
		protected float m_FootVelocityThreshold = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4147690487)]
		public float FootVelocityThreshold { get { return m_FootVelocityThreshold; } set { if (OnPropertyChanging("SoldierFootplantEffectComponentData." + nameof(FootVelocityThreshold), this, m_FootVelocityThreshold, value)) m_FootVelocityThreshold = value; } } // 0x68 (104)
		
		protected float m_LodDistance = new float();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3054638721)]
		public float LodDistance { get { return m_LodDistance; } set { if (OnPropertyChanging("SoldierFootplantEffectComponentData." + nameof(LodDistance), this, m_LodDistance, value)) m_LodDistance = value; } } // 0x6C (108)
		
		protected bool m_FullFootplantingEnabled = new bool();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2514567430)]
		public bool FullFootplantingEnabled { get { return m_FullFootplantingEnabled; } set { if (OnPropertyChanging("SoldierFootplantEffectComponentData." + nameof(FullFootplantingEnabled), this, m_FullFootplantingEnabled, value)) m_FullFootplantingEnabled = value; } } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3867460534:
					FootMaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 1421561158:
					HeightOverGroundThreshold = (float) p_Value;
					break;

				case 4147690487:
					FootVelocityThreshold = (float) p_Value;
					break;

				case 3054638721:
					LodDistance = (float) p_Value;
					break;

				case 2514567430:
					FullFootplantingEnabled = (bool) p_Value;
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
				case 3867460534:
					return FootMaterialPair;

				case 1421561158:
					return HeightOverGroundThreshold;

				case 4147690487:
					return FootVelocityThreshold;

				case 3054638721:
					return LodDistance;

				case 2514567430:
					return FullFootplantingEnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3867460534:
					return typeof(SoldierFootplantEffectComponentData).GetProperty(nameof(FootMaterialPair));

				case 1421561158:
					return typeof(SoldierFootplantEffectComponentData).GetProperty(nameof(HeightOverGroundThreshold));

				case 4147690487:
					return typeof(SoldierFootplantEffectComponentData).GetProperty(nameof(FootVelocityThreshold));

				case 3054638721:
					return typeof(SoldierFootplantEffectComponentData).GetProperty(nameof(LodDistance));

				case 2514567430:
					return typeof(SoldierFootplantEffectComponentData).GetProperty(nameof(FullFootplantingEnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
