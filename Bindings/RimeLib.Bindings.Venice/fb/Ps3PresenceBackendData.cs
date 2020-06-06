///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class Ps3PresenceBackendData : 
		PresenceBackendData
	{
		[ContainerField(16), LayoutImmutable]
		public string CommunicationId { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string CommunicationSignature { get; set; } // 0x14 (20)
		
		[ContainerField(24)]
		public List<Ps3SkuSettings> SkuSettings { get; set; } = new List<Ps3SkuSettings>(); // 0x18 (24)
		
		[ContainerField(28)]
		public List<Ps3ParentalLockAgeSettings> ParentalLockAgeSettings { get; set; } = new List<Ps3ParentalLockAgeSettings>(); // 0x1C (28)
		
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
