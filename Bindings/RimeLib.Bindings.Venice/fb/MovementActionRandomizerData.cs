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
	public class MovementActionRandomizerData : 
		MovementActionData
	{
		[ContainerField(8)]
		public RefArray<MovementActionData> Actions { get; set; } = new RefArray<MovementActionData>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool ReinsertIntoRandomizedListAfterUse { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 373511656:
					Actions = (RefArray<MovementActionData>) p_Value;
					break;

				case 201056821:
					ReinsertIntoRandomizedListAfterUse = (bool) p_Value;
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

				case 201056821:
					return ReinsertIntoRandomizedListAfterUse;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 373511656:
					return typeof(MovementActionRandomizerData).GetProperty(nameof(Actions));

				case 201056821:
					return typeof(MovementActionRandomizerData).GetProperty(nameof(ReinsertIntoRandomizedListAfterUse));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
