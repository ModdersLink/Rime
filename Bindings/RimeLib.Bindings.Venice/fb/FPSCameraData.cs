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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(224), ContainerClass]
	public class FPSCameraData : 
		TargetCameraData
	{
		protected TurnEffectData m_TurnEffectSettings = new TurnEffectData();
		[ContainerField(160), MemberInfoFlag(41), ContainerFieldNameHash(76337482)]
		public TurnEffectData TurnEffectSettings { get { return m_TurnEffectSettings; } set { if (OnPropertyChanging("FPSCameraData." + nameof(TurnEffectSettings), this, m_TurnEffectSettings, value)) m_TurnEffectSettings = value; } } // 0xA0 (160)
		
		protected BlurEffectData m_BlurEffectSettings = new BlurEffectData();
		[ContainerField(192), MemberInfoFlag(41), ContainerFieldNameHash(2488763390)]
		public BlurEffectData BlurEffectSettings { get { return m_BlurEffectSettings; } set { if (OnPropertyChanging("FPSCameraData." + nameof(BlurEffectSettings), this, m_BlurEffectSettings, value)) m_BlurEffectSettings = value; } } // 0xC0 (192)
		
		protected float m_FOV = new float();
		[ContainerField(216), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(193442778)]
		public float FOV { get { return m_FOV; } set { if (OnPropertyChanging("FPSCameraData." + nameof(FOV), this, m_FOV, value)) m_FOV = value; } } // 0xD8 (216)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 76337482:
					TurnEffectSettings = (TurnEffectData) p_Value;
					break;

				case 2488763390:
					BlurEffectSettings = (BlurEffectData) p_Value;
					break;

				case 193442778:
					FOV = (float) p_Value;
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
				case 76337482:
					return TurnEffectSettings;

				case 2488763390:
					return BlurEffectSettings;

				case 193442778:
					return FOV;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 76337482:
					return typeof(FPSCameraData).GetProperty(nameof(TurnEffectSettings));

				case 2488763390:
					return typeof(FPSCameraData).GetProperty(nameof(BlurEffectSettings));

				case 193442778:
					return typeof(FPSCameraData).GetProperty(nameof(FOV));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
