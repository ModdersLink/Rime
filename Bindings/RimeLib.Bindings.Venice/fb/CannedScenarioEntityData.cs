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
	public class CannedScenarioEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CannedAnimationBinding CannedAnimBinding { get; set; } = new CannedAnimationBinding(); // 0xC (12)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public bool AlwaysClearEntitySpaceWhenInScenario { get; set; } // 0x38 (56)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3536770252:
					CannedAnimBinding = (CannedAnimationBinding) p_Value;
					break;

				case 4041607518:
					AnimationEntitySpacePriority = (int) p_Value;
					break;

				case 4447823:
					AlwaysClearEntitySpaceWhenInScenario = (bool) p_Value;
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
				case 3536770252:
					return CannedAnimBinding;

				case 4041607518:
					return AnimationEntitySpacePriority;

				case 4447823:
					return AlwaysClearEntitySpaceWhenInScenario;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3536770252:
					return typeof(CannedScenarioEntityData).GetProperty(nameof(CannedAnimBinding));

				case 4041607518:
					return typeof(CannedScenarioEntityData).GetProperty(nameof(AnimationEntitySpacePriority));

				case 4447823:
					return typeof(CannedScenarioEntityData).GetProperty(nameof(AlwaysClearEntitySpaceWhenInScenario));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
