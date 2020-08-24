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
	public class InterludeOrderEntityData : 
		BFOrderEntityData
	{
		protected bool m_IsCutscene = new bool();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2932449315)]
		public bool IsCutscene { get { return m_IsCutscene; } set { if (OnPropertyChanging("InterludeOrderEntityData." + nameof(IsCutscene), this, m_IsCutscene, value)) m_IsCutscene = value; } } // 0x28 (40)
		
		protected bool m_Crouch = new bool();
		[ContainerField(41), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2729602053)]
		public bool Crouch { get { return m_Crouch; } set { if (OnPropertyChanging("InterludeOrderEntityData." + nameof(Crouch), this, m_Crouch, value)) m_Crouch = value; } } // 0x29 (41)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2932449315:
					IsCutscene = (bool) p_Value;
					break;

				case 2729602053:
					Crouch = (bool) p_Value;
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
				case 2932449315:
					return IsCutscene;

				case 2729602053:
					return Crouch;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2932449315:
					return typeof(InterludeOrderEntityData).GetProperty(nameof(IsCutscene));

				case 2729602053:
					return typeof(InterludeOrderEntityData).GetProperty(nameof(Crouch));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
