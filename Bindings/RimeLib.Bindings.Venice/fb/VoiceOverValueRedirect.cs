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
	public class VoiceOverValueRedirect : 
		DataContainer
	{
		protected CtrRef<VoiceOverValue> m_Source = new CtrRef<VoiceOverValue>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(3339738264), ContainerCtrRef]
		public CtrRef<VoiceOverValue> Source { get { return m_Source; } set { if (OnPropertyChanging("VoiceOverValueRedirect." + nameof(Source), this, m_Source, value)) m_Source = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverValue> m_Target = new CtrRef<VoiceOverValue>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(3215022804), ContainerCtrRef]
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
