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
	public class TerrainEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112)]
		public CtrRef<TerrainData> TerrainAsset { get; set; } = new CtrRef<TerrainData>(); // 0x70 (112)
		
		[ContainerField(116)]
		public CtrRef<MaterialContainerPair> WaterMaterial { get; set; } = new CtrRef<MaterialContainerPair>(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public bool Visible { get; set; } // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 84434530:
					TerrainAsset = (CtrRef<TerrainData>) p_Value;
					break;

				case 2658409947:
					WaterMaterial = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
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
				case 84434530:
					return TerrainAsset;

				case 2658409947:
					return WaterMaterial;

				case 901540267:
					return Visible;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 84434530:
					return typeof(TerrainEntityData).GetProperty(nameof(TerrainAsset));

				case 2658409947:
					return typeof(TerrainEntityData).GetProperty(nameof(WaterMaterial));

				case 901540267:
					return typeof(TerrainEntityData).GetProperty(nameof(Visible));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
