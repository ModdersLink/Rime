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
	public class EmitterDocument : 
		EmitterAsset
	{
		[ContainerField(12)]
		public CtrRef<ProcessorData> RootProcessor { get; set; } = new CtrRef<ProcessorData>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<EmitterTemplateData> TemplateData { get; set; } = new CtrRef<EmitterTemplateData>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3988805269:
					RootProcessor = (CtrRef<ProcessorData>) p_Value;
					break;

				case 673762469:
					TemplateData = (CtrRef<EmitterTemplateData>) p_Value;
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
				case 3988805269:
					return RootProcessor;

				case 673762469:
					return TemplateData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3988805269:
					return typeof(EmitterDocument).GetProperty(nameof(RootProcessor));

				case 673762469:
					return typeof(EmitterDocument).GetProperty(nameof(TemplateData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
