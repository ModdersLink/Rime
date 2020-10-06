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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class VoiceOverGlobalConstantValue : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("VoiceOverGlobalConstantValue." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverConstantValue> m_Source = new CtrRef<VoiceOverConstantValue>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(3339738264), ContainerCtrRef]
		public CtrRef<VoiceOverConstantValue> Source { get { return m_Source; } set { if (OnPropertyChanging("VoiceOverGlobalConstantValue." + nameof(Source), this, m_Source, value)) m_Source = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 3339738264:
					Source = (CtrRef<VoiceOverConstantValue>) p_Value;
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
				case 2088949890:
					return Name;

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
				case 2088949890:
					return typeof(VoiceOverGlobalConstantValue).GetProperty(nameof(Name));

				case 3339738264:
					return typeof(VoiceOverGlobalConstantValue).GetProperty(nameof(Source));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
