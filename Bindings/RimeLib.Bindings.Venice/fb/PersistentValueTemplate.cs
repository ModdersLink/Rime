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
	public class PersistentValueTemplate : 
		DataContainer
	{
		[ContainerField(8)]
		public PersistentValueTemplateData Data { get; set; } = new PersistentValueTemplateData(); // 0x8 (8)
		
		[ContainerField(44)]
		public RefArray<AbstractPersistentStatRef> DerivedFormulaRefs { get; set; } = new RefArray<AbstractPersistentStatRef>(); // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088730869:
					Data = (PersistentValueTemplateData) p_Value;
					break;

				case 98984868:
					DerivedFormulaRefs = (RefArray<AbstractPersistentStatRef>) p_Value;
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
				case 2088730869:
					return Data;

				case 98984868:
					return DerivedFormulaRefs;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088730869:
					return typeof(PersistentValueTemplate).GetProperty(nameof(Data));

				case 98984868:
					return typeof(PersistentValueTemplate).GetProperty(nameof(DerivedFormulaRefs));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
