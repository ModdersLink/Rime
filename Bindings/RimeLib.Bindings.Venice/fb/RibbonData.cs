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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 48)]
	public class RibbonData : 
		VisualVectorShapeData
	{
		protected List<RibbonPointData> m_RibbonPoints = new List<RibbonPointData>();
		[ContainerField(Name: "RibbonPoints", Offset: 44, NameHash: 935977920, Flags: 65)]
		public List<RibbonPointData> RibbonPoints { get { return m_RibbonPoints; } set { if (OnPropertyChanging("RibbonData." + nameof(RibbonPoints), this, m_RibbonPoints, value)) m_RibbonPoints = value; } } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 935977920:
					RibbonPoints = (List<RibbonPointData>) p_Value;
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
				case 935977920:
					return RibbonPoints;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 935977920:
					return typeof(RibbonData).GetProperty(nameof(RibbonPoints));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
