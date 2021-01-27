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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 192)]
	public class VeniceExplosionEntityData : 
		ExplosionEntityData
	{
		protected float m_UnspottableTime = new float();
		[ContainerField(Name: "UnspottableTime", Offset: 176, NameHash: 985310797, Flags: 49469), LayoutImmutable, Blittable]
		public float UnspottableTime { get { return m_UnspottableTime; } set { if (OnPropertyChanging("VeniceExplosionEntityData." + nameof(UnspottableTime), this, m_UnspottableTime, value)) m_UnspottableTime = value; } } // 0xB0 (176)
		
		protected bool m_UnspotsOnExplode = new bool();
		[ContainerField(Name: "UnspotsOnExplode", Offset: 180, NameHash: 958509307, Flags: 49325), LayoutImmutable, Blittable]
		public bool UnspotsOnExplode { get { return m_UnspotsOnExplode; } set { if (OnPropertyChanging("VeniceExplosionEntityData." + nameof(UnspotsOnExplode), this, m_UnspotsOnExplode, value)) m_UnspotsOnExplode = value; } } // 0xB4 (180)
		
		protected bool m_SpotsOnExplode = new bool();
		[ContainerField(Name: "SpotsOnExplode", Offset: 181, NameHash: 516835456, Flags: 49325), LayoutImmutable, Blittable]
		public bool SpotsOnExplode { get { return m_SpotsOnExplode; } set { if (OnPropertyChanging("VeniceExplosionEntityData." + nameof(SpotsOnExplode), this, m_SpotsOnExplode, value)) m_SpotsOnExplode = value; } } // 0xB5 (181)
		
		protected bool m_IsCausingSuppression = new bool();
		[ContainerField(Name: "IsCausingSuppression", Offset: 182, NameHash: 617259970, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsCausingSuppression { get { return m_IsCausingSuppression; } set { if (OnPropertyChanging("VeniceExplosionEntityData." + nameof(IsCausingSuppression), this, m_IsCausingSuppression, value)) m_IsCausingSuppression = value; } } // 0xB6 (182)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 985310797:
					UnspottableTime = (float) p_Value;
					break;

				case 958509307:
					UnspotsOnExplode = (bool) p_Value;
					break;

				case 516835456:
					SpotsOnExplode = (bool) p_Value;
					break;

				case 617259970:
					IsCausingSuppression = (bool) p_Value;
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
				case 985310797:
					return UnspottableTime;

				case 958509307:
					return UnspotsOnExplode;

				case 516835456:
					return SpotsOnExplode;

				case 617259970:
					return IsCausingSuppression;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 985310797:
					return typeof(VeniceExplosionEntityData).GetProperty(nameof(UnspottableTime));

				case 958509307:
					return typeof(VeniceExplosionEntityData).GetProperty(nameof(UnspotsOnExplode));

				case 516835456:
					return typeof(VeniceExplosionEntityData).GetProperty(nameof(SpotsOnExplode));

				case 617259970:
					return typeof(VeniceExplosionEntityData).GetProperty(nameof(IsCausingSuppression));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
