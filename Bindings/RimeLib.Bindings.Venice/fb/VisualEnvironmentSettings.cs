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
	public class VisualEnvironmentSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float SunRotationX { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float SunRotationY { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool DrawStats { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2283294049:
					SunRotationX = (float) p_Value;
					break;

				case 2283294048:
					SunRotationY = (float) p_Value;
					break;

				case 2413142628:
					DrawStats = (bool) p_Value;
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
				case 2283294049:
					return SunRotationX;

				case 2283294048:
					return SunRotationY;

				case 2413142628:
					return DrawStats;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2283294049:
					return typeof(VisualEnvironmentSettings).GetProperty(nameof(SunRotationX));

				case 2283294048:
					return typeof(VisualEnvironmentSettings).GetProperty(nameof(SunRotationY));

				case 2413142628:
					return typeof(VisualEnvironmentSettings).GetProperty(nameof(DrawStats));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
