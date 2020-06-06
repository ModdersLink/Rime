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
	public class AnimatedCameraData : 
		CameraData
	{
		[ContainerField(80)]
		public CtrRef<SkeletonAsset> Skeleton { get; set; } = new CtrRef<SkeletonAsset>(); // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable]
		public string CameraBone { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable]
		public string FovBone { get; set; } // 0x58 (88)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 291024164:
					Skeleton = (CtrRef<SkeletonAsset>) p_Value;
					break;

				case 3220426650:
					CameraBone = (string) p_Value;
					break;

				case 1981125884:
					FovBone = (string) p_Value;
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
				case 291024164:
					return Skeleton;

				case 3220426650:
					return CameraBone;

				case 1981125884:
					return FovBone;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 291024164:
					return typeof(AnimatedCameraData).GetProperty(nameof(Skeleton));

				case 3220426650:
					return typeof(AnimatedCameraData).GetProperty(nameof(CameraBone));

				case 1981125884:
					return typeof(AnimatedCameraData).GetProperty(nameof(FovBone));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
