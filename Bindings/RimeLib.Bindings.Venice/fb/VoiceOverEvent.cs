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
	public class VoiceOverEvent : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 8, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("VoiceOverEvent." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected RefArray<VoiceOverNamedValue> m_Parameters = new RefArray<VoiceOverNamedValue>();
		[ContainerField(Name: "Parameters", Offset: 12, NameHash: 3325515039, Flags: 65)]
		public RefArray<VoiceOverNamedValue> Parameters { get { return m_Parameters; } set { if (OnPropertyChanging("VoiceOverEvent." + nameof(Parameters), this, m_Parameters, value)) m_Parameters = value; } } // 0xC (12)
		
		protected CtrRef<VoiceOverLogicAsset> m_Owner = new CtrRef<VoiceOverLogicAsset>();
		[ContainerField(Name: "Owner", Offset: 16, NameHash: 217695012, Flags: 53)]
		public CtrRef<VoiceOverLogicAsset> Owner { get { return m_Owner; } set { if (OnPropertyChanging("VoiceOverEvent." + nameof(Owner), this, m_Owner, value)) m_Owner = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 3325515039:
					Parameters = (RefArray<VoiceOverNamedValue>) p_Value;
					break;

				case 217695012:
					Owner = (CtrRef<VoiceOverLogicAsset>) p_Value;
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

				case 3325515039:
					return Parameters;

				case 217695012:
					return Owner;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(VoiceOverEvent).GetProperty(nameof(Name));

				case 3325515039:
					return typeof(VoiceOverEvent).GetProperty(nameof(Parameters));

				case 217695012:
					return typeof(VoiceOverEvent).GetProperty(nameof(Owner));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
