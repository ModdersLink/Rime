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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class VoiceOverObject : 
		VoiceOverNamedValue
	{
		protected RefArray<VoiceOverNamedValue> m_Properties = new RefArray<VoiceOverNamedValue>();
		[ContainerField(Name: "Properties", Offset: 16, NameHash: 1506334468, Flags: 65)]
		public RefArray<VoiceOverNamedValue> Properties { get { return m_Properties; } set { if (OnPropertyChanging("VoiceOverObject." + nameof(Properties), this, m_Properties, value)) m_Properties = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1506334468:
					Properties = (RefArray<VoiceOverNamedValue>) p_Value;
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
				case 1506334468:
					return Properties;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1506334468:
					return typeof(VoiceOverObject).GetProperty(nameof(Properties));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
