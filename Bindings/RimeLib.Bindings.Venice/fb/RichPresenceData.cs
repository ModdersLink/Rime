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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class RichPresenceData : 
		Asset
	{
		protected RefArray<RichPresencePresenceString> m_PresenceModes = new RefArray<RichPresencePresenceString>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(1792573772), ContainerRefArray]
		public RefArray<RichPresencePresenceString> PresenceModes { get { return m_PresenceModes; } set { if (OnPropertyChanging("RichPresenceData." + nameof(PresenceModes), this, m_PresenceModes, value)) m_PresenceModes = value; } } // 0xC (12)
		
		protected CtrRef<RichPresencePresenceString> m_DefaultMode = new CtrRef<RichPresencePresenceString>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(2014189229), ContainerCtrRef]
		public CtrRef<RichPresencePresenceString> DefaultMode { get { return m_DefaultMode; } set { if (OnPropertyChanging("RichPresenceData." + nameof(DefaultMode), this, m_DefaultMode, value)) m_DefaultMode = value; } } // 0x10 (16)
		
		protected CtrRef<RichPresencePresenceString> m_InactiveMode = new CtrRef<RichPresencePresenceString>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(2860645485), ContainerCtrRef]
		public CtrRef<RichPresencePresenceString> InactiveMode { get { return m_InactiveMode; } set { if (OnPropertyChanging("RichPresenceData." + nameof(InactiveMode), this, m_InactiveMode, value)) m_InactiveMode = value; } } // 0x14 (20)
		
		protected RefArray<RichPresenceContext> m_Contexts = new RefArray<RichPresenceContext>();
		[ContainerField(24), MemberInfoFlag(65), ContainerFieldNameHash(333666601), ContainerRefArray]
		public RefArray<RichPresenceContext> Contexts { get { return m_Contexts; } set { if (OnPropertyChanging("RichPresenceData." + nameof(Contexts), this, m_Contexts, value)) m_Contexts = value; } } // 0x18 (24)
		
		protected List<RichPresenceProperty> m_Properties = new List<RichPresenceProperty>();
		[ContainerField(28), MemberInfoFlag(65), ContainerFieldNameHash(1506334468), ContainerArray]
		public List<RichPresenceProperty> Properties { get { return m_Properties; } set { if (OnPropertyChanging("RichPresenceData." + nameof(Properties), this, m_Properties, value)) m_Properties = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1792573772:
					PresenceModes = (RefArray<RichPresencePresenceString>) p_Value;
					break;

				case 2014189229:
					DefaultMode = (CtrRef<RichPresencePresenceString>) p_Value;
					break;

				case 2860645485:
					InactiveMode = (CtrRef<RichPresencePresenceString>) p_Value;
					break;

				case 333666601:
					Contexts = (RefArray<RichPresenceContext>) p_Value;
					break;

				case 1506334468:
					Properties = (List<RichPresenceProperty>) p_Value;
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
				case 1792573772:
					return PresenceModes;

				case 2014189229:
					return DefaultMode;

				case 2860645485:
					return InactiveMode;

				case 333666601:
					return Contexts;

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
				case 1792573772:
					return typeof(RichPresenceData).GetProperty(nameof(PresenceModes));

				case 2014189229:
					return typeof(RichPresenceData).GetProperty(nameof(DefaultMode));

				case 2860645485:
					return typeof(RichPresenceData).GetProperty(nameof(InactiveMode));

				case 333666601:
					return typeof(RichPresenceData).GetProperty(nameof(Contexts));

				case 1506334468:
					return typeof(RichPresenceData).GetProperty(nameof(Properties));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
