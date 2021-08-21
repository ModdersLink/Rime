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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class PackagingCellData : 
		EntityData
	{
		protected RefArray<PackagingRule> m_Rules = new RefArray<PackagingRule>();
		[ContainerField(Name: "Rules", Offset: 12, NameHash: 229400568, Flags: 65)]
		public RefArray<PackagingRule> Rules { get { return m_Rules; } set { if (OnPropertyChanging("PackagingCellData." + nameof(Rules), this, m_Rules, value)) m_Rules = value; } } // 0xC (12)
		
		protected RefArray<PackagingCellData> m_Targets = new RefArray<PackagingCellData>();
		[ContainerField(Name: "Targets", Offset: 16, NameHash: 3016537383, Flags: 65)]
		public RefArray<PackagingCellData> Targets { get { return m_Targets; } set { if (OnPropertyChanging("PackagingCellData." + nameof(Targets), this, m_Targets, value)) m_Targets = value; } } // 0x10 (16)
		
		protected List<Vec2> m_Shape = new List<Vec2>();
		[ContainerField(Name: "Shape", Offset: 20, NameHash: 231753450, Flags: 65)]
		public List<Vec2> Shape { get { return m_Shape; } set { if (OnPropertyChanging("PackagingCellData." + nameof(Shape), this, m_Shape, value)) m_Shape = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229400568:
					Rules = (RefArray<PackagingRule>) p_Value;
					break;

				case 3016537383:
					Targets = (RefArray<PackagingCellData>) p_Value;
					break;

				case 231753450:
					Shape = (List<Vec2>) p_Value;
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
				case 229400568:
					return Rules;

				case 3016537383:
					return Targets;

				case 231753450:
					return Shape;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229400568:
					return typeof(PackagingCellData).GetProperty(nameof(Rules));

				case 3016537383:
					return typeof(PackagingCellData).GetProperty(nameof(Targets));

				case 231753450:
					return typeof(PackagingCellData).GetProperty(nameof(Shape));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
