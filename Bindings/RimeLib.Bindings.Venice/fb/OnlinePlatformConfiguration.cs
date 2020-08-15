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
	[ContainerType(4)]
	public class OnlinePlatformConfiguration : FrostbiteContainer
	{
		[ContainerField(0)]
		public GamePlatform Platform { get; set; } = new GamePlatform(); // 0x0 (0)
		
		[ContainerField(4)]
		public CtrRef<OnlineServicesAsset> Services { get; set; } = new CtrRef<OnlineServicesAsset>(); // 0x4 (4)
		
		[ContainerField(8)]
		public RefArray<PresenceBackendData> ClientBackends { get; set; } = new RefArray<PresenceBackendData>(); // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<ServerBackendData> ServerBackends { get; set; } = new RefArray<ServerBackendData>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool IsFallback { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 942751002:
						Platform = (GamePlatform) Enum.ToObject(typeof(GamePlatform), p_Value);
					break;

				case 270289867:
					Services = (CtrRef<OnlineServicesAsset>) p_Value;
					break;

				case 3444245387:
					ClientBackends = (RefArray<PresenceBackendData>) p_Value;
					break;

				case 2837482711:
					ServerBackends = (RefArray<ServerBackendData>) p_Value;
					break;

				case 72751187:
					IsFallback = (bool) p_Value;
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
				case 942751002:
					return Platform;

				case 270289867:
					return Services;

				case 3444245387:
					return ClientBackends;

				case 2837482711:
					return ServerBackends;

				case 72751187:
					return IsFallback;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 942751002:
					return typeof(OnlinePlatformConfiguration).GetProperty(nameof(Platform));

				case 270289867:
					return typeof(OnlinePlatformConfiguration).GetProperty(nameof(Services));

				case 3444245387:
					return typeof(OnlinePlatformConfiguration).GetProperty(nameof(ClientBackends));

				case 2837482711:
					return typeof(OnlinePlatformConfiguration).GetProperty(nameof(ServerBackends));

				case 72751187:
					return typeof(OnlinePlatformConfiguration).GetProperty(nameof(IsFallback));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
