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
	public class SlidingStateData : 
		CharacterStateData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float HorizontalInputScale { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float GravityScale { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 770027349:
					HorizontalInputScale = (float) p_Value;
					break;

				case 1341716283:
					GravityScale = (float) p_Value;
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
				case 770027349:
					return HorizontalInputScale;

				case 1341716283:
					return GravityScale;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 770027349:
					return typeof(SlidingStateData).GetProperty(nameof(HorizontalInputScale));

				case 1341716283:
					return typeof(SlidingStateData).GetProperty(nameof(GravityScale));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
