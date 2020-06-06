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
    [ContainerType(16)]
	public class ReferenceObjectData : 
		GameObjectData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform BlueprintTransform { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80)]
		public CtrRef<Blueprint> Blueprint { get; set; } = new CtrRef<Blueprint>(); // 0x50 (80)
		
		[ContainerField(84)]
		public CtrRef<ObjectVariation> ObjectVariation { get; set; } = new CtrRef<ObjectVariation>(); // 0x54 (84)
		
		[ContainerField(88)]
		public StreamRealm StreamRealm { get; set; } = new StreamRealm(); // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public bool CastSunShadowEnable { get; set; } // 0x5C (92)
		
		[ContainerField(93), LayoutImmutable, Blittable]
		public bool Excluded { get; set; } // 0x5D (93)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3885036614:
					BlueprintTransform = (LinearTransform) p_Value;
					break;

				case 4232469066:
					Blueprint = (CtrRef<Blueprint>) p_Value;
					break;

				case 3624336577:
					ObjectVariation = (CtrRef<ObjectVariation>) p_Value;
					break;

				case 1844114478:
					StreamRealm = (StreamRealm) Enum.ToObject(typeof(StreamRealm), p_Value);
					break;

				case 1557133743:
					CastSunShadowEnable = (bool) p_Value;
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
				case 3885036614:
					return BlueprintTransform;

				case 4232469066:
					return Blueprint;

				case 3624336577:
					return ObjectVariation;

				case 1844114478:
					return StreamRealm;

				case 1557133743:
					return CastSunShadowEnable;

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
				case 3885036614:
					return typeof(ReferenceObjectData).GetProperty(nameof(BlueprintTransform));

				case 4232469066:
					return typeof(ReferenceObjectData).GetProperty(nameof(Blueprint));

				case 3624336577:
					return typeof(ReferenceObjectData).GetProperty(nameof(ObjectVariation));

				case 1844114478:
					return typeof(ReferenceObjectData).GetProperty(nameof(StreamRealm));

				case 1557133743:
					return typeof(ReferenceObjectData).GetProperty(nameof(CastSunShadowEnable));

				case 755715367:
					return typeof(ReferenceObjectData).GetProperty(nameof(Excluded));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
