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
	public class MaterialPropertyTerrainData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DirtTriggerColor { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32)]
		public CtrRef<EffectBlueprint> DestructionEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float DirtTriggerFactor { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2764380651:
					DirtTriggerColor = (Vec3) p_Value;
					break;

				case 3907820780:
					DestructionEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 602292507:
					DirtTriggerFactor = (float) p_Value;
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
				case 2764380651:
					return DirtTriggerColor;

				case 3907820780:
					return DestructionEffect;

				case 602292507:
					return DirtTriggerFactor;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2764380651:
					return typeof(MaterialPropertyTerrainData).GetProperty(nameof(DirtTriggerColor));

				case 3907820780:
					return typeof(MaterialPropertyTerrainData).GetProperty(nameof(DestructionEffect));

				case 602292507:
					return typeof(MaterialPropertyTerrainData).GetProperty(nameof(DirtTriggerFactor));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
