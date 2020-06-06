///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class PointLightEntityData : 
		LocalLightEntityData
	{
		[ContainerField(160), LayoutImmutable, Blittable]
		public float Width { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float TranslucencyAmbient { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float TranslucencyScale { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public uint TranslucencyPower { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float TranslucencyDistortion { get; set; } // 0xB0 (176)
		
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
