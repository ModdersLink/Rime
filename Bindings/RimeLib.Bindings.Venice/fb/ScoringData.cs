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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class ScoringData : 
		Asset
	{
		protected RefArray<ScoringTypeData> m_ScoringTypes = new RefArray<ScoringTypeData>();
		[ContainerField(Name: "ScoringTypes", Offset: 12, NameHash: 1268919875, Flags: 65)]
		public RefArray<ScoringTypeData> ScoringTypes { get { return m_ScoringTypes; } set { if (OnPropertyChanging("ScoringData." + nameof(ScoringTypes), this, m_ScoringTypes, value)) m_ScoringTypes = value; } } // 0xC (12)
		
		protected RefArray<ScoringHandlerData> m_ScoringHandlers = new RefArray<ScoringHandlerData>();
		[ContainerField(Name: "ScoringHandlers", Offset: 16, NameHash: 3193568419, Flags: 65)]
		public RefArray<ScoringHandlerData> ScoringHandlers { get { return m_ScoringHandlers; } set { if (OnPropertyChanging("ScoringData." + nameof(ScoringHandlers), this, m_ScoringHandlers, value)) m_ScoringHandlers = value; } } // 0x10 (16)
		
		protected RefArray<ScoringBucketData> m_Buckets = new RefArray<ScoringBucketData>();
		[ContainerField(Name: "Buckets", Offset: 20, NameHash: 2760100856, Flags: 65)]
		public RefArray<ScoringBucketData> Buckets { get { return m_Buckets; } set { if (OnPropertyChanging("ScoringData." + nameof(Buckets), this, m_Buckets, value)) m_Buckets = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1268919875:
					ScoringTypes = (RefArray<ScoringTypeData>) p_Value;
					break;

				case 3193568419:
					ScoringHandlers = (RefArray<ScoringHandlerData>) p_Value;
					break;

				case 2760100856:
					Buckets = (RefArray<ScoringBucketData>) p_Value;
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
				case 1268919875:
					return ScoringTypes;

				case 3193568419:
					return ScoringHandlers;

				case 2760100856:
					return Buckets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1268919875:
					return typeof(ScoringData).GetProperty(nameof(ScoringTypes));

				case 3193568419:
					return typeof(ScoringData).GetProperty(nameof(ScoringHandlers));

				case 2760100856:
					return typeof(ScoringData).GetProperty(nameof(Buckets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
