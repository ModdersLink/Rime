///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class OnlineConfiguration : 
		Asset
	{
		[ContainerField(12)]
		public BackendType Backend { get; set; } = new BackendType(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<OnlineProviderAsset> Provider { get; set; } = new CtrRef<OnlineProviderAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<RichPresenceData> RichPresence { get; set; } = new CtrRef<RichPresenceData>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<ChatSettings> Chat { get; set; } = new CtrRef<ChatSettings>(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2290467745:
					Backend = (BackendType) Enum.ToObject(typeof(BackendType), p_Value);
					break;

				case 3021915972:
					Provider = (CtrRef<OnlineProviderAsset>) p_Value;
					break;

				case 789861132:
					RichPresence = (CtrRef<RichPresenceData>) p_Value;
					break;

				case 2088856251:
					Chat = (CtrRef<ChatSettings>) p_Value;
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
				case 2290467745:
					return Backend;

				case 3021915972:
					return Provider;

				case 789861132:
					return RichPresence;

				case 2088856251:
					return Chat;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2290467745:
					return typeof(OnlineConfiguration).GetProperty(nameof(Backend));

				case 3021915972:
					return typeof(OnlineConfiguration).GetProperty(nameof(Provider));

				case 789861132:
					return typeof(OnlineConfiguration).GetProperty(nameof(RichPresence));

				case 2088856251:
					return typeof(OnlineConfiguration).GetProperty(nameof(Chat));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
