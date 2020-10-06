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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class LinearTransformRecordingData : 
		PropertyRecordingData
	{
		protected List<LinearTransform> m_Values = new List<LinearTransform>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(3142410589), ContainerArray]
		public List<LinearTransform> Values { get { return m_Values; } set { if (OnPropertyChanging("LinearTransformRecordingData." + nameof(Values), this, m_Values, value)) m_Values = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3142410589:
					Values = (List<LinearTransform>) p_Value;
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
				case 3142410589:
					return Values;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3142410589:
					return typeof(LinearTransformRecordingData).GetProperty(nameof(Values));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
