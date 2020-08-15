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
	public class VeniceUICombatAreaAsset : 
		UICombatAreaAsset
	{
		protected CtrRef<UIDistanceFieldAsset> m_DistanceField = new CtrRef<UIDistanceFieldAsset>();
		[ContainerField(16), ContainerFieldNameHash(750822692)]
		public CtrRef<UIDistanceFieldAsset> DistanceField { get { return m_DistanceField; } set { if (OnPropertyChanging("VeniceUICombatAreaAsset." + nameof(DistanceField), this, m_DistanceField, value)) m_DistanceField = value; } } // 0x10 (16)
		
		protected CtrRef<UIDistanceFieldAsset> m_SurroundingDistanceField = new CtrRef<UIDistanceFieldAsset>();
		[ContainerField(20), ContainerFieldNameHash(1134425682)]
		public CtrRef<UIDistanceFieldAsset> SurroundingDistanceField { get { return m_SurroundingDistanceField; } set { if (OnPropertyChanging("VeniceUICombatAreaAsset." + nameof(SurroundingDistanceField), this, m_SurroundingDistanceField, value)) m_SurroundingDistanceField = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 750822692:
					DistanceField = (CtrRef<UIDistanceFieldAsset>) p_Value;
					break;

				case 1134425682:
					SurroundingDistanceField = (CtrRef<UIDistanceFieldAsset>) p_Value;
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
				case 750822692:
					return DistanceField;

				case 1134425682:
					return SurroundingDistanceField;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 750822692:
					return typeof(VeniceUICombatAreaAsset).GetProperty(nameof(DistanceField));

				case 1134425682:
					return typeof(VeniceUICombatAreaAsset).GetProperty(nameof(SurroundingDistanceField));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
