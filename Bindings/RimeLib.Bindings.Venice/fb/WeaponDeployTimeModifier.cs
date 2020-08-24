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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class WeaponDeployTimeModifier : 
		WeaponModifierBase
	{
		protected float m_DeployTime = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2275884507)]
		public float DeployTime { get { return m_DeployTime; } set { if (OnPropertyChanging("WeaponDeployTimeModifier." + nameof(DeployTime), this, m_DeployTime, value)) m_DeployTime = value; } } // 0x8 (8)
		
		protected float m_DisableZoomOnDeployTime = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3731232633)]
		public float DisableZoomOnDeployTime { get { return m_DisableZoomOnDeployTime; } set { if (OnPropertyChanging("WeaponDeployTimeModifier." + nameof(DisableZoomOnDeployTime), this, m_DisableZoomOnDeployTime, value)) m_DisableZoomOnDeployTime = value; } } // 0xC (12)
		
		protected float m_AltDeployTime = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1924470306)]
		public float AltDeployTime { get { return m_AltDeployTime; } set { if (OnPropertyChanging("WeaponDeployTimeModifier." + nameof(AltDeployTime), this, m_AltDeployTime, value)) m_AltDeployTime = value; } } // 0x10 (16)
		
		protected int m_AltDeployId = new int();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1819931514)]
		public int AltDeployId { get { return m_AltDeployId; } set { if (OnPropertyChanging("WeaponDeployTimeModifier." + nameof(AltDeployId), this, m_AltDeployId, value)) m_AltDeployId = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2275884507:
					DeployTime = (float) p_Value;
					break;

				case 3731232633:
					DisableZoomOnDeployTime = (float) p_Value;
					break;

				case 1924470306:
					AltDeployTime = (float) p_Value;
					break;

				case 1819931514:
					AltDeployId = (int) p_Value;
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
				case 2275884507:
					return DeployTime;

				case 3731232633:
					return DisableZoomOnDeployTime;

				case 1924470306:
					return AltDeployTime;

				case 1819931514:
					return AltDeployId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2275884507:
					return typeof(WeaponDeployTimeModifier).GetProperty(nameof(DeployTime));

				case 3731232633:
					return typeof(WeaponDeployTimeModifier).GetProperty(nameof(DisableZoomOnDeployTime));

				case 1924470306:
					return typeof(WeaponDeployTimeModifier).GetProperty(nameof(AltDeployTime));

				case 1819931514:
					return typeof(WeaponDeployTimeModifier).GetProperty(nameof(AltDeployId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
