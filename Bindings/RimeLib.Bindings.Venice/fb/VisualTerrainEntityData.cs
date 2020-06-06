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
	public class VisualTerrainEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<TerrainData> Terrain { get; set; } = new CtrRef<TerrainData>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<VisualTerrainSettings> Settings { get; set; } = new CtrRef<VisualTerrainSettings>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3173545970:
					Terrain = (CtrRef<TerrainData>) p_Value;
					break;

				case 649772672:
					Settings = (CtrRef<VisualTerrainSettings>) p_Value;
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
				case 3173545970:
					return Terrain;

				case 649772672:
					return Settings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3173545970:
					return typeof(VisualTerrainEntityData).GetProperty(nameof(Terrain));

				case 649772672:
					return typeof(VisualTerrainEntityData).GetProperty(nameof(Settings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
