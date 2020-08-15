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
	[ContainerType(4)]
	public class UIAwardsScreenCompData : 
		UIComponentData
	{
		protected RefArray<StatsCategoryBaseData> m_TrackableAwardRow = new RefArray<StatsCategoryBaseData>();
		[ContainerField(28), ContainerFieldNameHash(383950411)]
		public RefArray<StatsCategoryBaseData> TrackableAwardRow { get { return m_TrackableAwardRow; } set { if (OnPropertyChanging("UIAwardsScreenCompData." + nameof(TrackableAwardRow), this, m_TrackableAwardRow, value)) m_TrackableAwardRow = value; } } // 0x1C (28)
		
		protected RefArray<StatsCategoryBaseData> m_TrackableAwardCol = new RefArray<StatsCategoryBaseData>();
		[ContainerField(32), ContainerFieldNameHash(383933953)]
		public RefArray<StatsCategoryBaseData> TrackableAwardCol { get { return m_TrackableAwardCol; } set { if (OnPropertyChanging("UIAwardsScreenCompData." + nameof(TrackableAwardCol), this, m_TrackableAwardCol, value)) m_TrackableAwardCol = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 383950411:
					TrackableAwardRow = (RefArray<StatsCategoryBaseData>) p_Value;
					break;

				case 383933953:
					TrackableAwardCol = (RefArray<StatsCategoryBaseData>) p_Value;
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
				case 383950411:
					return TrackableAwardRow;

				case 383933953:
					return TrackableAwardCol;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 383950411:
					return typeof(UIAwardsScreenCompData).GetProperty(nameof(TrackableAwardRow));

				case 383933953:
					return typeof(UIAwardsScreenCompData).GetProperty(nameof(TrackableAwardCol));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
