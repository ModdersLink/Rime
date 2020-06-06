///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UrgencyUserData : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<UrgencyUserData> Base { get; set; } = new CtrRef<UrgencyUserData>(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<UrgencyModifierData> UrgencyModifiers { get; set; } = new List<UrgencyModifierData>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<UrgencySetData> ModifierSets { get; set; } = new RefArray<UrgencySetData>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088806864:
					Base = (CtrRef<UrgencyUserData>) p_Value;
					break;

				case 2098389712:
					UrgencyModifiers = (List<UrgencyModifierData>) p_Value;
					break;

				case 2115619811:
					ModifierSets = (RefArray<UrgencySetData>) p_Value;
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
				case 2088806864:
					return Base;

				case 2098389712:
					return UrgencyModifiers;

				case 2115619811:
					return ModifierSets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088806864:
					return typeof(UrgencyUserData).GetProperty(nameof(Base));

				case 2098389712:
					return typeof(UrgencyUserData).GetProperty(nameof(UrgencyModifiers));

				case 2115619811:
					return typeof(UrgencyUserData).GetProperty(nameof(ModifierSets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
