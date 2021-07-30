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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class SoundMasterPatchAsset : 
		SoundGraphAsset
	{
		protected RefArray<SoundBusData> m_Busses = new RefArray<SoundBusData>();
		[ContainerField(Name: "Busses", Offset: 24, NameHash: 2686083620, Flags: 65)]
		public RefArray<SoundBusData> Busses { get { return m_Busses; } set { if (OnPropertyChanging("SoundMasterPatchAsset." + nameof(Busses), this, m_Busses, value)) m_Busses = value; } } // 0x18 (24)
		
		protected CtrRef<SoundBusData> m_RwMovieBus = new CtrRef<SoundBusData>();
		[ContainerField(Name: "RwMovieBus", Offset: 28, NameHash: 2351289820, Flags: 53)]
		public CtrRef<SoundBusData> RwMovieBus { get { return m_RwMovieBus; } set { if (OnPropertyChanging("SoundMasterPatchAsset." + nameof(RwMovieBus), this, m_RwMovieBus, value)) m_RwMovieBus = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2686083620:
					Busses = (RefArray<SoundBusData>) p_Value;
					break;

				case 2351289820:
					RwMovieBus = (CtrRef<SoundBusData>) p_Value;
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
				case 2686083620:
					return Busses;

				case 2351289820:
					return RwMovieBus;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2686083620:
					return typeof(SoundMasterPatchAsset).GetProperty(nameof(Busses));

				case 2351289820:
					return typeof(SoundMasterPatchAsset).GetProperty(nameof(RwMovieBus));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
