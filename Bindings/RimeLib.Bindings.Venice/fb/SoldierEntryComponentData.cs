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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(224), ContainerClass]
	public class SoldierEntryComponentData : 
		EntryComponentData
	{
		protected AimingConstraintsData m_AimingConstraints = new AimingConstraintsData();
		[ContainerField(192), MemberInfoFlag(41), ContainerFieldNameHash(1523178198)]
		public AimingConstraintsData AimingConstraints { get { return m_AimingConstraints; } set { if (OnPropertyChanging("SoldierEntryComponentData." + nameof(AimingConstraints), this, m_AimingConstraints, value)) m_AimingConstraints = value; } } // 0xC0 (192)
		
		protected CtrRef<AntEnumeration> m_AntEntryEnumeration = new CtrRef<AntEnumeration>();
		[ContainerField(208), MemberInfoFlag(53), ContainerFieldNameHash(1819698227), ContainerCtrRef]
		public CtrRef<AntEnumeration> AntEntryEnumeration { get { return m_AntEntryEnumeration; } set { if (OnPropertyChanging("SoldierEntryComponentData." + nameof(AntEntryEnumeration), this, m_AntEntryEnumeration, value)) m_AntEntryEnumeration = value; } } // 0xD0 (208)
		
		protected bool m_AlignConstraintsToEntity = new bool();
		[ContainerField(212), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3847387294)]
		public bool AlignConstraintsToEntity { get { return m_AlignConstraintsToEntity; } set { if (OnPropertyChanging("SoldierEntryComponentData." + nameof(AlignConstraintsToEntity), this, m_AlignConstraintsToEntity, value)) m_AlignConstraintsToEntity = value; } } // 0xD4 (212)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1523178198:
					AimingConstraints = (AimingConstraintsData) p_Value;
					break;

				case 1819698227:
					AntEntryEnumeration = (CtrRef<AntEnumeration>) p_Value;
					break;

				case 3847387294:
					AlignConstraintsToEntity = (bool) p_Value;
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
				case 1523178198:
					return AimingConstraints;

				case 1819698227:
					return AntEntryEnumeration;

				case 3847387294:
					return AlignConstraintsToEntity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1523178198:
					return typeof(SoldierEntryComponentData).GetProperty(nameof(AimingConstraints));

				case 1819698227:
					return typeof(SoldierEntryComponentData).GetProperty(nameof(AntEntryEnumeration));

				case 3847387294:
					return typeof(SoldierEntryComponentData).GetProperty(nameof(AlignConstraintsToEntity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
