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
	public class OcclusionSettings : 
		DataContainer
	{
		protected bool m_Enable = new bool();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("OcclusionSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x8 (8)
		
		protected bool m_DrawZbuffer = new bool();
		[ContainerField(9), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(449305695)]
		public bool DrawZbuffer { get { return m_DrawZbuffer; } set { if (OnPropertyChanging("OcclusionSettings." + nameof(DrawZbuffer), this, m_DrawZbuffer, value)) m_DrawZbuffer = value; } } // 0x9 (9)
		
		protected bool m_DrawBinaryBuffer = new bool();
		[ContainerField(10), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(728628138)]
		public bool DrawBinaryBuffer { get { return m_DrawBinaryBuffer; } set { if (OnPropertyChanging("OcclusionSettings." + nameof(DrawBinaryBuffer), this, m_DrawBinaryBuffer, value)) m_DrawBinaryBuffer = value; } } // 0xA (10)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 449305695:
					DrawZbuffer = (bool) p_Value;
					break;

				case 728628138:
					DrawBinaryBuffer = (bool) p_Value;
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
				case 2342790116:
					return Enable;

				case 449305695:
					return DrawZbuffer;

				case 728628138:
					return DrawBinaryBuffer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2342790116:
					return typeof(OcclusionSettings).GetProperty(nameof(Enable));

				case 449305695:
					return typeof(OcclusionSettings).GetProperty(nameof(DrawZbuffer));

				case 728628138:
					return typeof(OcclusionSettings).GetProperty(nameof(DrawBinaryBuffer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
