///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class ComponentData : 
		GameObjectData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80)]
		public RefArray<GameObjectData> Components { get; set; } = new RefArray<GameObjectData>(); // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public bool Excluded { get; set; } // 0x54 (84)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 3391050425:
					Components = (RefArray<GameObjectData>) p_Value;
					break;

				case 755715367:
					Excluded = (bool) p_Value;
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
				case 2270319721:
					return Transform;

				case 3391050425:
					return Components;

				case 755715367:
					return Excluded;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(ComponentData).GetProperty(nameof(Transform));

				case 3391050425:
					return typeof(ComponentData).GetProperty(nameof(Components));

				case 755715367:
					return typeof(ComponentData).GetProperty(nameof(Excluded));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
