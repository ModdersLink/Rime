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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class RecordedInputData : 
		Asset
	{
		protected List<InputRecorderTrackData> m_TrackData = new List<InputRecorderTrackData>();
		[ContainerField(Name: "TrackData", Offset: 12, NameHash: 1756028410, Flags: 65)]
		public List<InputRecorderTrackData> TrackData { get { return m_TrackData; } set { if (OnPropertyChanging("RecordedInputData." + nameof(TrackData), this, m_TrackData, value)) m_TrackData = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1756028410:
					TrackData = (List<InputRecorderTrackData>) p_Value;
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
				case 1756028410:
					return TrackData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1756028410:
					return typeof(RecordedInputData).GetProperty(nameof(TrackData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
