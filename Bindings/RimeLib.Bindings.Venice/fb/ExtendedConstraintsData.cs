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
	public class ExtendedConstraintsData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Heading { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Width { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Falloff { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float AngularConstraintMin { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float AngularConstraintMax { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2009143629:
					Heading = (float) p_Value;
					break;

				case 226981187:
					Width = (float) p_Value;
					break;

				case 1431733965:
					Falloff = (float) p_Value;
					break;

				case 731814824:
					AngularConstraintMin = (float) p_Value;
					break;

				case 731815094:
					AngularConstraintMax = (float) p_Value;
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
				case 2009143629:
					return Heading;

				case 226981187:
					return Width;

				case 1431733965:
					return Falloff;

				case 731814824:
					return AngularConstraintMin;

				case 731815094:
					return AngularConstraintMax;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2009143629:
					return typeof(ExtendedConstraintsData).GetProperty(nameof(Heading));

				case 226981187:
					return typeof(ExtendedConstraintsData).GetProperty(nameof(Width));

				case 1431733965:
					return typeof(ExtendedConstraintsData).GetProperty(nameof(Falloff));

				case 731814824:
					return typeof(ExtendedConstraintsData).GetProperty(nameof(AngularConstraintMin));

				case 731815094:
					return typeof(ExtendedConstraintsData).GetProperty(nameof(AngularConstraintMax));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
