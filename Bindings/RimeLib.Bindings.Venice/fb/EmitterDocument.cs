///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class EmitterDocument : 
		EmitterAsset
	{
		protected CtrRef<ProcessorData> m_RootProcessor = new CtrRef<ProcessorData>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(3988805269), ContainerCtrRef]
		public CtrRef<ProcessorData> RootProcessor { get { return m_RootProcessor; } set { if (OnPropertyChanging("EmitterDocument." + nameof(RootProcessor), this, m_RootProcessor, value)) m_RootProcessor = value; } } // 0xC (12)
		
		protected CtrRef<EmitterTemplateData> m_TemplateData = new CtrRef<EmitterTemplateData>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(673762469), ContainerCtrRef]
		public CtrRef<EmitterTemplateData> TemplateData { get { return m_TemplateData; } set { if (OnPropertyChanging("EmitterDocument." + nameof(TemplateData), this, m_TemplateData, value)) m_TemplateData = value; } } // 0x10 (16)
		
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
