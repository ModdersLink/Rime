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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class FormationHolder : 
		Asset
	{
		protected RefArray<FormationData> m_Formations = new RefArray<FormationData>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(408468541), ContainerRefArray]
		public RefArray<FormationData> Formations { get { return m_Formations; } set { if (OnPropertyChanging("FormationHolder." + nameof(Formations), this, m_Formations, value)) m_Formations = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 408468541:
					Formations = (RefArray<FormationData>) p_Value;
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
				case 408468541:
					return Formations;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 408468541:
					return typeof(FormationHolder).GetProperty(nameof(Formations));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
