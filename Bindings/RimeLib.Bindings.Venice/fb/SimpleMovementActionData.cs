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
	public class SimpleMovementActionData : 
		SimpleMovementActionBaseData
	{
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Level { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public EntryInputActionEnum Action { get; set; } = new EntryInputActionEnum(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int SpecialAnimationIndex { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Respawn { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool Teleport { get; set; } // 0x25 (37)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 218262515:
					Level = (float) p_Value;
					break;

				case 2484178491:
					Action = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 502517260:
					SpecialAnimationIndex = (int) p_Value;
					break;

				case 1303651241:
					Respawn = (bool) p_Value;
					break;

				case 2495240740:
					Teleport = (bool) p_Value;
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
				case 218262515:
					return Level;

				case 2484178491:
					return Action;

				case 502517260:
					return SpecialAnimationIndex;

				case 1303651241:
					return Respawn;

				case 2495240740:
					return Teleport;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 218262515:
					return typeof(SimpleMovementActionData).GetProperty(nameof(Level));

				case 2484178491:
					return typeof(SimpleMovementActionData).GetProperty(nameof(Action));

				case 502517260:
					return typeof(SimpleMovementActionData).GetProperty(nameof(SpecialAnimationIndex));

				case 1303651241:
					return typeof(SimpleMovementActionData).GetProperty(nameof(Respawn));

				case 2495240740:
					return typeof(SimpleMovementActionData).GetProperty(nameof(Teleport));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
