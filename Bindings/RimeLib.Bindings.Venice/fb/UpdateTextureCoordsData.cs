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
	public class UpdateTextureCoordsData : 
		ProcessorData
	{
		[ContainerField(48)]
		public EmitterTextureInfo TextureInfo1 { get; set; } = new EmitterTextureInfo(); // 0x30 (48)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float TextureBlendValue { get; set; } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2154121125:
					TextureInfo1 = (EmitterTextureInfo) p_Value;
					break;

				case 2879784880:
					TextureBlendValue = (float) p_Value;
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
				case 2154121125:
					return TextureInfo1;

				case 2879784880:
					return TextureBlendValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2154121125:
					return typeof(UpdateTextureCoordsData).GetProperty(nameof(TextureInfo1));

				case 2879784880:
					return typeof(UpdateTextureCoordsData).GetProperty(nameof(TextureBlendValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
