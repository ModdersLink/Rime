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
	public class AnimatedPointCloudComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<AnimatedPointCloudAsset> PointCloud { get; set; } = new CtrRef<AnimatedPointCloudAsset>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool StartPaused { get; set; } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 396521112:
					PointCloud = (CtrRef<AnimatedPointCloudAsset>) p_Value;
					break;

				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 735997331:
					StartPaused = (bool) p_Value;
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
				case 396521112:
					return PointCloud;

				case 2162678253:
					return ExternalTime;

				case 735997331:
					return StartPaused;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 396521112:
					return typeof(AnimatedPointCloudComponentData).GetProperty(nameof(PointCloud));

				case 2162678253:
					return typeof(AnimatedPointCloudComponentData).GetProperty(nameof(ExternalTime));

				case 735997331:
					return typeof(AnimatedPointCloudComponentData).GetProperty(nameof(StartPaused));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
