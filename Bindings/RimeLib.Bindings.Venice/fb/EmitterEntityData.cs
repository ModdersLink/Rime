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
	public class EmitterEntityData : 
		EffectEntityData
	{
		[ContainerField(112)]
		public CtrRef<EmitterAsset> Emitter { get; set; } = new CtrRef<EmitterAsset>(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float SpawnProbability { get; set; } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 23395891:
					Emitter = (CtrRef<EmitterAsset>) p_Value;
					break;

				case 2017232915:
					SpawnProbability = (float) p_Value;
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
				case 23395891:
					return Emitter;

				case 2017232915:
					return SpawnProbability;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 23395891:
					return typeof(EmitterEntityData).GetProperty(nameof(Emitter));

				case 2017232915:
					return typeof(EmitterEntityData).GetProperty(nameof(SpawnProbability));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
