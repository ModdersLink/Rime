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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class MultipleActorScenarioEntityData : 
		SpatialEntityData
	{
		protected LinearTransform m_WorldSpaceConnectTransform = new LinearTransform();
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1100259089)]
		public LinearTransform WorldSpaceConnectTransform { get { return m_WorldSpaceConnectTransform; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(WorldSpaceConnectTransform), this, m_WorldSpaceConnectTransform, value)) m_WorldSpaceConnectTransform = value; } } // 0x50 (80)
		
		protected int m_Actor5Part = new int();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4063426348)]
		public int Actor5Part { get { return m_Actor5Part; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor5Part), this, m_Actor5Part, value)) m_Actor5Part = value; } } // 0x90 (144)
		
		protected AntRef m_ScenarioAntRef = new AntRef();
		[ContainerField(148), MemberInfoFlag(41), ContainerFieldNameHash(3249359201)]
		public AntRef ScenarioAntRef { get { return m_ScenarioAntRef; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(ScenarioAntRef), this, m_ScenarioAntRef, value)) m_ScenarioAntRef = value; } } // 0x94 (148)
		
		protected int m_LevelChoice = new int();
		[ContainerField(152), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1514666168)]
		public int LevelChoice { get { return m_LevelChoice; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(LevelChoice), this, m_LevelChoice, value)) m_LevelChoice = value; } } // 0x98 (152)
		
		protected int m_ScenarioChoice = new int();
		[ContainerField(156), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3315992608)]
		public int ScenarioChoice { get { return m_ScenarioChoice; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(ScenarioChoice), this, m_ScenarioChoice, value)) m_ScenarioChoice = value; } } // 0x9C (156)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(160), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xA0 (160)
		
		protected int m_Actor6Part = new int();
		[ContainerField(164), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4064329455)]
		public int Actor6Part { get { return m_Actor6Part; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor6Part), this, m_Actor6Part, value)) m_Actor6Part = value; } } // 0xA4 (164)
		
		protected int m_Actor1 = new int();
		[ContainerField(168), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2484184607)]
		public int Actor1 { get { return m_Actor1; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor1), this, m_Actor1, value)) m_Actor1 = value; } } // 0xA8 (168)
		
		protected int m_Actor1Part = new int();
		[ContainerField(172), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4068170024)]
		public int Actor1Part { get { return m_Actor1Part; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor1Part), this, m_Actor1Part, value)) m_Actor1Part = value; } } // 0xAC (172)
		
		protected int m_Actor1SecondPart = new int();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3245706712)]
		public int Actor1SecondPart { get { return m_Actor1SecondPart; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor1SecondPart), this, m_Actor1SecondPart, value)) m_Actor1SecondPart = value; } } // 0xB0 (176)
		
		protected int m_Actor2 = new int();
		[ContainerField(180), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2484184604)]
		public int Actor2 { get { return m_Actor2; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor2), this, m_Actor2, value)) m_Actor2 = value; } } // 0xB4 (180)
		
		protected int m_Actor2Part = new int();
		[ContainerField(184), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4069073131)]
		public int Actor2Part { get { return m_Actor2Part; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor2Part), this, m_Actor2Part, value)) m_Actor2Part = value; } } // 0xB8 (184)
		
		protected int m_Actor2SecondPart = new int();
		[ContainerField(188), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1494016859)]
		public int Actor2SecondPart { get { return m_Actor2SecondPart; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor2SecondPart), this, m_Actor2SecondPart, value)) m_Actor2SecondPart = value; } } // 0xBC (188)
		
		protected int m_Actor3 = new int();
		[ContainerField(192), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2484184605)]
		public int Actor3 { get { return m_Actor3; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor3), this, m_Actor3, value)) m_Actor3 = value; } } // 0xC0 (192)
		
		protected int m_Actor3Part = new int();
		[ContainerField(196), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4070394026)]
		public int Actor3Part { get { return m_Actor3Part; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor3Part), this, m_Actor3Part, value)) m_Actor3Part = value; } } // 0xC4 (196)
		
		protected int m_Actor3SecondPart = new int();
		[ContainerField(200), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2441148378)]
		public int Actor3SecondPart { get { return m_Actor3SecondPart; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor3SecondPart), this, m_Actor3SecondPart, value)) m_Actor3SecondPart = value; } } // 0xC8 (200)
		
		protected int m_Actor4 = new int();
		[ContainerField(204), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2484184602)]
		public int Actor4 { get { return m_Actor4; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor4), this, m_Actor4, value)) m_Actor4 = value; } } // 0xCC (204)
		
		protected int m_Actor4Part = new int();
		[ContainerField(208), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4062105453)]
		public int Actor4Part { get { return m_Actor4Part; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor4Part), this, m_Actor4Part, value)) m_Actor4Part = value; } } // 0xD0 (208)
		
		protected int m_Actor4SecondPart = new int();
		[ContainerField(212), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3250112349)]
		public int Actor4SecondPart { get { return m_Actor4SecondPart; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor4SecondPart), this, m_Actor4SecondPart, value)) m_Actor4SecondPart = value; } } // 0xD4 (212)
		
		protected int m_Actor5 = new int();
		[ContainerField(216), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2484184603)]
		public int Actor5 { get { return m_Actor5; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor5), this, m_Actor5, value)) m_Actor5 = value; } } // 0xD8 (216)
		
		protected int m_Actor5SecondPart = new int();
		[ContainerField(220), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4197243868)]
		public int Actor5SecondPart { get { return m_Actor5SecondPart; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor5SecondPart), this, m_Actor5SecondPart, value)) m_Actor5SecondPart = value; } } // 0xDC (220)
		
		protected int m_Actor6SecondPart = new int();
		[ContainerField(224), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2445554015)]
		public int Actor6SecondPart { get { return m_Actor6SecondPart; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor6SecondPart), this, m_Actor6SecondPart, value)) m_Actor6SecondPart = value; } } // 0xE0 (224)
		
		protected int m_Actor6 = new int();
		[ContainerField(228), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2484184600)]
		public int Actor6 { get { return m_Actor6; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor6), this, m_Actor6, value)) m_Actor6 = value; } } // 0xE4 (228)
		
		protected float m_ExternalTime = new float();
		[ContainerField(232), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2162678253)]
		public float ExternalTime { get { return m_ExternalTime; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(ExternalTime), this, m_ExternalTime, value)) m_ExternalTime = value; } } // 0xE8 (232)
		
		protected bool m_AligningEnabled = new bool();
		[ContainerField(236), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1454127501)]
		public bool AligningEnabled { get { return m_AligningEnabled; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(AligningEnabled), this, m_AligningEnabled, value)) m_AligningEnabled = value; } } // 0xEC (236)
		
		protected bool m_ScenarioActive = new bool();
		[ContainerField(237), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3253317991)]
		public bool ScenarioActive { get { return m_ScenarioActive; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(ScenarioActive), this, m_ScenarioActive, value)) m_ScenarioActive = value; } } // 0xED (237)
		
		protected bool m_Actor1Prepared = new bool();
		[ContainerField(238), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3975066650)]
		public bool Actor1Prepared { get { return m_Actor1Prepared; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor1Prepared), this, m_Actor1Prepared, value)) m_Actor1Prepared = value; } } // 0xEE (238)
		
		protected bool m_Actor2Prepared = new bool();
		[ContainerField(239), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2878190105)]
		public bool Actor2Prepared { get { return m_Actor2Prepared; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor2Prepared), this, m_Actor2Prepared, value)) m_Actor2Prepared = value; } } // 0xEF (239)
		
		protected bool m_Actor3Prepared = new bool();
		[ContainerField(240), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(770618392)]
		public bool Actor3Prepared { get { return m_Actor3Prepared; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor3Prepared), this, m_Actor3Prepared, value)) m_Actor3Prepared = value; } } // 0xF0 (240)
		
		protected bool m_Actor4Prepared = new bool();
		[ContainerField(241), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2873438751)]
		public bool Actor4Prepared { get { return m_Actor4Prepared; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor4Prepared), this, m_Actor4Prepared, value)) m_Actor4Prepared = value; } } // 0xF1 (241)
		
		protected bool m_Actor5Prepared = new bool();
		[ContainerField(242), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(765867038)]
		public bool Actor5Prepared { get { return m_Actor5Prepared; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor5Prepared), this, m_Actor5Prepared, value)) m_Actor5Prepared = value; } } // 0xF2 (242)
		
		protected bool m_Actor6Prepared = new bool();
		[ContainerField(243), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3963957789)]
		public bool Actor6Prepared { get { return m_Actor6Prepared; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(Actor6Prepared), this, m_Actor6Prepared, value)) m_Actor6Prepared = value; } } // 0xF3 (243)
		
		protected bool m_CheckActor1Finished = new bool();
		[ContainerField(244), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2061362539)]
		public bool CheckActor1Finished { get { return m_CheckActor1Finished; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(CheckActor1Finished), this, m_CheckActor1Finished, value)) m_CheckActor1Finished = value; } } // 0xF4 (244)
		
		protected bool m_CheckActor2Finished = new bool();
		[ContainerField(245), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4180155688)]
		public bool CheckActor2Finished { get { return m_CheckActor2Finished; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(CheckActor2Finished), this, m_CheckActor2Finished, value)) m_CheckActor2Finished = value; } } // 0xF5 (245)
		
		protected bool m_CheckActor3Finished = new bool();
		[ContainerField(246), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2998814185)]
		public bool CheckActor3Finished { get { return m_CheckActor3Finished; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(CheckActor3Finished), this, m_CheckActor3Finished, value)) m_CheckActor3Finished = value; } } // 0xF6 (246)
		
		protected bool m_CheckActor4Finished = new bool();
		[ContainerField(247), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1137974702)]
		public bool CheckActor4Finished { get { return m_CheckActor4Finished; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(CheckActor4Finished), this, m_CheckActor4Finished, value)) m_CheckActor4Finished = value; } } // 0xF7 (247)
		
		protected bool m_CheckActor5Finished = new bool();
		[ContainerField(248), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4251600495)]
		public bool CheckActor5Finished { get { return m_CheckActor5Finished; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(CheckActor5Finished), this, m_CheckActor5Finished, value)) m_CheckActor5Finished = value; } } // 0xF8 (248)
		
		protected bool m_CheckActor6Finished = new bool();
		[ContainerField(249), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2075426348)]
		public bool CheckActor6Finished { get { return m_CheckActor6Finished; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(CheckActor6Finished), this, m_CheckActor6Finished, value)) m_CheckActor6Finished = value; } } // 0xF9 (249)
		
		protected bool m_UseInputEventPlayerAsPlayer1 = new bool();
		[ContainerField(250), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2839224479)]
		public bool UseInputEventPlayerAsPlayer1 { get { return m_UseInputEventPlayerAsPlayer1; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(UseInputEventPlayerAsPlayer1), this, m_UseInputEventPlayerAsPlayer1, value)) m_UseInputEventPlayerAsPlayer1 = value; } } // 0xFA (250)
		
		protected bool m_UseExternalTime = new bool();
		[ContainerField(251), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2902061742)]
		public bool UseExternalTime { get { return m_UseExternalTime; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(UseExternalTime), this, m_UseExternalTime, value)) m_UseExternalTime = value; } } // 0xFB (251)
		
		protected bool m_WorldSpace = new bool();
		[ContainerField(252), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(632957315)]
		public bool WorldSpace { get { return m_WorldSpace; } set { if (OnPropertyChanging("MultipleActorScenarioEntityData." + nameof(WorldSpace), this, m_WorldSpace, value)) m_WorldSpace = value; } } // 0xFC (252)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1100259089:
					WorldSpaceConnectTransform = (LinearTransform) p_Value;
					break;

				case 4063426348:
					Actor5Part = (int) p_Value;
					break;

				case 3249359201:
					ScenarioAntRef = (AntRef) p_Value;
					break;

				case 1514666168:
					LevelChoice = (int) p_Value;
					break;

				case 3315992608:
					ScenarioChoice = (int) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 4064329455:
					Actor6Part = (int) p_Value;
					break;

				case 2484184607:
					Actor1 = (int) p_Value;
					break;

				case 4068170024:
					Actor1Part = (int) p_Value;
					break;

				case 3245706712:
					Actor1SecondPart = (int) p_Value;
					break;

				case 2484184604:
					Actor2 = (int) p_Value;
					break;

				case 4069073131:
					Actor2Part = (int) p_Value;
					break;

				case 1494016859:
					Actor2SecondPart = (int) p_Value;
					break;

				case 2484184605:
					Actor3 = (int) p_Value;
					break;

				case 4070394026:
					Actor3Part = (int) p_Value;
					break;

				case 2441148378:
					Actor3SecondPart = (int) p_Value;
					break;

				case 2484184602:
					Actor4 = (int) p_Value;
					break;

				case 4062105453:
					Actor4Part = (int) p_Value;
					break;

				case 3250112349:
					Actor4SecondPart = (int) p_Value;
					break;

				case 2484184603:
					Actor5 = (int) p_Value;
					break;

				case 4197243868:
					Actor5SecondPart = (int) p_Value;
					break;

				case 2445554015:
					Actor6SecondPart = (int) p_Value;
					break;

				case 2484184600:
					Actor6 = (int) p_Value;
					break;

				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 1454127501:
					AligningEnabled = (bool) p_Value;
					break;

				case 3253317991:
					ScenarioActive = (bool) p_Value;
					break;

				case 3975066650:
					Actor1Prepared = (bool) p_Value;
					break;

				case 2878190105:
					Actor2Prepared = (bool) p_Value;
					break;

				case 770618392:
					Actor3Prepared = (bool) p_Value;
					break;

				case 2873438751:
					Actor4Prepared = (bool) p_Value;
					break;

				case 765867038:
					Actor5Prepared = (bool) p_Value;
					break;

				case 3963957789:
					Actor6Prepared = (bool) p_Value;
					break;

				case 2061362539:
					CheckActor1Finished = (bool) p_Value;
					break;

				case 4180155688:
					CheckActor2Finished = (bool) p_Value;
					break;

				case 2998814185:
					CheckActor3Finished = (bool) p_Value;
					break;

				case 1137974702:
					CheckActor4Finished = (bool) p_Value;
					break;

				case 4251600495:
					CheckActor5Finished = (bool) p_Value;
					break;

				case 2075426348:
					CheckActor6Finished = (bool) p_Value;
					break;

				case 2839224479:
					UseInputEventPlayerAsPlayer1 = (bool) p_Value;
					break;

				case 2902061742:
					UseExternalTime = (bool) p_Value;
					break;

				case 632957315:
					WorldSpace = (bool) p_Value;
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
				case 1100259089:
					return WorldSpaceConnectTransform;

				case 4063426348:
					return Actor5Part;

				case 3249359201:
					return ScenarioAntRef;

				case 1514666168:
					return LevelChoice;

				case 3315992608:
					return ScenarioChoice;

				case 229961746:
					return Realm;

				case 4064329455:
					return Actor6Part;

				case 2484184607:
					return Actor1;

				case 4068170024:
					return Actor1Part;

				case 3245706712:
					return Actor1SecondPart;

				case 2484184604:
					return Actor2;

				case 4069073131:
					return Actor2Part;

				case 1494016859:
					return Actor2SecondPart;

				case 2484184605:
					return Actor3;

				case 4070394026:
					return Actor3Part;

				case 2441148378:
					return Actor3SecondPart;

				case 2484184602:
					return Actor4;

				case 4062105453:
					return Actor4Part;

				case 3250112349:
					return Actor4SecondPart;

				case 2484184603:
					return Actor5;

				case 4197243868:
					return Actor5SecondPart;

				case 2445554015:
					return Actor6SecondPart;

				case 2484184600:
					return Actor6;

				case 2162678253:
					return ExternalTime;

				case 1454127501:
					return AligningEnabled;

				case 3253317991:
					return ScenarioActive;

				case 3975066650:
					return Actor1Prepared;

				case 2878190105:
					return Actor2Prepared;

				case 770618392:
					return Actor3Prepared;

				case 2873438751:
					return Actor4Prepared;

				case 765867038:
					return Actor5Prepared;

				case 3963957789:
					return Actor6Prepared;

				case 2061362539:
					return CheckActor1Finished;

				case 4180155688:
					return CheckActor2Finished;

				case 2998814185:
					return CheckActor3Finished;

				case 1137974702:
					return CheckActor4Finished;

				case 4251600495:
					return CheckActor5Finished;

				case 2075426348:
					return CheckActor6Finished;

				case 2839224479:
					return UseInputEventPlayerAsPlayer1;

				case 2902061742:
					return UseExternalTime;

				case 632957315:
					return WorldSpace;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1100259089:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(WorldSpaceConnectTransform));

				case 4063426348:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor5Part));

				case 3249359201:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(ScenarioAntRef));

				case 1514666168:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(LevelChoice));

				case 3315992608:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(ScenarioChoice));

				case 229961746:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Realm));

				case 4064329455:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor6Part));

				case 2484184607:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor1));

				case 4068170024:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor1Part));

				case 3245706712:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor1SecondPart));

				case 2484184604:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor2));

				case 4069073131:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor2Part));

				case 1494016859:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor2SecondPart));

				case 2484184605:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor3));

				case 4070394026:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor3Part));

				case 2441148378:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor3SecondPart));

				case 2484184602:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor4));

				case 4062105453:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor4Part));

				case 3250112349:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor4SecondPart));

				case 2484184603:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor5));

				case 4197243868:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor5SecondPart));

				case 2445554015:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor6SecondPart));

				case 2484184600:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor6));

				case 2162678253:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(ExternalTime));

				case 1454127501:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(AligningEnabled));

				case 3253317991:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(ScenarioActive));

				case 3975066650:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor1Prepared));

				case 2878190105:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor2Prepared));

				case 770618392:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor3Prepared));

				case 2873438751:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor4Prepared));

				case 765867038:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor5Prepared));

				case 3963957789:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(Actor6Prepared));

				case 2061362539:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(CheckActor1Finished));

				case 4180155688:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(CheckActor2Finished));

				case 2998814185:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(CheckActor3Finished));

				case 1137974702:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(CheckActor4Finished));

				case 4251600495:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(CheckActor5Finished));

				case 2075426348:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(CheckActor6Finished));

				case 2839224479:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(UseInputEventPlayerAsPlayer1));

				case 2902061742:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(UseExternalTime));

				case 632957315:
					return typeof(MultipleActorScenarioEntityData).GetProperty(nameof(WorldSpace));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
