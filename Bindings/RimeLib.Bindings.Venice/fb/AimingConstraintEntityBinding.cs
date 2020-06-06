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
	public class AimingConstraintEntityBinding : FrostbiteContainer
	{
		[ContainerField(0)]
		public AntRef ProneAimLimit { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4)]
		public AntRef ProneAimDistance { get; set; } = new AntRef(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2127182771:
					ProneAimLimit = (AntRef) p_Value;
					break;

				case 205160165:
					ProneAimDistance = (AntRef) p_Value;
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
				case 2127182771:
					return ProneAimLimit;

				case 205160165:
					return ProneAimDistance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2127182771:
					return typeof(AimingConstraintEntityBinding).GetProperty(nameof(ProneAimLimit));

				case 205160165:
					return typeof(AimingConstraintEntityBinding).GetProperty(nameof(ProneAimDistance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
