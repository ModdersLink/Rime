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
	public class MovementActionGroupData : 
		MovementActionData
	{
		[ContainerField(8)]
		public RefArray<MovementActionData> Actions { get; set; } = new RefArray<MovementActionData>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool RunSimultaneously { get; set; } // 0xC (12)
		
		[ContainerField(13), LayoutImmutable, Blittable]
		public bool RestartChildren { get; set; } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 373511656:
					Actions = (RefArray<MovementActionData>) p_Value;
					break;

				case 2322374336:
					RunSimultaneously = (bool) p_Value;
					break;

				case 3914911489:
					RestartChildren = (bool) p_Value;
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
				case 373511656:
					return Actions;

				case 2322374336:
					return RunSimultaneously;

				case 3914911489:
					return RestartChildren;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 373511656:
					return typeof(MovementActionGroupData).GetProperty(nameof(Actions));

				case 2322374336:
					return typeof(MovementActionGroupData).GetProperty(nameof(RunSimultaneously));

				case 3914911489:
					return typeof(MovementActionGroupData).GetProperty(nameof(RestartChildren));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
