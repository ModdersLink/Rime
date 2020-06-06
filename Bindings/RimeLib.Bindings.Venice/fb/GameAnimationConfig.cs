///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class GameAnimationConfig : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool ServerEnable { get; set; } // 0xC (12)
		
		[ContainerField(13), LayoutImmutable, Blittable]
		public bool ClientEnable { get; set; } // 0xD (13)
		
		[ContainerField(14), LayoutImmutable, Blittable]
		public bool UseRawGamepadInput { get; set; } // 0xE (14)
		
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
