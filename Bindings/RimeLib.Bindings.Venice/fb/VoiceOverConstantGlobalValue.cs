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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class VoiceOverConstantGlobalValue : 
		VoiceOverConstantValue
	{
		protected CtrRef<VoiceOverGlobalConstantValue> m_Source = new CtrRef<VoiceOverGlobalConstantValue>();
		[ContainerField(Name: "Source", Offset: 8, NameHash: 3339738264, Flags: 53)]
		public CtrRef<VoiceOverGlobalConstantValue> Source { get { return m_Source; } set { if (OnPropertyChanging("VoiceOverConstantGlobalValue." + nameof(Source), this, m_Source, value)) m_Source = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3339738264:
					Source = (CtrRef<VoiceOverGlobalConstantValue>) p_Value;
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
				case 3339738264:
					return Source;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3339738264:
					return typeof(VoiceOverConstantGlobalValue).GetProperty(nameof(Source));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
