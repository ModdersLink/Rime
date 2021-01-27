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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class Ps3PresenceBackendData : 
		PresenceBackendData
	{
		protected string m_CommunicationId = string.Empty;
		[ContainerField(Name: "CommunicationId", Offset: 16, NameHash: 1462563432, Flags: 16509), LayoutImmutable]
		public string CommunicationId { get { return m_CommunicationId; } set { if (OnPropertyChanging("Ps3PresenceBackendData." + nameof(CommunicationId), this, m_CommunicationId, value)) m_CommunicationId = value; } } // 0x10 (16)
		
		protected string m_CommunicationSignature = string.Empty;
		[ContainerField(Name: "CommunicationSignature", Offset: 20, NameHash: 2337208161, Flags: 16509), LayoutImmutable]
		public string CommunicationSignature { get { return m_CommunicationSignature; } set { if (OnPropertyChanging("Ps3PresenceBackendData." + nameof(CommunicationSignature), this, m_CommunicationSignature, value)) m_CommunicationSignature = value; } } // 0x14 (20)
		
		protected List<Ps3SkuSettings> m_SkuSettings = new List<Ps3SkuSettings>();
		[ContainerField(Name: "SkuSettings", Offset: 24, NameHash: 1395605389, Flags: 65)]
		public List<Ps3SkuSettings> SkuSettings { get { return m_SkuSettings; } set { if (OnPropertyChanging("Ps3PresenceBackendData." + nameof(SkuSettings), this, m_SkuSettings, value)) m_SkuSettings = value; } } // 0x18 (24)
		
		protected List<Ps3ParentalLockAgeSettings> m_ParentalLockAgeSettings = new List<Ps3ParentalLockAgeSettings>();
		[ContainerField(Name: "ParentalLockAgeSettings", Offset: 28, NameHash: 786148441, Flags: 65)]
		public List<Ps3ParentalLockAgeSettings> ParentalLockAgeSettings { get { return m_ParentalLockAgeSettings; } set { if (OnPropertyChanging("Ps3PresenceBackendData." + nameof(ParentalLockAgeSettings), this, m_ParentalLockAgeSettings, value)) m_ParentalLockAgeSettings = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1462563432:
					CommunicationId = (string) p_Value;
					break;

				case 2337208161:
					CommunicationSignature = (string) p_Value;
					break;

				case 1395605389:
					SkuSettings = (List<Ps3SkuSettings>) p_Value;
					break;

				case 786148441:
					ParentalLockAgeSettings = (List<Ps3ParentalLockAgeSettings>) p_Value;
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
				case 1462563432:
					return CommunicationId;

				case 2337208161:
					return CommunicationSignature;

				case 1395605389:
					return SkuSettings;

				case 786148441:
					return ParentalLockAgeSettings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1462563432:
					return typeof(Ps3PresenceBackendData).GetProperty(nameof(CommunicationId));

				case 2337208161:
					return typeof(Ps3PresenceBackendData).GetProperty(nameof(CommunicationSignature));

				case 1395605389:
					return typeof(Ps3PresenceBackendData).GetProperty(nameof(SkuSettings));

				case 786148441:
					return typeof(Ps3PresenceBackendData).GetProperty(nameof(ParentalLockAgeSettings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
