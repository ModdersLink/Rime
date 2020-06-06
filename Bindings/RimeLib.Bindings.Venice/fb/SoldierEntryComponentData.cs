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
	public class SoldierEntryComponentData : 
		EntryComponentData
	{
		[ContainerField(192)]
		public AimingConstraintsData AimingConstraints { get; set; } = new AimingConstraintsData(); // 0xC0 (192)
		
		[ContainerField(208)]
		public CtrRef<AntEnumeration> AntEntryEnumeration { get; set; } = new CtrRef<AntEnumeration>(); // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public bool AlignConstraintsToEntity { get; set; } // 0xD4 (212)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1523178198:
					AimingConstraints = (AimingConstraintsData) p_Value;
					break;

				case 1819698227:
					AntEntryEnumeration = (CtrRef<AntEnumeration>) p_Value;
					break;

				case 3847387294:
					AlignConstraintsToEntity = (bool) p_Value;
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
				case 1523178198:
					return AimingConstraints;

				case 1819698227:
					return AntEntryEnumeration;

				case 3847387294:
					return AlignConstraintsToEntity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1523178198:
					return typeof(SoldierEntryComponentData).GetProperty(nameof(AimingConstraints));

				case 1819698227:
					return typeof(SoldierEntryComponentData).GetProperty(nameof(AntEntryEnumeration));

				case 3847387294:
					return typeof(SoldierEntryComponentData).GetProperty(nameof(AlignConstraintsToEntity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
