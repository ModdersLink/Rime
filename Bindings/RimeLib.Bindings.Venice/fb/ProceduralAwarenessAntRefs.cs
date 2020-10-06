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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class ProceduralAwarenessAntRefs : 
		DataContainer
	{
		protected AntRef m_ProceduralAwarenessActive = new AntRef();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(917996519)]
		public AntRef ProceduralAwarenessActive { get { return m_ProceduralAwarenessActive; } set { if (OnPropertyChanging("ProceduralAwarenessAntRefs." + nameof(ProceduralAwarenessActive), this, m_ProceduralAwarenessActive, value)) m_ProceduralAwarenessActive = value; } } // 0x8 (8)
		
		protected AntRef m_ProceduralAwarenessHumanIKActive = new AntRef();
		[ContainerField(12), MemberInfoFlag(41), ContainerFieldNameHash(2022287482)]
		public AntRef ProceduralAwarenessHumanIKActive { get { return m_ProceduralAwarenessHumanIKActive; } set { if (OnPropertyChanging("ProceduralAwarenessAntRefs." + nameof(ProceduralAwarenessHumanIKActive), this, m_ProceduralAwarenessHumanIKActive, value)) m_ProceduralAwarenessHumanIKActive = value; } } // 0xC (12)
		
		protected AntRef m_ProceduralAwarenessData = new AntRef();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(935670043)]
		public AntRef ProceduralAwarenessData { get { return m_ProceduralAwarenessData; } set { if (OnPropertyChanging("ProceduralAwarenessAntRefs." + nameof(ProceduralAwarenessData), this, m_ProceduralAwarenessData, value)) m_ProceduralAwarenessData = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 917996519:
					ProceduralAwarenessActive = (AntRef) p_Value;
					break;

				case 2022287482:
					ProceduralAwarenessHumanIKActive = (AntRef) p_Value;
					break;

				case 935670043:
					ProceduralAwarenessData = (AntRef) p_Value;
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
				case 917996519:
					return ProceduralAwarenessActive;

				case 2022287482:
					return ProceduralAwarenessHumanIKActive;

				case 935670043:
					return ProceduralAwarenessData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 917996519:
					return typeof(ProceduralAwarenessAntRefs).GetProperty(nameof(ProceduralAwarenessActive));

				case 2022287482:
					return typeof(ProceduralAwarenessAntRefs).GetProperty(nameof(ProceduralAwarenessHumanIKActive));

				case 935670043:
					return typeof(ProceduralAwarenessAntRefs).GetProperty(nameof(ProceduralAwarenessData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
