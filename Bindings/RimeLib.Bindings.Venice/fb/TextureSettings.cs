///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class TextureSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint SkipMipmapCount { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool LoadingEnabled { get; set; } // 0xC (12)
		
		[ContainerField(13), LayoutImmutable, Blittable]
		public bool RenderTexturesEnabled { get; set; } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 679697071:
					SkipMipmapCount = (uint) p_Value;
					break;

				case 1695799750:
					LoadingEnabled = (bool) p_Value;
					break;

				case 437746662:
					RenderTexturesEnabled = (bool) p_Value;
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
				case 679697071:
					return SkipMipmapCount;

				case 1695799750:
					return LoadingEnabled;

				case 437746662:
					return RenderTexturesEnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 679697071:
					return typeof(TextureSettings).GetProperty(nameof(SkipMipmapCount));

				case 1695799750:
					return typeof(TextureSettings).GetProperty(nameof(LoadingEnabled));

				case 437746662:
					return typeof(TextureSettings).GetProperty(nameof(RenderTexturesEnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
