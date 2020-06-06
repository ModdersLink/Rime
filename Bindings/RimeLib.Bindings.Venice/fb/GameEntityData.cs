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
	public class GameEntityData : 
		SpatialEntityData
	{
		[ContainerField(80)]
		public RefArray<GameObjectData> Components { get; set; } = new RefArray<GameObjectData>(); // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x54 (84)
		
		[ContainerField(85), LayoutImmutable, Blittable]
		public sbyte RuntimeComponentCount { get; set; } // 0x55 (85)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3391050425:
					Components = (RefArray<GameObjectData>) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
					break;

				case 3928419541:
					RuntimeComponentCount = (sbyte) p_Value;
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
				case 3391050425:
					return Components;

				case 2662400:
					return Enabled;

				case 3928419541:
					return RuntimeComponentCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3391050425:
					return typeof(GameEntityData).GetProperty(nameof(Components));

				case 2662400:
					return typeof(GameEntityData).GetProperty(nameof(Enabled));

				case 3928419541:
					return typeof(GameEntityData).GetProperty(nameof(RuntimeComponentCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
