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
	public class PersistentValueTemplateStatRef : 
		AbstractPersistentStatRef
	{
		[ContainerField(8)]
		public CtrRef<PersistentValueTemplate> Definition { get; set; } = new CtrRef<PersistentValueTemplate>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2980331600:
					Definition = (CtrRef<PersistentValueTemplate>) p_Value;
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
				case 2980331600:
					return Definition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2980331600:
					return typeof(PersistentValueTemplateStatRef).GetProperty(nameof(Definition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
