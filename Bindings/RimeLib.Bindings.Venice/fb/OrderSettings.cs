///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 16)]
	public class OrderSettings : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<OrderReadiness>> Orders { get; set; } = new();

		public static void Deserialize(OrderSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Orders.Clear();
			(RimeReader Reader, uint Count) s_Orders = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Orders.Count; ++i)
			{
				var s_CtrRef = new CtrRef<OrderReadiness>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Orders.Reader.ReadUInt32()));
				p_Instance.Orders.Add(s_CtrRef);
			}
			
			s_Orders.Reader.Dispose();
		}

	}
}
