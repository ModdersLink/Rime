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
	public class AntProjectAsset : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<AntPackageAsset> PackageAssets { get; set; } = new RefArray<AntPackageAsset>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string AntNativeProjectName { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public AntRef SceneOp { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int ProjectId { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 765658940:
					PackageAssets = (RefArray<AntPackageAsset>) p_Value;
					break;

				case 3945376013:
					AntNativeProjectName = (string) p_Value;
					break;

				case 2689985284:
					SceneOp = (AntRef) p_Value;
					break;

				case 4152360413:
					ProjectId = (int) p_Value;
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
				case 765658940:
					return PackageAssets;

				case 3945376013:
					return AntNativeProjectName;

				case 2689985284:
					return SceneOp;

				case 4152360413:
					return ProjectId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 765658940:
					return typeof(AntProjectAsset).GetProperty(nameof(PackageAssets));

				case 3945376013:
					return typeof(AntProjectAsset).GetProperty(nameof(AntNativeProjectName));

				case 2689985284:
					return typeof(AntProjectAsset).GetProperty(nameof(SceneOp));

				case 4152360413:
					return typeof(AntProjectAsset).GetProperty(nameof(ProjectId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
