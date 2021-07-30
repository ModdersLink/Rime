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
	public class EmitterData : 
		ProcessorData
	{
		protected RefArray<EmitterDocument> m_EmitterAssets = new RefArray<EmitterDocument>();
		[ContainerField(Name: "EmitterAssets", Offset: 48, NameHash: 3008282064, Flags: 65)]
		public RefArray<EmitterDocument> EmitterAssets { get { return m_EmitterAssets; } set { if (OnPropertyChanging("EmitterData." + nameof(EmitterAssets), this, m_EmitterAssets, value)) m_EmitterAssets = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3008282064:
					EmitterAssets = (RefArray<EmitterDocument>) p_Value;
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
				case 3008282064:
					return EmitterAssets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3008282064:
					return typeof(EmitterData).GetProperty(nameof(EmitterAssets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
