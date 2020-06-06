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
	public class CharacterCustomizationComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<CharacterSocketListAsset> SocketList { get; set; } = new CtrRef<CharacterSocketListAsset>(); // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<MeshLodGroup> SharedLodGroup { get; set; } = new CtrRef<MeshLodGroup>(); // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 648025282:
					SocketList = (CtrRef<CharacterSocketListAsset>) p_Value;
					break;

				case 1815069620:
					SharedLodGroup = (CtrRef<MeshLodGroup>) p_Value;
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
				case 648025282:
					return SocketList;

				case 1815069620:
					return SharedLodGroup;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 648025282:
					return typeof(CharacterCustomizationComponentData).GetProperty(nameof(SocketList));

				case 1815069620:
					return typeof(CharacterCustomizationComponentData).GetProperty(nameof(SharedLodGroup));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
