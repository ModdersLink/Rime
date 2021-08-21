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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class VoiceOverValueRedirect : 
		DataContainer
	{
		protected CtrRef<VoiceOverValue> m_Source = new CtrRef<VoiceOverValue>();
		[ContainerField(Name: "Source", Offset: 8, NameHash: 3339738264, Flags: 53)]
		public CtrRef<VoiceOverValue> Source { get { return m_Source; } set { if (OnPropertyChanging("VoiceOverValueRedirect." + nameof(Source), this, m_Source, value)) m_Source = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverValue> m_Target = new CtrRef<VoiceOverValue>();
		[ContainerField(Name: "Target", Offset: 12, NameHash: 3215022804, Flags: 53)]
		public CtrRef<VoiceOverValue> Target { get { return m_Target; } set { if (OnPropertyChanging("VoiceOverValueRedirect." + nameof(Target), this, m_Target, value)) m_Target = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3339738264:
					Source = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 3215022804:
					Target = (CtrRef<VoiceOverValue>) p_Value;
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

				case 3215022804:
					return Target;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3339738264:
					return typeof(VoiceOverValueRedirect).GetProperty(nameof(Source));

				case 3215022804:
					return typeof(VoiceOverValueRedirect).GetProperty(nameof(Target));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
