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
	[ContainerType(4, 24)]
	public class AIVehicleTypes : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<AIVehicleBehaviourData>> VehicleTypes { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<BehaviourData>> Goals { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<BehaviourData>> Intents { get; set; } = new();

		public static void Deserialize(AIVehicleTypes p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.VehicleTypes.Clear();
			(RimeReader Reader, uint Count) s_VehicleTypes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_VehicleTypes.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AIVehicleBehaviourData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_VehicleTypes.Reader.ReadUInt32()));
				p_Instance.VehicleTypes.Add(s_CtrRef);
			}
			
			s_VehicleTypes.Reader.Dispose();
			p_Instance.Goals.Clear();
			(RimeReader Reader, uint Count) s_Goals = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Goals.Count; ++i)
			{
				var s_CtrRef = new CtrRef<BehaviourData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Goals.Reader.ReadUInt32()));
				p_Instance.Goals.Add(s_CtrRef);
			}
			
			s_Goals.Reader.Dispose();
			p_Instance.Intents.Clear();
			(RimeReader Reader, uint Count) s_Intents = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Intents.Count; ++i)
			{
				var s_CtrRef = new CtrRef<BehaviourData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Intents.Reader.ReadUInt32()));
				p_Instance.Intents.Add(s_CtrRef);
			}
			
			s_Intents.Reader.Dispose();
		}

	}
}
