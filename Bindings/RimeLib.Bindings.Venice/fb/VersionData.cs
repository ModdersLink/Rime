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
	public class VersionData : 
		Asset
	{
		protected string m_disclaimer = string.Empty;
		[ContainerField(12), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(33610342)]
		public string disclaimer { get { return m_disclaimer; } set { if (OnPropertyChanging("VersionData." + nameof(disclaimer), this, m_disclaimer, value)) m_disclaimer = value; } } // 0xC (12)
		
		protected int m_Version = new int();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(747123679)]
		public int Version { get { return m_Version; } set { if (OnPropertyChanging("VersionData." + nameof(Version), this, m_Version, value)) m_Version = value; } } // 0x10 (16)
		
		protected string m_DateTime = string.Empty;
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3244533220)]
		public string DateTime { get { return m_DateTime; } set { if (OnPropertyChanging("VersionData." + nameof(DateTime), this, m_DateTime, value)) m_DateTime = value; } } // 0x14 (20)
		
		protected string m_BranchId = string.Empty;
		[ContainerField(24), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2969494588)]
		public string BranchId { get { return m_BranchId; } set { if (OnPropertyChanging("VersionData." + nameof(BranchId), this, m_BranchId, value)) m_BranchId = value; } } // 0x18 (24)
		
		protected string m_GameName = string.Empty;
		[ContainerField(28), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(509587500)]
		public string GameName { get { return m_GameName; } set { if (OnPropertyChanging("VersionData." + nameof(GameName), this, m_GameName, value)) m_GameName = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 33610342:
					disclaimer = (string) p_Value;
					break;

				case 747123679:
					Version = (int) p_Value;
					break;

				case 3244533220:
					DateTime = (string) p_Value;
					break;

				case 2969494588:
					BranchId = (string) p_Value;
					break;

				case 509587500:
					GameName = (string) p_Value;
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
				case 33610342:
					return disclaimer;

				case 747123679:
					return Version;

				case 3244533220:
					return DateTime;

				case 2969494588:
					return BranchId;

				case 509587500:
					return GameName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 33610342:
					return typeof(VersionData).GetProperty(nameof(disclaimer));

				case 747123679:
					return typeof(VersionData).GetProperty(nameof(Version));

				case 3244533220:
					return typeof(VersionData).GetProperty(nameof(DateTime));

				case 2969494588:
					return typeof(VersionData).GetProperty(nameof(BranchId));

				case 509587500:
					return typeof(VersionData).GetProperty(nameof(GameName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
