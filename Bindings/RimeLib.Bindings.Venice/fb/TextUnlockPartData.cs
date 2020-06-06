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
	public class TextUnlockPartData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string ShaderNodeName { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<ObjectBlueprint> MeshBlueprint { get; set; } = new CtrRef<ObjectBlueprint>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4213969131:
					ShaderNodeName = (string) p_Value;
					break;

				case 1662348825:
					MeshBlueprint = (CtrRef<ObjectBlueprint>) p_Value;
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
				case 4213969131:
					return ShaderNodeName;

				case 1662348825:
					return MeshBlueprint;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4213969131:
					return typeof(TextUnlockPartData).GetProperty(nameof(ShaderNodeName));

				case 1662348825:
					return typeof(TextUnlockPartData).GetProperty(nameof(MeshBlueprint));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
