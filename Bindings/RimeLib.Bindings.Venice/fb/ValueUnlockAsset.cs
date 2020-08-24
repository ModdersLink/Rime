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
	public class ValueUnlockAsset : 
		UnlockAssetBase
	{
		protected RefArray<UnlockValuePair> m_UnlockValues = new RefArray<UnlockValuePair>();
		[ContainerField(40), MemberInfoFlag(65), ContainerFieldNameHash(2757489261), ContainerRefArray]
		public RefArray<UnlockValuePair> UnlockValues { get { return m_UnlockValues; } set { if (OnPropertyChanging("ValueUnlockAsset." + nameof(UnlockValues), this, m_UnlockValues, value)) m_UnlockValues = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2757489261:
					UnlockValues = (RefArray<UnlockValuePair>) p_Value;
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
				case 2757489261:
					return UnlockValues;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2757489261:
					return typeof(ValueUnlockAsset).GetProperty(nameof(UnlockValues));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
