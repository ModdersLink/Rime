///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class EmitterEntityData : 
		EffectEntityData
	{
		protected CtrRef<EmitterAsset> m_Emitter = new CtrRef<EmitterAsset>();
		[ContainerField(Name: "Emitter", Offset: 112, NameHash: 23395891, Flags: 53)]
		public CtrRef<EmitterAsset> Emitter { get { return m_Emitter; } set { if (OnPropertyChanging("EmitterEntityData." + nameof(Emitter), this, m_Emitter, value)) m_Emitter = value; } } // 0x70 (112)
		
		protected float m_SpawnProbability = new float();
		[ContainerField(Name: "SpawnProbability", Offset: 116, NameHash: 2017232915, Flags: 49469), LayoutImmutable, Blittable]
		public float SpawnProbability { get { return m_SpawnProbability; } set { if (OnPropertyChanging("EmitterEntityData." + nameof(SpawnProbability), this, m_SpawnProbability, value)) m_SpawnProbability = value; } } // 0x74 (116)
		
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
