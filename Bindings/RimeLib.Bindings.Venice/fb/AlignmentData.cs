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
	public class AlignmentData : 
		DataContainer
	{
		[ContainerField(8)]
		public EntryInputActionEnum AlignAction { get; set; } = new EntryInputActionEnum(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float StopTolerance { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Speed { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2810627638:
					AlignAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 3127075412:
					StopTolerance = (float) p_Value;
					break;

				case 230887042:
					Speed = (float) p_Value;
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
				case 2810627638:
					return AlignAction;

				case 3127075412:
					return StopTolerance;

				case 230887042:
					return Speed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2810627638:
					return typeof(AlignmentData).GetProperty(nameof(AlignAction));

				case 3127075412:
					return typeof(AlignmentData).GetProperty(nameof(StopTolerance));

				case 230887042:
					return typeof(AlignmentData).GetProperty(nameof(Speed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
