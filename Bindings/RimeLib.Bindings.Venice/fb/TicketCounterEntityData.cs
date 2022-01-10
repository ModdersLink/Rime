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
	[ContainerType(16, 144)]
	public class TicketCounterEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public List<TicketCountPercentage> TicketPercentages { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public int TicketLossPerMin { get; set; }

		[ContainerField(104)]
		public TicketDecreaseType DecreaseTickets { get; set; } = new();

		[ContainerField(108)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public int TicketLossWhenLostAll { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public int TicketLossWhenLostAllControlsPoint { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public int InitialTicketCount { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public int TicketLossStart { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool SetBestSquadSpawner { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable]
		public bool HaltTicketLossOnEqualPointCount { get; set; }

		[ContainerField(130), LayoutImmutable, Blittable]
		public bool ResetCapturePointsOnReset { get; set; }

		[ContainerField(131), LayoutImmutable, Blittable]
		public bool SpawnAlwaysAllowed { get; set; }

		public static void Deserialize(TicketCounterEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TicketPercentages.Clear();
			(RimeReader Reader, uint Count) s_TicketPercentages = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TicketPercentages.Count; ++i)
			{
				var s_Value = new TicketCountPercentage();
				fb.TicketCountPercentage.Deserialize(s_Value, s_TicketPercentages.Reader, p_Parser);
				p_Instance.TicketPercentages.Add(s_Value);
			}
			
			s_TicketPercentages.Reader.Dispose();
			p_Instance.TicketLossPerMin = p_Reader.ReadInt32();
			p_Instance.DecreaseTickets = (TicketDecreaseType) p_Reader.ReadInt32();
			p_Instance.TeamId = (TeamId) p_Reader.ReadInt32();
			p_Instance.TicketLossWhenLostAll = p_Reader.ReadInt32();
			p_Instance.TicketLossWhenLostAllControlsPoint = p_Reader.ReadInt32();
			p_Instance.InitialTicketCount = p_Reader.ReadInt32();
			p_Instance.TicketLossStart = p_Reader.ReadInt32();
			p_Instance.SetBestSquadSpawner = p_Reader.ReadBool();
			p_Instance.HaltTicketLossOnEqualPointCount = p_Reader.ReadBool();
			p_Instance.ResetCapturePointsOnReset = p_Reader.ReadBool();
			p_Instance.SpawnAlwaysAllowed = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
