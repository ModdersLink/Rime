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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class TrackComponentData : 
		MeshComponentData
	{
		protected float m_ScrollFactor = new float();
		[ContainerField(Name: "ScrollFactor", Offset: 112, NameHash: 3975253477, Flags: 49469), LayoutImmutable, Blittable]
		public float ScrollFactor { get { return m_ScrollFactor; } set { if (OnPropertyChanging("TrackComponentData." + nameof(ScrollFactor), this, m_ScrollFactor, value)) m_ScrollFactor = value; } } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3975253477:
					ScrollFactor = (float) p_Value;
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
				case 3975253477:
					return ScrollFactor;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3975253477:
					return typeof(TrackComponentData).GetProperty(nameof(ScrollFactor));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
