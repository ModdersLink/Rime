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
	public class SimpleAnimationControlComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SimpleAnimationControlBinding Binding { get; set; } = new SimpleAnimationControlBinding(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool Run { get; set; } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2590060228:
					Binding = (SimpleAnimationControlBinding) p_Value;
					break;

				case 4041607518:
					AnimationEntitySpacePriority = (int) p_Value;
					break;

				case 193464460:
					Run = (bool) p_Value;
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
				case 2590060228:
					return Binding;

				case 4041607518:
					return AnimationEntitySpacePriority;

				case 193464460:
					return Run;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2590060228:
					return typeof(SimpleAnimationControlComponentData).GetProperty(nameof(Binding));

				case 4041607518:
					return typeof(SimpleAnimationControlComponentData).GetProperty(nameof(AnimationEntitySpacePriority));

				case 193464460:
					return typeof(SimpleAnimationControlComponentData).GetProperty(nameof(Run));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
