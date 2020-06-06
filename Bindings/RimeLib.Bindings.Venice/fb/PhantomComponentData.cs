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
	public class PhantomComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BoxSize { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112)]
		public AntRef AsyncQueryPointerAsset { get; set; } = new AntRef(); // 0x70 (112)
		
		[ContainerField(116)]
		public AntRef EnableTrajectoryOverride { get; set; } = new AntRef(); // 0x74 (116)
		
		[ContainerField(120)]
		public AntRef TrajectoryOverride { get; set; } = new AntRef(); // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2526771413:
					BoxSize = (Vec3) p_Value;
					break;

				case 597429154:
					AsyncQueryPointerAsset = (AntRef) p_Value;
					break;

				case 1154108267:
					EnableTrajectoryOverride = (AntRef) p_Value;
					break;

				case 3150043274:
					TrajectoryOverride = (AntRef) p_Value;
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
				case 2526771413:
					return BoxSize;

				case 597429154:
					return AsyncQueryPointerAsset;

				case 1154108267:
					return EnableTrajectoryOverride;

				case 3150043274:
					return TrajectoryOverride;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2526771413:
					return typeof(PhantomComponentData).GetProperty(nameof(BoxSize));

				case 597429154:
					return typeof(PhantomComponentData).GetProperty(nameof(AsyncQueryPointerAsset));

				case 1154108267:
					return typeof(PhantomComponentData).GetProperty(nameof(EnableTrajectoryOverride));

				case 3150043274:
					return typeof(PhantomComponentData).GetProperty(nameof(TrajectoryOverride));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
