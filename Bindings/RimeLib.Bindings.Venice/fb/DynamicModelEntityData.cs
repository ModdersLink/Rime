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
	public class DynamicModelEntityData : 
		DynamicGamePhysicsEntityData
	{
		[ContainerField(112)]
		public CtrRef<PartComponentData> Part { get; set; } = new CtrRef<PartComponentData>(); // 0x70 (112)
		
		[ContainerField(116)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new CtrRef<MeshAsset>(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public bool NoCollision { get; set; } // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089448370:
					Part = (CtrRef<PartComponentData>) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 3513186074:
					NoCollision = (bool) p_Value;
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
				case 2089448370:
					return Part;

				case 2088783990:
					return Mesh;

				case 3513186074:
					return NoCollision;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089448370:
					return typeof(DynamicModelEntityData).GetProperty(nameof(Part));

				case 2088783990:
					return typeof(DynamicModelEntityData).GetProperty(nameof(Mesh));

				case 3513186074:
					return typeof(DynamicModelEntityData).GetProperty(nameof(NoCollision));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
