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
	public class AntiRollBar : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Stiffness { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float TorqueActivationLimit { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 721813632:
					Stiffness = (float) p_Value;
					break;

				case 2156176460:
					TorqueActivationLimit = (float) p_Value;
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
				case 721813632:
					return Stiffness;

				case 2156176460:
					return TorqueActivationLimit;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 721813632:
					return typeof(AntiRollBar).GetProperty(nameof(Stiffness));

				case 2156176460:
					return typeof(AntiRollBar).GetProperty(nameof(TorqueActivationLimit));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
