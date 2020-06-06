///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoundTestParamTask : 
		SoundTestTaskSpec
	{
		[ContainerField(16), LayoutImmutable]
		public string ParamName { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public SoundTestParamBehavior Behavior { get; set; } = new SoundTestParamBehavior(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float RangeMin { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float RangeMax { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float InitialValue { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2964687917:
					ParamName = (string) p_Value;
					break;

				case 1967808137:
					Behavior = (SoundTestParamBehavior) Enum.ToObject(typeof(SoundTestParamBehavior), p_Value);
					break;

				case 1752513616:
					RangeMin = (float) p_Value;
					break;

				case 1752513358:
					RangeMax = (float) p_Value;
					break;

				case 3684126256:
					InitialValue = (float) p_Value;
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
				case 2964687917:
					return ParamName;

				case 1967808137:
					return Behavior;

				case 1752513616:
					return RangeMin;

				case 1752513358:
					return RangeMax;

				case 3684126256:
					return InitialValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2964687917:
					return typeof(SoundTestParamTask).GetProperty(nameof(ParamName));

				case 1967808137:
					return typeof(SoundTestParamTask).GetProperty(nameof(Behavior));

				case 1752513616:
					return typeof(SoundTestParamTask).GetProperty(nameof(RangeMin));

				case 1752513358:
					return typeof(SoundTestParamTask).GetProperty(nameof(RangeMax));

				case 3684126256:
					return typeof(SoundTestParamTask).GetProperty(nameof(InitialValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
