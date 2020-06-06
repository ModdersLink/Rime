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
	public class AnimatedTransformEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public AntRef Animatable { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public AntRef Controller { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string BoneName { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3208693873:
					Animatable = (AntRef) p_Value;
					break;

				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 1870777401:
					Controller = (AntRef) p_Value;
					break;

				case 1590647844:
					BoneName = (string) p_Value;
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
				case 3208693873:
					return Animatable;

				case 2162678253:
					return ExternalTime;

				case 1870777401:
					return Controller;

				case 1590647844:
					return BoneName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3208693873:
					return typeof(AnimatedTransformEntityData).GetProperty(nameof(Animatable));

				case 2162678253:
					return typeof(AnimatedTransformEntityData).GetProperty(nameof(ExternalTime));

				case 1870777401:
					return typeof(AnimatedTransformEntityData).GetProperty(nameof(Controller));

				case 1590647844:
					return typeof(AnimatedTransformEntityData).GetProperty(nameof(BoneName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
