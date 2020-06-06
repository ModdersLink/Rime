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
	public class CharacterPhysicsComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<CharacterPhysicsData> CharacterPhysics { get; set; } = new CtrRef<CharacterPhysicsData>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public bool EnableCollisionOnSpawn { get; set; } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4032988407:
					CharacterPhysics = (CtrRef<CharacterPhysicsData>) p_Value;
					break;

				case 1861797248:
					EnableCollisionOnSpawn = (bool) p_Value;
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
				case 4032988407:
					return CharacterPhysics;

				case 1861797248:
					return EnableCollisionOnSpawn;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4032988407:
					return typeof(CharacterPhysicsComponentData).GetProperty(nameof(CharacterPhysics));

				case 1861797248:
					return typeof(CharacterPhysicsComponentData).GetProperty(nameof(EnableCollisionOnSpawn));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
