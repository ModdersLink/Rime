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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 64)]
	public class BaseEmitterData : 
		ProcessorData
	{
		protected CtrRef<EmitterDocument> m_EmitterAsset = new CtrRef<EmitterDocument>();
		[ContainerField(Name: "EmitterAsset", Offset: 48, NameHash: 2043417923, Flags: 53)]
		public CtrRef<EmitterDocument> EmitterAsset { get { return m_EmitterAsset; } set { if (OnPropertyChanging("BaseEmitterData." + nameof(EmitterAsset), this, m_EmitterAsset, value)) m_EmitterAsset = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2043417923:
					EmitterAsset = (CtrRef<EmitterDocument>) p_Value;
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
				case 2043417923:
					return EmitterAsset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2043417923:
					return typeof(BaseEmitterData).GetProperty(nameof(EmitterAsset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
