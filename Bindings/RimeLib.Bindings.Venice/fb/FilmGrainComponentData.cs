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
	[ContainerType(16)]
	public class FilmGrainComponentData : 
		ComponentData
	{
		protected Vec3 m_ColorScale = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(4213919872)]
		public Vec3 ColorScale { get { return m_ColorScale; } set { if (OnPropertyChanging("FilmGrainComponentData." + nameof(ColorScale), this, m_ColorScale, value)) m_ColorScale = value; } } // 0x60 (96)
		
		protected Vec2 m_TextureScale = new Vec2();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2137417890)]
		public Vec2 TextureScale { get { return m_TextureScale; } set { if (OnPropertyChanging("FilmGrainComponentData." + nameof(TextureScale), this, m_TextureScale, value)) m_TextureScale = value; } } // 0x70 (112)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(120), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("FilmGrainComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x78 (120)
		
		protected CtrRef<TextureAsset> m_Texture = new CtrRef<TextureAsset>();
		[ContainerField(124), ContainerFieldNameHash(3185041626)]
		public CtrRef<TextureAsset> Texture { get { return m_Texture; } set { if (OnPropertyChanging("FilmGrainComponentData." + nameof(Texture), this, m_Texture, value)) m_Texture = value; } } // 0x7C (124)
		
		protected bool m_LinearFilteringEnable = new bool();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(1423958617)]
		public bool LinearFilteringEnable { get { return m_LinearFilteringEnable; } set { if (OnPropertyChanging("FilmGrainComponentData." + nameof(LinearFilteringEnable), this, m_LinearFilteringEnable, value)) m_LinearFilteringEnable = value; } } // 0x80 (128)
		
		protected bool m_RandomEnable = new bool();
		[ContainerField(129), LayoutImmutable, Blittable, ContainerFieldNameHash(3235429567)]
		public bool RandomEnable { get { return m_RandomEnable; } set { if (OnPropertyChanging("FilmGrainComponentData." + nameof(RandomEnable), this, m_RandomEnable, value)) m_RandomEnable = value; } } // 0x81 (129)
		
		protected bool m_Enable = new bool();
		[ContainerField(130), LayoutImmutable, Blittable, ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("FilmGrainComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x82 (130)
		
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
