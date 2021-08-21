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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class EffectComponentData : 
		ComponentData
	{
		protected CtrRef<EffectBlueprint> m_Effect = new CtrRef<EffectBlueprint>();
		[ContainerField(Name: "Effect", Offset: 96, NameHash: 2332983090, Flags: 53)]
		public CtrRef<EffectBlueprint> Effect { get { return m_Effect; } set { if (OnPropertyChanging("EffectComponentData." + nameof(Effect), this, m_Effect, value)) m_Effect = value; } } // 0x60 (96)
		
		protected float m_EmitterParameter1 = new float();
		[ContainerField(Name: "EmitterParameter1", Offset: 100, NameHash: 3454545451, Flags: 49469), LayoutImmutable, Blittable]
		public float EmitterParameter1 { get { return m_EmitterParameter1; } set { if (OnPropertyChanging("EffectComponentData." + nameof(EmitterParameter1), this, m_EmitterParameter1, value)) m_EmitterParameter1 = value; } } // 0x64 (100)
		
		protected float m_EmitterParameter3 = new float();
		[ContainerField(Name: "EmitterParameter3", Offset: 104, NameHash: 3454545449, Flags: 49469), LayoutImmutable, Blittable]
		public float EmitterParameter3 { get { return m_EmitterParameter3; } set { if (OnPropertyChanging("EffectComponentData." + nameof(EmitterParameter3), this, m_EmitterParameter3, value)) m_EmitterParameter3 = value; } } // 0x68 (104)
		
		protected float m_EmitterParameter2 = new float();
		[ContainerField(Name: "EmitterParameter2", Offset: 108, NameHash: 3454545448, Flags: 49469), LayoutImmutable, Blittable]
		public float EmitterParameter2 { get { return m_EmitterParameter2; } set { if (OnPropertyChanging("EffectComponentData." + nameof(EmitterParameter2), this, m_EmitterParameter2, value)) m_EmitterParameter2 = value; } } // 0x6C (108)
		
		protected bool m_AutoStart = new bool();
		[ContainerField(Name: "AutoStart", Offset: 112, NameHash: 792615882, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoStart { get { return m_AutoStart; } set { if (OnPropertyChanging("EffectComponentData." + nameof(AutoStart), this, m_AutoStart, value)) m_AutoStart = value; } } // 0x70 (112)
		
		protected bool m_SnapToWaterSurface = new bool();
		[ContainerField(Name: "SnapToWaterSurface", Offset: 113, NameHash: 2958537010, Flags: 49325), LayoutImmutable, Blittable]
		public bool SnapToWaterSurface { get { return m_SnapToWaterSurface; } set { if (OnPropertyChanging("EffectComponentData." + nameof(SnapToWaterSurface), this, m_SnapToWaterSurface, value)) m_SnapToWaterSurface = value; } } // 0x71 (113)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2332983090:
					Effect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 3454545451:
					EmitterParameter1 = (float) p_Value;
					break;

				case 3454545449:
					EmitterParameter3 = (float) p_Value;
					break;

				case 3454545448:
					EmitterParameter2 = (float) p_Value;
					break;

				case 792615882:
					AutoStart = (bool) p_Value;
					break;

				case 2958537010:
					SnapToWaterSurface = (bool) p_Value;
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
				case 2332983090:
					return Effect;

				case 3454545451:
					return EmitterParameter1;

				case 3454545449:
					return EmitterParameter3;

				case 3454545448:
					return EmitterParameter2;

				case 792615882:
					return AutoStart;

				case 2958537010:
					return SnapToWaterSurface;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2332983090:
					return typeof(EffectComponentData).GetProperty(nameof(Effect));

				case 3454545451:
					return typeof(EffectComponentData).GetProperty(nameof(EmitterParameter1));

				case 3454545449:
					return typeof(EffectComponentData).GetProperty(nameof(EmitterParameter3));

				case 3454545448:
					return typeof(EffectComponentData).GetProperty(nameof(EmitterParameter2));

				case 792615882:
					return typeof(EffectComponentData).GetProperty(nameof(AutoStart));

				case 2958537010:
					return typeof(EffectComponentData).GetProperty(nameof(SnapToWaterSurface));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
