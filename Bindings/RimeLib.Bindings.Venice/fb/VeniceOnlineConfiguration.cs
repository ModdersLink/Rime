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
	public class VeniceOnlineConfiguration : 
		OnlineConfiguration
	{
		protected List<OnlinePlatformConfiguration> m_Platforms = new List<OnlinePlatformConfiguration>();
		[ContainerField(28), MemberInfoFlag(65), ContainerFieldNameHash(1046011945), ContainerArray]
		public List<OnlinePlatformConfiguration> Platforms { get { return m_Platforms; } set { if (OnPropertyChanging("VeniceOnlineConfiguration." + nameof(Platforms), this, m_Platforms, value)) m_Platforms = value; } } // 0x1C (28)
		
		protected RefArray<EntitlementQuery> m_EntitlementQueries = new RefArray<EntitlementQuery>();
		[ContainerField(32), MemberInfoFlag(65), ContainerFieldNameHash(2121789744), ContainerRefArray]
		public RefArray<EntitlementQuery> EntitlementQueries { get { return m_EntitlementQueries; } set { if (OnPropertyChanging("VeniceOnlineConfiguration." + nameof(EntitlementQueries), this, m_EntitlementQueries, value)) m_EntitlementQueries = value; } } // 0x20 (32)
		
		protected bool m_UseFallback = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2260806602)]
		public bool UseFallback { get { return m_UseFallback; } set { if (OnPropertyChanging("VeniceOnlineConfiguration." + nameof(UseFallback), this, m_UseFallback, value)) m_UseFallback = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1046011945:
					Platforms = (List<OnlinePlatformConfiguration>) p_Value;
					break;

				case 2121789744:
					EntitlementQueries = (RefArray<EntitlementQuery>) p_Value;
					break;

				case 2260806602:
					UseFallback = (bool) p_Value;
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
				case 1046011945:
					return Platforms;

				case 2121789744:
					return EntitlementQueries;

				case 2260806602:
					return UseFallback;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1046011945:
					return typeof(VeniceOnlineConfiguration).GetProperty(nameof(Platforms));

				case 2121789744:
					return typeof(VeniceOnlineConfiguration).GetProperty(nameof(EntitlementQueries));

				case 2260806602:
					return typeof(VeniceOnlineConfiguration).GetProperty(nameof(UseFallback));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
