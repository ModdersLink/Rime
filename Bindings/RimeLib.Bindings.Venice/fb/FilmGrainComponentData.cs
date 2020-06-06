///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class FilmGrainComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ColorScale { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 TextureScale { get; set; } = new Vec2(); // 0x70 (112)
		
		[ContainerField(120)]
		public Realm Realm { get; set; } = new Realm(); // 0x78 (120)
		
		[ContainerField(124)]
		public CtrRef<TextureAsset> Texture { get; set; } = new CtrRef<TextureAsset>(); // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public bool LinearFilteringEnable { get; set; } // 0x80 (128)
		
		[ContainerField(129), LayoutImmutable, Blittable]
		public bool RandomEnable { get; set; } // 0x81 (129)
		
		[ContainerField(130), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x82 (130)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4213919872:
					ColorScale = (Vec3) p_Value;
					break;

				case 2137417890:
					TextureScale = (Vec2) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3185041626:
					Texture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 1423958617:
					LinearFilteringEnable = (bool) p_Value;
					break;

				case 3235429567:
					RandomEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 4213919872:
					return ColorScale;

				case 2137417890:
					return TextureScale;

				case 229961746:
					return Realm;

				case 3185041626:
					return Texture;

				case 1423958617:
					return LinearFilteringEnable;

				case 3235429567:
					return RandomEnable;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4213919872:
					return typeof(FilmGrainComponentData).GetProperty(nameof(ColorScale));

				case 2137417890:
					return typeof(FilmGrainComponentData).GetProperty(nameof(TextureScale));

				case 229961746:
					return typeof(FilmGrainComponentData).GetProperty(nameof(Realm));

				case 3185041626:
					return typeof(FilmGrainComponentData).GetProperty(nameof(Texture));

				case 1423958617:
					return typeof(FilmGrainComponentData).GetProperty(nameof(LinearFilteringEnable));

				case 3235429567:
					return typeof(FilmGrainComponentData).GetProperty(nameof(RandomEnable));

				case 2342790116:
					return typeof(FilmGrainComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
