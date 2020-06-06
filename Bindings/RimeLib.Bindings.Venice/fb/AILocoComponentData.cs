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
	public class AILocoComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public AILocoBinding Binding { get; set; } = new AILocoBinding(); // 0x60 (96)
		
		[ContainerField(132)]
		public AILocoVaultBinding VaultBinding { get; set; } = new AILocoVaultBinding(); // 0x84 (132)
		
		[ContainerField(160)]
		public AILocoCoverBinding CoverBinding { get; set; } = new AILocoCoverBinding(); // 0xA0 (160)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public float WantedYaw { get; set; } // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; } // 0xEC (236)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2590060228:
					Binding = (AILocoBinding) p_Value;
					break;

				case 736566942:
					VaultBinding = (AILocoVaultBinding) p_Value;
					break;

				case 3534640393:
					CoverBinding = (AILocoCoverBinding) p_Value;
					break;

				case 82142727:
					WantedYaw = (float) p_Value;
					break;

				case 4041607518:
					AnimationEntitySpacePriority = (int) p_Value;
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

				case 736566942:
					return VaultBinding;

				case 3534640393:
					return CoverBinding;

				case 82142727:
					return WantedYaw;

				case 4041607518:
					return AnimationEntitySpacePriority;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2590060228:
					return typeof(AILocoComponentData).GetProperty(nameof(Binding));

				case 736566942:
					return typeof(AILocoComponentData).GetProperty(nameof(VaultBinding));

				case 3534640393:
					return typeof(AILocoComponentData).GetProperty(nameof(CoverBinding));

				case 82142727:
					return typeof(AILocoComponentData).GetProperty(nameof(WantedYaw));

				case 4041607518:
					return typeof(AILocoComponentData).GetProperty(nameof(AnimationEntitySpacePriority));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
