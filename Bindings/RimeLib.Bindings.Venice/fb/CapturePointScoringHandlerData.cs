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
	public class CapturePointScoringHandlerData : 
		ScoringHandlerData
	{
		protected float m_SquadCappingBonus = new float();
		[ContainerField(Name: "SquadCappingBonus", Offset: 8, NameHash: 3764557584, Flags: 49469), LayoutImmutable, Blittable]
		public float SquadCappingBonus { get { return m_SquadCappingBonus; } set { if (OnPropertyChanging("CapturePointScoringHandlerData." + nameof(SquadCappingBonus), this, m_SquadCappingBonus, value)) m_SquadCappingBonus = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3764557584:
					SquadCappingBonus = (float) p_Value;
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
				case 3764557584:
					return SquadCappingBonus;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3764557584:
					return typeof(CapturePointScoringHandlerData).GetProperty(nameof(SquadCappingBonus));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
