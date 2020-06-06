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
	public class DecalTemplateData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Size { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float RandomSize { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Rotation { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float RandomRotation { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ClipAngle { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float ProximityRadiusFactor { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float NormalOffset { get; set; } // 0x24 (36)
		
		[ContainerField(40)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int MeshUVIndex { get; set; } // 0x2C (44)
		
		[ContainerField(48)]
		public DecalAtlasTile AtlasTile { get; set; } = new DecalAtlasTile(); // 0x30 (48)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public sbyte SortingPriority { get; set; } // 0x44 (68)
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool Projected { get; set; } // 0x45 (69)
		
		[ContainerField(70), LayoutImmutable, Blittable]
		public bool ProjectMultiple { get; set; } // 0x46 (70)
		
		[ContainerField(71), LayoutImmutable, Blittable]
		public sbyte MaterialIndex { get; set; } // 0x47 (71)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089429248:
					Size = (float) p_Value;
					break;

				case 3548218523:
					RandomSize = (float) p_Value;
					break;

				case 48673745:
					Rotation = (float) p_Value;
					break;

				case 4221673930:
					RandomRotation = (float) p_Value;
					break;

				case 1632648850:
					ClipAngle = (float) p_Value;
					break;

				case 4036214629:
					ProximityRadiusFactor = (float) p_Value;
					break;

				case 393006331:
					NormalOffset = (float) p_Value;
					break;

				case 3352909900:
					Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 114817035:
					MeshUVIndex = (int) p_Value;
					break;

				case 3027817338:
					AtlasTile = (DecalAtlasTile) p_Value;
					break;

				case 3523655821:
					SortingPriority = (sbyte) p_Value;
					break;

				case 4152361265:
					Projected = (bool) p_Value;
					break;

				case 4168918560:
					ProjectMultiple = (bool) p_Value;
					break;

				case 1001372496:
					MaterialIndex = (sbyte) p_Value;
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
				case 2089429248:
					return Size;

				case 3548218523:
					return RandomSize;

				case 48673745:
					return Rotation;

				case 4221673930:
					return RandomRotation;

				case 1632648850:
					return ClipAngle;

				case 4036214629:
					return ProximityRadiusFactor;

				case 393006331:
					return NormalOffset;

				case 3352909900:
					return Shader;

				case 114817035:
					return MeshUVIndex;

				case 3027817338:
					return AtlasTile;

				case 3523655821:
					return SortingPriority;

				case 4152361265:
					return Projected;

				case 4168918560:
					return ProjectMultiple;

				case 1001372496:
					return MaterialIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089429248:
					return typeof(DecalTemplateData).GetProperty(nameof(Size));

				case 3548218523:
					return typeof(DecalTemplateData).GetProperty(nameof(RandomSize));

				case 48673745:
					return typeof(DecalTemplateData).GetProperty(nameof(Rotation));

				case 4221673930:
					return typeof(DecalTemplateData).GetProperty(nameof(RandomRotation));

				case 1632648850:
					return typeof(DecalTemplateData).GetProperty(nameof(ClipAngle));

				case 4036214629:
					return typeof(DecalTemplateData).GetProperty(nameof(ProximityRadiusFactor));

				case 393006331:
					return typeof(DecalTemplateData).GetProperty(nameof(NormalOffset));

				case 3352909900:
					return typeof(DecalTemplateData).GetProperty(nameof(Shader));

				case 114817035:
					return typeof(DecalTemplateData).GetProperty(nameof(MeshUVIndex));

				case 3027817338:
					return typeof(DecalTemplateData).GetProperty(nameof(AtlasTile));

				case 3523655821:
					return typeof(DecalTemplateData).GetProperty(nameof(SortingPriority));

				case 4152361265:
					return typeof(DecalTemplateData).GetProperty(nameof(Projected));

				case 4168918560:
					return typeof(DecalTemplateData).GetProperty(nameof(ProjectMultiple));

				case 1001372496:
					return typeof(DecalTemplateData).GetProperty(nameof(MaterialIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
