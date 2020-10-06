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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(12), ContainerClass]
	public class Curve2D : 
		DataContainer
	{
		protected List<Vec2> m_Curve = new List<Vec2>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(212866962), ContainerArray]
		public List<Vec2> Curve { get { return m_Curve; } set { if (OnPropertyChanging("Curve2D." + nameof(Curve), this, m_Curve, value)) m_Curve = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 212866962:
					Curve = (List<Vec2>) p_Value;
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
				case 212866962:
					return Curve;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 212866962:
					return typeof(Curve2D).GetProperty(nameof(Curve));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
