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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class EntitlementQuery : 
		Asset
	{
		protected List<EntitlementData> m_EntitlementsData = new List<EntitlementData>();
		[ContainerField(Name: "EntitlementsData", Offset: 12, NameHash: 2421825855, Flags: 65)]
		public List<EntitlementData> EntitlementsData { get { return m_EntitlementsData; } set { if (OnPropertyChanging("EntitlementQuery." + nameof(EntitlementsData), this, m_EntitlementsData, value)) m_EntitlementsData = value; } } // 0xC (12)
		
		protected List<string> m_GroupNames = new List<string>();
		[ContainerField(Name: "GroupNames", Offset: 16, NameHash: 1803493518, Flags: 65)]
		public List<string> GroupNames { get { return m_GroupNames; } set { if (OnPropertyChanging("EntitlementQuery." + nameof(GroupNames), this, m_GroupNames, value)) m_GroupNames = value; } } // 0x10 (16)
		
		protected GamePlatform m_Platform = new GamePlatform();
		[ContainerField(Name: "Platform", Offset: 20, NameHash: 942751002, Flags: 137)]
		public GamePlatform Platform { get { return m_Platform; } set { if (OnPropertyChanging("EntitlementQuery." + nameof(Platform), this, m_Platform, value)) m_Platform = value; } } // 0x14 (20)
		
		protected string m_EntitlementTag = string.Empty;
		[ContainerField(Name: "EntitlementTag", Offset: 24, NameHash: 1654763342, Flags: 16509), LayoutImmutable]
		public string EntitlementTag { get { return m_EntitlementTag; } set { if (OnPropertyChanging("EntitlementQuery." + nameof(EntitlementTag), this, m_EntitlementTag, value)) m_EntitlementTag = value; } } // 0x18 (24)
		
		protected string m_ProductId = string.Empty;
		[ContainerField(Name: "ProductId", Offset: 28, NameHash: 106414083, Flags: 16509), LayoutImmutable]
		public string ProductId { get { return m_ProductId; } set { if (OnPropertyChanging("EntitlementQuery." + nameof(ProductId), this, m_ProductId, value)) m_ProductId = value; } } // 0x1C (28)
		
		protected string m_ProjectId = string.Empty;
		[ContainerField(Name: "ProjectId", Offset: 32, NameHash: 4152360413, Flags: 16509), LayoutImmutable]
		public string ProjectId { get { return m_ProjectId; } set { if (OnPropertyChanging("EntitlementQuery." + nameof(ProjectId), this, m_ProjectId, value)) m_ProjectId = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2421825855:
					EntitlementsData = (List<EntitlementData>) p_Value;
					break;

				case 1803493518:
					GroupNames = (List<string>) p_Value;
					break;

				case 942751002:
					Platform = (GamePlatform) Enum.ToObject(typeof(GamePlatform), p_Value);
					break;

				case 1654763342:
					EntitlementTag = (string) p_Value;
					break;

				case 106414083:
					ProductId = (string) p_Value;
					break;

				case 4152360413:
					ProjectId = (string) p_Value;
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
				case 2421825855:
					return EntitlementsData;

				case 1803493518:
					return GroupNames;

				case 942751002:
					return Platform;

				case 1654763342:
					return EntitlementTag;

				case 106414083:
					return ProductId;

				case 4152360413:
					return ProjectId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2421825855:
					return typeof(EntitlementQuery).GetProperty(nameof(EntitlementsData));

				case 1803493518:
					return typeof(EntitlementQuery).GetProperty(nameof(GroupNames));

				case 942751002:
					return typeof(EntitlementQuery).GetProperty(nameof(Platform));

				case 1654763342:
					return typeof(EntitlementQuery).GetProperty(nameof(EntitlementTag));

				case 106414083:
					return typeof(EntitlementQuery).GetProperty(nameof(ProductId));

				case 4152360413:
					return typeof(EntitlementQuery).GetProperty(nameof(ProjectId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
