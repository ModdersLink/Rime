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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class SceneRecordingData : 
		DataContainer
	{
		protected RefArray<EntityRecordingData> m_Data = new RefArray<EntityRecordingData>();
		[ContainerField(Name: "Data", Offset: 8, NameHash: 2088730869, Flags: 65)]
		public RefArray<EntityRecordingData> Data { get { return m_Data; } set { if (OnPropertyChanging("SceneRecordingData." + nameof(Data), this, m_Data, value)) m_Data = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088730869:
					Data = (RefArray<EntityRecordingData>) p_Value;
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
				case 2088730869:
					return Data;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088730869:
					return typeof(SceneRecordingData).GetProperty(nameof(Data));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
