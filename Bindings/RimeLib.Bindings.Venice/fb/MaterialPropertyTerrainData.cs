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
	public class MaterialPropertyTerrainData : 
		PhysicsMaterialRelationPropertyData
	{
		protected Vec3 m_DirtTriggerColor = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2764380651)]
		public Vec3 DirtTriggerColor { get { return m_DirtTriggerColor; } set { if (OnPropertyChanging("MaterialPropertyTerrainData." + nameof(DirtTriggerColor), this, m_DirtTriggerColor, value)) m_DirtTriggerColor = value; } } // 0x10 (16)
		
		protected CtrRef<EffectBlueprint> m_DestructionEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(32), MemberInfoFlag(53), ContainerFieldNameHash(3907820780), ContainerCtrRef]
		public CtrRef<EffectBlueprint> DestructionEffect { get { return m_DestructionEffect; } set { if (OnPropertyChanging("MaterialPropertyTerrainData." + nameof(DestructionEffect), this, m_DestructionEffect, value)) m_DestructionEffect = value; } } // 0x20 (32)
		
		protected float m_DirtTriggerFactor = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(602292507)]
		public float DirtTriggerFactor { get { return m_DirtTriggerFactor; } set { if (OnPropertyChanging("MaterialPropertyTerrainData." + nameof(DirtTriggerFactor), this, m_DirtTriggerFactor, value)) m_DirtTriggerFactor = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2764380651:
					DirtTriggerColor = (Vec3) p_Value;
					break;

				case 3907820780:
					DestructionEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 602292507:
					DirtTriggerFactor = (float) p_Value;
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
				case 2764380651:
					return DirtTriggerColor;

				case 3907820780:
					return DestructionEffect;

				case 602292507:
					return DirtTriggerFactor;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2764380651:
					return typeof(MaterialPropertyTerrainData).GetProperty(nameof(DirtTriggerColor));

				case 3907820780:
					return typeof(MaterialPropertyTerrainData).GetProperty(nameof(DestructionEffect));

				case 602292507:
					return typeof(MaterialPropertyTerrainData).GetProperty(nameof(DirtTriggerFactor));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
