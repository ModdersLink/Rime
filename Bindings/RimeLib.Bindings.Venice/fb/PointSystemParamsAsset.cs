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
	[ContainerType(4)]
	public class PointSystemParamsAsset : 
		Asset
	{
		protected float m_MultiKillTimeLimit = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(3857154606)]
		public float MultiKillTimeLimit { get { return m_MultiKillTimeLimit; } set { if (OnPropertyChanging("PointSystemParamsAsset." + nameof(MultiKillTimeLimit), this, m_MultiKillTimeLimit, value)) m_MultiKillTimeLimit = value; } } // 0xC (12)
		
		protected float m_DnfTimeout = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(478606706)]
		public float DnfTimeout { get { return m_DnfTimeout; } set { if (OnPropertyChanging("PointSystemParamsAsset." + nameof(DnfTimeout), this, m_DnfTimeout, value)) m_DnfTimeout = value; } } // 0x10 (16)
		
		protected uint m_KillStreakX = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(2976281157)]
		public uint KillStreakX { get { return m_KillStreakX; } set { if (OnPropertyChanging("PointSystemParamsAsset." + nameof(KillStreakX), this, m_KillStreakX, value)) m_KillStreakX = value; } } // 0x14 (20)
		
		protected uint m_NemesisKillX = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(2569054453)]
		public uint NemesisKillX { get { return m_NemesisKillX; } set { if (OnPropertyChanging("PointSystemParamsAsset." + nameof(NemesisKillX), this, m_NemesisKillX, value)) m_NemesisKillX = value; } } // 0x18 (24)
		
		protected float m_FreefallHeight = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(1685675721)]
		public float FreefallHeight { get { return m_FreefallHeight; } set { if (OnPropertyChanging("PointSystemParamsAsset." + nameof(FreefallHeight), this, m_FreefallHeight, value)) m_FreefallHeight = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3857154606:
					MultiKillTimeLimit = (float) p_Value;
					break;

				case 478606706:
					DnfTimeout = (float) p_Value;
					break;

				case 2976281157:
					KillStreakX = (uint) p_Value;
					break;

				case 2569054453:
					NemesisKillX = (uint) p_Value;
					break;

				case 1685675721:
					FreefallHeight = (float) p_Value;
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
				case 3857154606:
					return MultiKillTimeLimit;

				case 478606706:
					return DnfTimeout;

				case 2976281157:
					return KillStreakX;

				case 2569054453:
					return NemesisKillX;

				case 1685675721:
					return FreefallHeight;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3857154606:
					return typeof(PointSystemParamsAsset).GetProperty(nameof(MultiKillTimeLimit));

				case 478606706:
					return typeof(PointSystemParamsAsset).GetProperty(nameof(DnfTimeout));

				case 2976281157:
					return typeof(PointSystemParamsAsset).GetProperty(nameof(KillStreakX));

				case 2569054453:
					return typeof(PointSystemParamsAsset).GetProperty(nameof(NemesisKillX));

				case 1685675721:
					return typeof(PointSystemParamsAsset).GetProperty(nameof(FreefallHeight));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
