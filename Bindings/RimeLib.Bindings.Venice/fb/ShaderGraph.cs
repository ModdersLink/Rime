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
	public class ShaderGraph : 
		SurfaceShaderBaseAsset
	{
		protected uint m_MaxSubMaterialCount = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2130556957)]
		public uint MaxSubMaterialCount { get { return m_MaxSubMaterialCount; } set { if (OnPropertyChanging("ShaderGraph." + nameof(MaxSubMaterialCount), this, m_MaxSubMaterialCount, value)) m_MaxSubMaterialCount = value; } } // 0xC (12)
		
		protected bool m_GammaCorrectionEnable = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(315798933)]
		public bool GammaCorrectionEnable { get { return m_GammaCorrectionEnable; } set { if (OnPropertyChanging("ShaderGraph." + nameof(GammaCorrectionEnable), this, m_GammaCorrectionEnable, value)) m_GammaCorrectionEnable = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2130556957:
					MaxSubMaterialCount = (uint) p_Value;
					break;

				case 315798933:
					GammaCorrectionEnable = (bool) p_Value;
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
				case 2130556957:
					return MaxSubMaterialCount;

				case 315798933:
					return GammaCorrectionEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2130556957:
					return typeof(ShaderGraph).GetProperty(nameof(MaxSubMaterialCount));

				case 315798933:
					return typeof(ShaderGraph).GetProperty(nameof(GammaCorrectionEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
