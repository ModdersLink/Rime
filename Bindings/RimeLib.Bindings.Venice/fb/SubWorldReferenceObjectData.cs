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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class SubWorldReferenceObjectData : 
		ReferenceObjectData
	{
		protected string m_BundleName = string.Empty;
		[ContainerField(96), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(461157046)]
		public string BundleName { get { return m_BundleName; } set { if (OnPropertyChanging("SubWorldReferenceObjectData." + nameof(BundleName), this, m_BundleName, value)) m_BundleName = value; } } // 0x60 (96)
		
		protected CtrRef<SubWorldInclusionSettings> m_InclusionSettings = new CtrRef<SubWorldInclusionSettings>();
		[ContainerField(100), MemberInfoFlag(53), ContainerFieldNameHash(1787638950), ContainerCtrRef]
		public CtrRef<SubWorldInclusionSettings> InclusionSettings { get { return m_InclusionSettings; } set { if (OnPropertyChanging("SubWorldReferenceObjectData." + nameof(InclusionSettings), this, m_InclusionSettings, value)) m_InclusionSettings = value; } } // 0x64 (100)
		
		protected bool m_AutoLoad = new bool();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3537348684)]
		public bool AutoLoad { get { return m_AutoLoad; } set { if (OnPropertyChanging("SubWorldReferenceObjectData." + nameof(AutoLoad), this, m_AutoLoad, value)) m_AutoLoad = value; } } // 0x68 (104)
		
		protected bool m_IsWin32SubLevel = new bool();
		[ContainerField(105), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2682003100)]
		public bool IsWin32SubLevel { get { return m_IsWin32SubLevel; } set { if (OnPropertyChanging("SubWorldReferenceObjectData." + nameof(IsWin32SubLevel), this, m_IsWin32SubLevel, value)) m_IsWin32SubLevel = value; } } // 0x69 (105)
		
		protected bool m_IsXenonSubLevel = new bool();
		[ContainerField(106), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(948884383)]
		public bool IsXenonSubLevel { get { return m_IsXenonSubLevel; } set { if (OnPropertyChanging("SubWorldReferenceObjectData." + nameof(IsXenonSubLevel), this, m_IsXenonSubLevel, value)) m_IsXenonSubLevel = value; } } // 0x6A (106)
		
		protected bool m_IsPs3SubLevel = new bool();
		[ContainerField(107), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(396788349)]
		public bool IsPs3SubLevel { get { return m_IsPs3SubLevel; } set { if (OnPropertyChanging("SubWorldReferenceObjectData." + nameof(IsPs3SubLevel), this, m_IsPs3SubLevel, value)) m_IsPs3SubLevel = value; } } // 0x6B (107)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 461157046:
					BundleName = (string) p_Value;
					break;

				case 1787638950:
					InclusionSettings = (CtrRef<SubWorldInclusionSettings>) p_Value;
					break;

				case 3537348684:
					AutoLoad = (bool) p_Value;
					break;

				case 2682003100:
					IsWin32SubLevel = (bool) p_Value;
					break;

				case 948884383:
					IsXenonSubLevel = (bool) p_Value;
					break;

				case 396788349:
					IsPs3SubLevel = (bool) p_Value;
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
				case 461157046:
					return BundleName;

				case 1787638950:
					return InclusionSettings;

				case 3537348684:
					return AutoLoad;

				case 2682003100:
					return IsWin32SubLevel;

				case 948884383:
					return IsXenonSubLevel;

				case 396788349:
					return IsPs3SubLevel;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 461157046:
					return typeof(SubWorldReferenceObjectData).GetProperty(nameof(BundleName));

				case 1787638950:
					return typeof(SubWorldReferenceObjectData).GetProperty(nameof(InclusionSettings));

				case 3537348684:
					return typeof(SubWorldReferenceObjectData).GetProperty(nameof(AutoLoad));

				case 2682003100:
					return typeof(SubWorldReferenceObjectData).GetProperty(nameof(IsWin32SubLevel));

				case 948884383:
					return typeof(SubWorldReferenceObjectData).GetProperty(nameof(IsXenonSubLevel));

				case 396788349:
					return typeof(SubWorldReferenceObjectData).GetProperty(nameof(IsPs3SubLevel));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
