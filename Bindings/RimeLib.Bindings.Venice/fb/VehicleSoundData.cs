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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class VehicleSoundData : 
		DataContainer
	{
		protected CtrRef<SoundAsset> m_BulletImpact = new CtrRef<SoundAsset>();
		[ContainerField(Name: "BulletImpact", Offset: 8, NameHash: 1157477793, Flags: 53)]
		public CtrRef<SoundAsset> BulletImpact { get { return m_BulletImpact; } set { if (OnPropertyChanging("VehicleSoundData." + nameof(BulletImpact), this, m_BulletImpact, value)) m_BulletImpact = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1157477793:
					BulletImpact = (CtrRef<SoundAsset>) p_Value;
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
				case 1157477793:
					return BulletImpact;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1157477793:
					return typeof(VehicleSoundData).GetProperty(nameof(BulletImpact));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
