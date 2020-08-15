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
	[ContainerType(4)]
	public class NetworkableLoosePartPhysicsData : 
		LoosePartPhysicsData
	{
		protected bool m_Networked = new bool();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(1516563994)]
		public bool Networked { get { return m_Networked; } set { if (OnPropertyChanging("NetworkableLoosePartPhysicsData." + nameof(Networked), this, m_Networked, value)) m_Networked = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1516563994:
					Networked = (bool) p_Value;
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
				case 1516563994:
					return Networked;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1516563994:
					return typeof(NetworkableLoosePartPhysicsData).GetProperty(nameof(Networked));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
