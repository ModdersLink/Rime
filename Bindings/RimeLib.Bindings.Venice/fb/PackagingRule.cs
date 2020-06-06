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
	public class PackagingRule : 
		Asset
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DebugColor { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool CanTargetSelf { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2612071465:
					DebugColor = (Vec3) p_Value;
					break;

				case 3198168004:
					CanTargetSelf = (bool) p_Value;
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
				case 2612071465:
					return DebugColor;

				case 3198168004:
					return CanTargetSelf;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2612071465:
					return typeof(PackagingRule).GetProperty(nameof(DebugColor));

				case 3198168004:
					return typeof(PackagingRule).GetProperty(nameof(CanTargetSelf));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
