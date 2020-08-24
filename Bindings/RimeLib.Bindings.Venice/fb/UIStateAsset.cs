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
	public class UIStateAsset : 
		Asset
	{
		protected RefArray<UIComponentData> m_UIComponents = new RefArray<UIComponentData>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(4207180421), ContainerRefArray]
		public RefArray<UIComponentData> UIComponents { get { return m_UIComponents; } set { if (OnPropertyChanging("UIStateAsset." + nameof(UIComponents), this, m_UIComponents, value)) m_UIComponents = value; } } // 0xC (12)
		
		protected RefArray<UIAsset> m_ActionscriptLibraries = new RefArray<UIAsset>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(439634061), ContainerRefArray]
		public RefArray<UIAsset> ActionscriptLibraries { get { return m_ActionscriptLibraries; } set { if (OnPropertyChanging("UIStateAsset." + nameof(ActionscriptLibraries), this, m_ActionscriptLibraries, value)) m_ActionscriptLibraries = value; } } // 0x10 (16)
		
		protected List<string> m_ActionscriptNames = new List<string>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(581231424), ContainerArray]
		public List<string> ActionscriptNames { get { return m_ActionscriptNames; } set { if (OnPropertyChanging("UIStateAsset." + nameof(ActionscriptNames), this, m_ActionscriptNames, value)) m_ActionscriptNames = value; } } // 0x14 (20)
		
		protected string m_StateName = string.Empty;
		[ContainerField(24), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(4126874677)]
		public string StateName { get { return m_StateName; } set { if (OnPropertyChanging("UIStateAsset." + nameof(StateName), this, m_StateName, value)) m_StateName = value; } } // 0x18 (24)
		
		protected string m_StatePath = string.Empty;
		[ContainerField(28), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(4126080863)]
		public string StatePath { get { return m_StatePath; } set { if (OnPropertyChanging("UIStateAsset." + nameof(StatePath), this, m_StatePath, value)) m_StatePath = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4207180421:
					UIComponents = (RefArray<UIComponentData>) p_Value;
					break;

				case 439634061:
					ActionscriptLibraries = (RefArray<UIAsset>) p_Value;
					break;

				case 581231424:
					ActionscriptNames = (List<string>) p_Value;
					break;

				case 4126874677:
					StateName = (string) p_Value;
					break;

				case 4126080863:
					StatePath = (string) p_Value;
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
				case 4207180421:
					return UIComponents;

				case 439634061:
					return ActionscriptLibraries;

				case 581231424:
					return ActionscriptNames;

				case 4126874677:
					return StateName;

				case 4126080863:
					return StatePath;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4207180421:
					return typeof(UIStateAsset).GetProperty(nameof(UIComponents));

				case 439634061:
					return typeof(UIStateAsset).GetProperty(nameof(ActionscriptLibraries));

				case 581231424:
					return typeof(UIStateAsset).GetProperty(nameof(ActionscriptNames));

				case 4126874677:
					return typeof(UIStateAsset).GetProperty(nameof(StateName));

				case 4126080863:
					return typeof(UIStateAsset).GetProperty(nameof(StatePath));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
