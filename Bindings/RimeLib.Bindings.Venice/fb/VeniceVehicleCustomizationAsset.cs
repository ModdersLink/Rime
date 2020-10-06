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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class VeniceVehicleCustomizationAsset : 
		VehicleCustomizationAsset
	{
		protected VehicleCategory m_Category = new VehicleCategory();
		[ContainerField(16), MemberInfoFlag(137), ContainerFieldNameHash(3455858997)]
		public VehicleCategory Category { get { return m_Category; } set { if (OnPropertyChanging("VeniceVehicleCustomizationAsset." + nameof(Category), this, m_Category, value)) m_Category = value; } } // 0x10 (16)
		
		protected string m_NameSid = string.Empty;
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3153745340)]
		public string NameSid { get { return m_NameSid; } set { if (OnPropertyChanging("VeniceVehicleCustomizationAsset." + nameof(NameSid), this, m_NameSid, value)) m_NameSid = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3455858997:
					Category = (VehicleCategory) Enum.ToObject(typeof(VehicleCategory), p_Value);
					break;

				case 3153745340:
					NameSid = (string) p_Value;
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
				case 3455858997:
					return Category;

				case 3153745340:
					return NameSid;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3455858997:
					return typeof(VeniceVehicleCustomizationAsset).GetProperty(nameof(Category));

				case 3153745340:
					return typeof(VeniceVehicleCustomizationAsset).GetProperty(nameof(NameSid));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
