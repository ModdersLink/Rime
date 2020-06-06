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
	public class PlayVideoEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<MovieTextureAsset> Movie { get; set; } = new CtrRef<MovieTextureAsset>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool KeepBlackScreen { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool AllowSkip { get; set; } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 210030653:
					Movie = (CtrRef<MovieTextureAsset>) p_Value;
					break;

				case 1584450997:
					KeepBlackScreen = (bool) p_Value;
					break;

				case 2314030141:
					AllowSkip = (bool) p_Value;
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
				case 210030653:
					return Movie;

				case 1584450997:
					return KeepBlackScreen;

				case 2314030141:
					return AllowSkip;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 210030653:
					return typeof(PlayVideoEntityData).GetProperty(nameof(Movie));

				case 1584450997:
					return typeof(PlayVideoEntityData).GetProperty(nameof(KeepBlackScreen));

				case 2314030141:
					return typeof(PlayVideoEntityData).GetProperty(nameof(AllowSkip));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
