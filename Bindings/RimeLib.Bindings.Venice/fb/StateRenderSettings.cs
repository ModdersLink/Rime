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
	public class StateRenderSettings : 
		DataContainer
	{
		protected bool m_Ps3PixelShaderConstantsEnable = new bool();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4042857272)]
		public bool Ps3PixelShaderConstantsEnable { get { return m_Ps3PixelShaderConstantsEnable; } set { if (OnPropertyChanging("StateRenderSettings." + nameof(Ps3PixelShaderConstantsEnable), this, m_Ps3PixelShaderConstantsEnable, value)) m_Ps3PixelShaderConstantsEnable = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4042857272:
					Ps3PixelShaderConstantsEnable = (bool) p_Value;
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
				case 4042857272:
					return Ps3PixelShaderConstantsEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4042857272:
					return typeof(StateRenderSettings).GetProperty(nameof(Ps3PixelShaderConstantsEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
