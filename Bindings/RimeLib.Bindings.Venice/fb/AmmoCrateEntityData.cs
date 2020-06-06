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
	public class AmmoCrateEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<MapMarkerEntityData> Marker { get; set; } = new CtrRef<MapMarkerEntityData>(); // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<StaticModelEntityData> Model { get; set; } = new CtrRef<StaticModelEntityData>(); // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float RefillDelay { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public bool EnableReplenish { get; set; } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2643283879:
					Marker = (CtrRef<MapMarkerEntityData>) p_Value;
					break;

				case 210011050:
					Model = (CtrRef<StaticModelEntityData>) p_Value;
					break;

				case 1895357000:
					RefillDelay = (float) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 720329910:
					EnableReplenish = (bool) p_Value;
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
				case 2643283879:
					return Marker;

				case 210011050:
					return Model;

				case 1895357000:
					return RefillDelay;

				case 3298407133:
					return Radius;

				case 720329910:
					return EnableReplenish;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2643283879:
					return typeof(AmmoCrateEntityData).GetProperty(nameof(Marker));

				case 210011050:
					return typeof(AmmoCrateEntityData).GetProperty(nameof(Model));

				case 1895357000:
					return typeof(AmmoCrateEntityData).GetProperty(nameof(RefillDelay));

				case 3298407133:
					return typeof(AmmoCrateEntityData).GetProperty(nameof(Radius));

				case 720329910:
					return typeof(AmmoCrateEntityData).GetProperty(nameof(EnableReplenish));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
