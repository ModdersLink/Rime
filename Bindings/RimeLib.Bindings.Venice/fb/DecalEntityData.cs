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
	public class DecalEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x60 (96)
		
		[ContainerField(100)]
		public DecalAtlasTile AtlasTile { get; set; } = new DecalAtlasTile(); // 0x64 (100)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public sbyte MaterialIndex { get; set; } // 0x78 (120)
		
		[ContainerField(121), LayoutImmutable, Blittable]
		public sbyte SortingPriority { get; set; } // 0x79 (121)
		
		[ContainerField(122), LayoutImmutable, Blittable]
		public bool Projected { get; set; } // 0x7A (122)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3352909900:
					Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 3027817338:
					AtlasTile = (DecalAtlasTile) p_Value;
					break;

				case 1001372496:
					MaterialIndex = (sbyte) p_Value;
					break;

				case 3523655821:
					SortingPriority = (sbyte) p_Value;
					break;

				case 4152361265:
					Projected = (bool) p_Value;
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
				case 3352909900:
					return Shader;

				case 3027817338:
					return AtlasTile;

				case 1001372496:
					return MaterialIndex;

				case 3523655821:
					return SortingPriority;

				case 4152361265:
					return Projected;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3352909900:
					return typeof(DecalEntityData).GetProperty(nameof(Shader));

				case 3027817338:
					return typeof(DecalEntityData).GetProperty(nameof(AtlasTile));

				case 1001372496:
					return typeof(DecalEntityData).GetProperty(nameof(MaterialIndex));

				case 3523655821:
					return typeof(DecalEntityData).GetProperty(nameof(SortingPriority));

				case 4152361265:
					return typeof(DecalEntityData).GetProperty(nameof(Projected));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
