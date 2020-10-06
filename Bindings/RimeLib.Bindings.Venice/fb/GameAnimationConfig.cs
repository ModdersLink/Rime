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
	public class GameAnimationConfig : 
		Asset
	{
		protected bool m_ServerEnable = new bool();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3875294337)]
		public bool ServerEnable { get { return m_ServerEnable; } set { if (OnPropertyChanging("GameAnimationConfig." + nameof(ServerEnable), this, m_ServerEnable, value)) m_ServerEnable = value; } } // 0xC (12)
		
		protected bool m_ClientEnable = new bool();
		[ContainerField(13), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1069919325)]
		public bool ClientEnable { get { return m_ClientEnable; } set { if (OnPropertyChanging("GameAnimationConfig." + nameof(ClientEnable), this, m_ClientEnable, value)) m_ClientEnable = value; } } // 0xD (13)
		
		protected bool m_UseRawGamepadInput = new bool();
		[ContainerField(14), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2767734287)]
		public bool UseRawGamepadInput { get { return m_UseRawGamepadInput; } set { if (OnPropertyChanging("GameAnimationConfig." + nameof(UseRawGamepadInput), this, m_UseRawGamepadInput, value)) m_UseRawGamepadInput = value; } } // 0xE (14)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3875294337:
					ServerEnable = (bool) p_Value;
					break;

				case 1069919325:
					ClientEnable = (bool) p_Value;
					break;

				case 2767734287:
					UseRawGamepadInput = (bool) p_Value;
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
				case 3875294337:
					return ServerEnable;

				case 1069919325:
					return ClientEnable;

				case 2767734287:
					return UseRawGamepadInput;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3875294337:
					return typeof(GameAnimationConfig).GetProperty(nameof(ServerEnable));

				case 1069919325:
					return typeof(GameAnimationConfig).GetProperty(nameof(ClientEnable));

				case 2767734287:
					return typeof(GameAnimationConfig).GetProperty(nameof(UseRawGamepadInput));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
