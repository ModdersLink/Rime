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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class VisualEnvironmentReferenceObjectData : 
		ReferenceObjectData
	{
		protected int m_Priority = new int();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3062102871)]
		public int Priority { get { return m_Priority; } set { if (OnPropertyChanging("VisualEnvironmentReferenceObjectData." + nameof(Priority), this, m_Priority, value)) m_Priority = value; } } // 0x60 (96)
		
		protected bool m_OverrideVisibility = new bool();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3611184311)]
		public bool OverrideVisibility { get { return m_OverrideVisibility; } set { if (OnPropertyChanging("VisualEnvironmentReferenceObjectData." + nameof(OverrideVisibility), this, m_OverrideVisibility, value)) m_OverrideVisibility = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3062102871:
					Priority = (int) p_Value;
					break;

				case 3611184311:
					OverrideVisibility = (bool) p_Value;
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
				case 3062102871:
					return Priority;

				case 3611184311:
					return OverrideVisibility;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3062102871:
					return typeof(VisualEnvironmentReferenceObjectData).GetProperty(nameof(Priority));

				case 3611184311:
					return typeof(VisualEnvironmentReferenceObjectData).GetProperty(nameof(OverrideVisibility));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
