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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class VeniceRichPresenceLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		protected CtrRef<RichPresencePresenceString> m_PresenceMode = new CtrRef<RichPresencePresenceString>();
		[ContainerField(Name: "PresenceMode", Offset: 8, NameHash: 2266879327, Flags: 53)]
		public CtrRef<RichPresencePresenceString> PresenceMode { get { return m_PresenceMode; } set { if (OnPropertyChanging("VeniceRichPresenceLevelDescriptionComponent." + nameof(PresenceMode), this, m_PresenceMode, value)) m_PresenceMode = value; } } // 0x8 (8)
		
		protected List<RichPresenceContextSetting> m_ContextValues = new List<RichPresenceContextSetting>();
		[ContainerField(Name: "ContextValues", Offset: 12, NameHash: 3085702594, Flags: 65)]
		public List<RichPresenceContextSetting> ContextValues { get { return m_ContextValues; } set { if (OnPropertyChanging("VeniceRichPresenceLevelDescriptionComponent." + nameof(ContextValues), this, m_ContextValues, value)) m_ContextValues = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2266879327:
					PresenceMode = (CtrRef<RichPresencePresenceString>) p_Value;
					break;

				case 3085702594:
					ContextValues = (List<RichPresenceContextSetting>) p_Value;
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
				case 2266879327:
					return PresenceMode;

				case 3085702594:
					return ContextValues;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2266879327:
					return typeof(VeniceRichPresenceLevelDescriptionComponent).GetProperty(nameof(PresenceMode));

				case 3085702594:
					return typeof(VeniceRichPresenceLevelDescriptionComponent).GetProperty(nameof(ContextValues));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
