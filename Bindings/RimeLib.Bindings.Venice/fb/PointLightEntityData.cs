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
	public class PointLightEntityData : 
		LocalLightEntityData
	{
		protected float m_Width = new float();
		[ContainerField(Name: "Width", Offset: 160, NameHash: 226981187, Flags: 49469), LayoutImmutable, Blittable]
		public float Width { get { return m_Width; } set { if (OnPropertyChanging("PointLightEntityData." + nameof(Width), this, m_Width, value)) m_Width = value; } } // 0xA0 (160)
		
		protected float m_TranslucencyAmbient = new float();
		[ContainerField(Name: "TranslucencyAmbient", Offset: 164, NameHash: 2476604812, Flags: 49469), LayoutImmutable, Blittable]
		public float TranslucencyAmbient { get { return m_TranslucencyAmbient; } set { if (OnPropertyChanging("PointLightEntityData." + nameof(TranslucencyAmbient), this, m_TranslucencyAmbient, value)) m_TranslucencyAmbient = value; } } // 0xA4 (164)
		
		protected float m_TranslucencyScale = new float();
		[ContainerField(Name: "TranslucencyScale", Offset: 168, NameHash: 317261612, Flags: 49469), LayoutImmutable, Blittable]
		public float TranslucencyScale { get { return m_TranslucencyScale; } set { if (OnPropertyChanging("PointLightEntityData." + nameof(TranslucencyScale), this, m_TranslucencyScale, value)) m_TranslucencyScale = value; } } // 0xA8 (168)
		
		protected uint m_TranslucencyPower = new uint();
		[ContainerField(Name: "TranslucencyPower", Offset: 172, NameHash: 311917771, Flags: 49421), LayoutImmutable, Blittable]
		public uint TranslucencyPower { get { return m_TranslucencyPower; } set { if (OnPropertyChanging("PointLightEntityData." + nameof(TranslucencyPower), this, m_TranslucencyPower, value)) m_TranslucencyPower = value; } } // 0xAC (172)
		
		protected float m_TranslucencyDistortion = new float();
		[ContainerField(Name: "TranslucencyDistortion", Offset: 176, NameHash: 654575839, Flags: 49469), LayoutImmutable, Blittable]
		public float TranslucencyDistortion { get { return m_TranslucencyDistortion; } set { if (OnPropertyChanging("PointLightEntityData." + nameof(TranslucencyDistortion), this, m_TranslucencyDistortion, value)) m_TranslucencyDistortion = value; } } // 0xB0 (176)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 226981187:
					Width = (float) p_Value;
					break;

				case 2476604812:
					TranslucencyAmbient = (float) p_Value;
					break;

				case 317261612:
					TranslucencyScale = (float) p_Value;
					break;

				case 311917771:
					TranslucencyPower = (uint) p_Value;
					break;

				case 654575839:
					TranslucencyDistortion = (float) p_Value;
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
				case 226981187:
					return Width;

				case 2476604812:
					return TranslucencyAmbient;

				case 317261612:
					return TranslucencyScale;

				case 311917771:
					return TranslucencyPower;

				case 654575839:
					return TranslucencyDistortion;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 226981187:
					return typeof(PointLightEntityData).GetProperty(nameof(Width));

				case 2476604812:
					return typeof(PointLightEntityData).GetProperty(nameof(TranslucencyAmbient));

				case 317261612:
					return typeof(PointLightEntityData).GetProperty(nameof(TranslucencyScale));

				case 311917771:
					return typeof(PointLightEntityData).GetProperty(nameof(TranslucencyPower));

				case 654575839:
					return typeof(PointLightEntityData).GetProperty(nameof(TranslucencyDistortion));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
