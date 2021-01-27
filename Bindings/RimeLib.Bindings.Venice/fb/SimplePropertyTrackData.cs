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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class SimplePropertyTrackData : 
		PropertyTrackData
	{
		protected InterpolationType m_InterpolationType = new InterpolationType();
		[ContainerField(Name: "InterpolationType", Offset: 16, NameHash: 1709219799, Flags: 137)]
		public InterpolationType InterpolationType { get { return m_InterpolationType; } set { if (OnPropertyChanging("SimplePropertyTrackData." + nameof(InterpolationType), this, m_InterpolationType, value)) m_InterpolationType = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1709219799:
					InterpolationType = (InterpolationType) Enum.ToObject(typeof(InterpolationType), p_Value);
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
				case 1709219799:
					return InterpolationType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1709219799:
					return typeof(SimplePropertyTrackData).GetProperty(nameof(InterpolationType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
