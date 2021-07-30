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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class TimingViewCategory : 
		DataContainer
	{
		protected string m_CategoryName = string.Empty;
		[ContainerField(Name: "CategoryName", Offset: 8, NameHash: 1997430002, Flags: 16509), LayoutImmutable]
		public string CategoryName { get { return m_CategoryName; } set { if (OnPropertyChanging("TimingViewCategory." + nameof(CategoryName), this, m_CategoryName, value)) m_CategoryName = value; } } // 0x8 (8)
		
		protected List<string> m_Keywords = new List<string>();
		[ContainerField(Name: "Keywords", Offset: 12, NameHash: 4091618511, Flags: 65)]
		public List<string> Keywords { get { return m_Keywords; } set { if (OnPropertyChanging("TimingViewCategory." + nameof(Keywords), this, m_Keywords, value)) m_Keywords = value; } } // 0xC (12)
		
		protected float m_SpuBudget = new float();
		[ContainerField(Name: "SpuBudget", Offset: 16, NameHash: 3212164214, Flags: 49469), LayoutImmutable, Blittable]
		public float SpuBudget { get { return m_SpuBudget; } set { if (OnPropertyChanging("TimingViewCategory." + nameof(SpuBudget), this, m_SpuBudget, value)) m_SpuBudget = value; } } // 0x10 (16)
		
		protected float m_CpuBudget = new float();
		[ContainerField(Name: "CpuBudget", Offset: 20, NameHash: 1659158630, Flags: 49469), LayoutImmutable, Blittable]
		public float CpuBudget { get { return m_CpuBudget; } set { if (OnPropertyChanging("TimingViewCategory." + nameof(CpuBudget), this, m_CpuBudget, value)) m_CpuBudget = value; } } // 0x14 (20)
		
		protected float m_GpuBudget = new float();
		[ContainerField(Name: "GpuBudget", Offset: 24, NameHash: 4164444258, Flags: 49469), LayoutImmutable, Blittable]
		public float GpuBudget { get { return m_GpuBudget; } set { if (OnPropertyChanging("TimingViewCategory." + nameof(GpuBudget), this, m_GpuBudget, value)) m_GpuBudget = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1997430002:
					CategoryName = (string) p_Value;
					break;

				case 4091618511:
					Keywords = (List<string>) p_Value;
					break;

				case 3212164214:
					SpuBudget = (float) p_Value;
					break;

				case 1659158630:
					CpuBudget = (float) p_Value;
					break;

				case 4164444258:
					GpuBudget = (float) p_Value;
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
				case 1997430002:
					return CategoryName;

				case 4091618511:
					return Keywords;

				case 3212164214:
					return SpuBudget;

				case 1659158630:
					return CpuBudget;

				case 4164444258:
					return GpuBudget;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1997430002:
					return typeof(TimingViewCategory).GetProperty(nameof(CategoryName));

				case 4091618511:
					return typeof(TimingViewCategory).GetProperty(nameof(Keywords));

				case 3212164214:
					return typeof(TimingViewCategory).GetProperty(nameof(SpuBudget));

				case 1659158630:
					return typeof(TimingViewCategory).GetProperty(nameof(CpuBudget));

				case 4164444258:
					return typeof(TimingViewCategory).GetProperty(nameof(GpuBudget));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
