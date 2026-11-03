using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using RimeLib.Havok.Frostbite2_0.Frostbite;
using RimeLib.Havok.Frostbite2_0.Packfile;
using ShapeReader2012 = RimeLib.Havok.Frostbite2013_2.Frostbite.ShapeReader;

namespace RimeLib.Havok.Frostbite2013_2.Packfile;

/// <summary>
/// A BF4 destruction resource's packfile as BF3's are: the breakable bodies, shapes, fractures and
/// actions class by class, and their physics built again from the shapes' leaves in BF3's layout,
/// one MOPP over every piece that the compound shape, its rigid body and the physics container
/// share, a list of its pieces per child, and the map from the MOPP's keys to the children. What
/// BF3's classes have no room for is counted in <see cref="Dropped"/>.
/// </summary>
public sealed class DestructionConversion
{
    /// <summary>
    /// Keys, of properties and of flags alike, that BF4 numbers one past BF3: a breakable body's type
    /// among its flags and its decoration data among its properties.
    /// </summary>
    private static readonly Dictionary<int, int> s_PropertyKeys = new()
    {
        [unchecked((int)0xF0010007)] = unchecked((int)0xF0010006),
        [unchecked((int)0xF0010009)] = unchecked((int)0xF0010008),
    };

    /// <summary>The key of a breakable body's shape key to child map, which BF4 does not have.</summary>
    private const int c_ShapeKeyToChildMapKey = unchecked((int)0xF0001015);

    private const int c_RigidBodyMotionTypeOffset = 232;

    private readonly HavokPhysicsData m_Source;
    private readonly ShapeReader2012 m_Shapes = new();
    private readonly Dictionary<HkObject, HkObject> m_Converted = new(ReferenceEqualityComparer.Instance);
    private readonly Dictionary<HkdCompoundBreakableShape2012, (HkpMoppBvTreeShape Whole, List<List<uint>> Keys)> m_Physics =
        new(ReferenceEqualityComparer.Instance);

    public SortedDictionary<string, int> Dropped { get; } = new(StringComparer.Ordinal);

    private DestructionConversion(HavokPhysicsData p_Source) => m_Source = p_Source;

    /// <summary>The resource's 32-bit packfile as Havok 2010 objects in BF3's layout.</summary>
    public static HkRootLevelContainer Convert(HavokPhysicsData p_Source, out SortedDictionary<string, int> p_Dropped)
    {
        var s_Conversion = new DestructionConversion(p_Source);
        var s_Root = s_Conversion.Root(HkPackfile.Read(p_Source.HavokInstance32, HkClasses2012.Create));
        p_Dropped = s_Conversion.Dropped;
        return s_Root;
    }

    private HkRootLevelContainer Root(HkRootLevelContainer p_Source)
    {
        var s_Variants = p_Source.NamedVariants.Select(p_V => p_V.Variant is HkMemoryResourceContainer s_Container
            ? p_V with { Variant = Container(s_Container) }
            : p_V).ToList();

        // The physics container holds the first body's shape, which it shares with the body, then
        // what of the source's container is not breakable, a door's frame say, built from its leaves.
        var s_Whole = m_Physics.Values.Select(p_P => p_P.Whole).FirstOrDefault()
            ?? throw new NotSupportedException("A destruction resource with no breakable body.");
        var s_Container = new HavokPhysicsContainer { Shapes = [s_Whole] };
        foreach (var s_Root in m_Source.GetShapes(m_Shapes).Where(p_L => p_L.Root > 0).GroupBy(p_L => p_L.Root).OrderBy(p_G => p_G.Key))
            s_Container.Shapes.Add(HkPhysicsBuilder.BuildRoot([.. s_Root]));
        return new HkRootLevelContainer
        {
            NamedVariants = s_Variants.Select(p_V => p_V.ClassName == "HavokPhysicsContainer" ? p_V with { Variant = s_Container } : p_V).ToList(),
        };
    }

    private HkMemoryResourceContainer Container(HkMemoryResourceContainer p_Source) => new()
    {
        Name = p_Source.Name,
        ResourceHandles = p_Source.ResourceHandles.Select(p_H => new HkMemoryResourceHandle
        {
            Name = p_H.Name,
            References = p_H.References,
            Variant = Convert(p_H.Variant),
        }).ToList(),
        Children = p_Source.Children.Select(Container).ToList(),
    };

    /// <summary>The Havok 2010 object of a Havok 2012 one, converted once however often it is referenced.</summary>
    private HkObject? Convert(HkObject? p_Source)
    {
        if (p_Source == null)
            return null;
        if (m_Converted.TryGetValue(p_Source, out var s_Known))
            return s_Known;

        HkObject? s_Target = p_Source switch
        {
            // Classes the two versions share are read as Havok 2010's already; flags take BF3's keys.
            HavokGraphicsShape or HkdStringObject => p_Source,
            HkdPropertyFlagSet s_Flags => new HkdPropertyFlagSet
            {
                Properties = s_Flags.Properties.Select(p_P => p_P with { Key = (uint)s_PropertyKeys.GetValueOrDefault((int)p_P.Key, (int)p_P.Key) }).ToList(),
            },
            HkdBreakableBody2012 s_Body => Body(s_Body),
            HkdBreakableShape2012 s_Shape => Shape(s_Shape),
            HkdBuildingController2012 s_Controller => new HkdBuildingController
            {
                Type = s_Controller.Type,
                InsideDecisionFunctor = Unconverted(s_Controller.InsideDecisionFunctor),
                ListenersCapacity = s_Controller.ListenersCapacity,
            },
            HkdBreakableShapeActionList2012 s_List => ActionList(s_List),
            HkdBreakableShapeConnectionList2012 s_List => ConnectionList(s_List),
            HkdDebrisFracture2012 s_Fracture => Fracture(s_Fracture),
            HkdExplosionForceAction2012 s_Action => new HkdExplosionForceAction
            {
                InheritanceType = s_Action.InheritanceType,
                ExecutionType = s_Action.ExecutionType,
                Padding = s_Action.Padding,
                ExplosionCenter = s_Action.ExplosionCenter,
                ExplosionCenterSpace = s_Action.ExplosionCenterSpace,
                Velocity = s_Action.Velocity,
                ExpandingVelocity = s_Action.ExpandingVelocity,
                VirtMass = s_Action.VirtMass,
                AngularImpulseFactor = s_Action.AngularImpulseFactor,
            },
            HkdDecorateFractureFaceAction2012 s_Action => DecorateAction(s_Action),
            HkdDecorateFractureFaceActionShapeDecorationInfo2012 s_Info => DecorationInfo(s_Info),
            HkdDecorateFractureFaceActionGlobalDecorationData2012 s_Data => DecorationData(s_Data),
            _ => Unconverted(p_Source),
        };

        if (s_Target != null)
            m_Converted[p_Source] = s_Target;
        return s_Target;
    }

    private T? Convert<T>(HkObject? p_Source) where T : HkObject => (T?)Convert(p_Source);

    /// <summary>Nothing, counted: a class BF3's model does not convert.</summary>
    private HkObject? Unconverted(HkObject? p_Source)
    {
        if (p_Source != null)
            ConversionCount(p_Source.ClassName);
        return null;
    }

    private void ConversionCount(string p_What) => Dropped[p_What] = Dropped.GetValueOrDefault(p_What) + 1;

    private HkdBreakableBody Body(HkdBreakableBody2012 p_Source)
    {
        var s_Body = new HkdBreakableBody();
        m_Converted[p_Source] = s_Body;

        var s_Compound = p_Source.BreakableShape as HkdCompoundBreakableShape2012
            ?? throw new NotSupportedException("A breakable body whose shape is not a compound.");
        var s_Shape = Convert<HkdBreakableShape>(s_Compound)!;
        var (s_Whole, s_Keys) = m_Physics[s_Compound];

        s_Body.BodyTypeAndFlags = p_Source.BodyTypeAndFlags;
        s_Body.ConstraintStrength = p_Source.ConstraintStrength;
        s_Body.BreakableShape = s_Shape;
        s_Body.Controller = Convert<HkdController>(p_Source.Controller);
        s_Body.GraphicsBody = Unconverted(p_Source.GraphicsBody);
        s_Body.ListenersCapacity = p_Source.ListenersCapacity;
        s_Body.FixedConnectivity = Unconverted(p_Source.FixedConnectivity);
        s_Body.DecorationsCapacity = p_Source.DecorationsCapacity;

        var s_Bounds = HkShapeBounds.Of(s_Whole)!.Value;
        s_Body.PhysicsBody = HkpRigidBody.ForBreakableBody(s_Whole, ((s_Bounds.Max - s_Bounds.Min) / 2).Length(), MotionType(p_Source.PhysicsBody));

        // BF3 maps each of the MOPP's keys to the child it is a piece of, where BF4 needs no map.
        s_Body.ObjectProperties = Properties(p_Source.ObjectProperties);
        s_Body.ObjectProperties.Insert(System.Math.Min(1, s_Body.ObjectProperties.Count), new HkdProperty(c_ShapeKeyToChildMapKey, new HkdBreakableBodyShapeKeyToChildMap
        {
            ShapeKeyToChildren = s_Shape.Children.Select((p_C, p_I) => new HkdBreakableBodyShapeKeyToChildMap.ShapeKeyToChild(s_Keys[p_I], p_C.Shape)).ToList(),
        }));
        return s_Body;
    }

    /// <summary>The motion type BF4's rigid body has, by offset as its class is left unread.</summary>
    private byte MotionType(HkObject? p_RigidBody)
    {
        if (p_RigidBody is not HkUnreadObject { Offset: var s_Offset })
            throw new NotSupportedException("A breakable body without a rigid body.");

        var s_Instance = m_Source.HavokInstance32;
        return s_Instance.ObjectData[s_Offset + c_RigidBodyMotionTypeOffset];
    }

    private HkdBreakableShape Shape(HkdBreakableShape2012 p_Source)
    {
        HkdBreakableShape s_Shape = p_Source is HkdCompoundBreakableShape2012 ? new HkdCompoundBreakableShape() : new HkdBreakableShape();
        m_Converted[p_Source] = s_Shape;

        s_Shape.TypeAndFlags = p_Source.TypeAndFlags;
        s_Shape.ConnectivityType = p_Source.ConnectivityType;
        s_Shape.FlexibleJointType = p_Source.FlexibleJointType;
        s_Shape.QualityType = p_Source.QualityType;
        s_Shape.Parent = Convert<HkdBreakableShape>(p_Source.Parent);
        s_Shape.ComAndMass = p_Source.ComAndMass;
        s_Shape.InertiaAndValues = p_Source.InertiaAndValues;
        s_Shape.MajorAxisSpace = p_Source.MajorAxisSpace;
        s_Shape.Geometry = Unconverted(p_Source.Geometry);
        s_Shape.GraphicsShape = Convert(p_Source.GraphicsShape);
        s_Shape.Strength = (p_Source.Material as HkpSimpleBreakableMaterial)?.Strength ?? 0;
        s_Shape.UserData = p_Source.UserData;
        s_Shape.Children = p_Source.Children.Select(p_C => new HkdShapeInstance(p_C.Rotation, p_C.Translation, Convert<HkdBreakableShape>(p_C.Shape),
            p_C.Damage, p_C.Flags, p_C.TempControllerData, p_C.DistanceToDestructionPoint, p_C.ForceFixed, p_C.ParentUid)).ToList();
        s_Shape.ObjectProperties = Properties(p_Source.ObjectProperties);

        // A shape outside a compound, a debris template say, has physics of its own; a compound's
        // children are given theirs from the compound's pieces below.
        if (p_Source.PhysicsShape is HkUnreadObject { Offset: var s_Own } && p_Source is not HkdCompoundBreakableShape2012)
            s_Shape.PhysicsShape = HkPhysicsBuilder.BuildBreakable([(m_Source.GetShapesUnder(m_Shapes, s_Own), hkpPlacement.Identity)]).Children[0];

        if (p_Source is HkdCompoundBreakableShape2012 s_Compound)
        {
            var s_Target = (HkdCompoundBreakableShape)s_Shape;
            s_Target.RootBreakableShape = Convert<HkdBreakableShape>(s_Compound.RootBreakableShape);
            s_Target.UseChildrenBreakableThreshold = s_Compound.UseChildrenBreakableThreshold;
            s_Target.UnusedPaddingCompound = s_Compound.UnusedPaddingCompound;
            Physics(s_Compound, s_Target);
        }

        return s_Shape;
    }

    /// <summary>The compound's and its children's physics, from each child's leaves.</summary>
    private void Physics(HkdCompoundBreakableShape2012 p_Source, HkdCompoundBreakableShape p_Target)
    {
        var s_Leaves = new List<(IReadOnlyList<hkpCollisionShape>, hkpPlacement)>();
        foreach (var s_Child in p_Source.Children)
        {
            if (s_Child.Shape?.PhysicsShape is not HkUnreadObject { Offset: var s_Offset })
                throw new NotSupportedException("A breakable child without physics.");

            var s_Rotation = new Quaternion(s_Child.Rotation.X, s_Child.Rotation.Y, s_Child.Rotation.Z, s_Child.Rotation.W);
            var s_Translation = new Vector3(s_Child.Translation.X, s_Child.Translation.Y, s_Child.Translation.Z);
            s_Leaves.Add((m_Source.GetShapesUnder(m_Shapes, s_Offset), hkpPlacement.FromQsTransform(s_Translation, s_Rotation, Vector3.One)));
        }

        var (s_Whole, s_Children, s_Keys) = HkPhysicsBuilder.BuildBreakable(s_Leaves);
        p_Target.PhysicsShape = s_Whole;
        for (var i = 0; i < s_Children.Count; ++i)
            p_Target.Children[i].Shape!.PhysicsShape = s_Children[i];
        m_Physics[p_Source] = (s_Whole, s_Keys);
    }

    private List<HkdProperty> Properties(IEnumerable<HkdProperty> p_Source)
    {
        var s_Properties = new List<HkdProperty>();
        foreach (var s_Property in p_Source)
        {
            if (Convert(s_Property.Object) is { } s_Object)
                s_Properties.Add(new HkdProperty(s_PropertyKeys.GetValueOrDefault(s_Property.Key, s_Property.Key), s_Object));
        }

        return s_Properties;
    }

    private HkdBreakableShapeActionList ActionList(HkdBreakableShapeActionList2012 p_Source)
    {
        var s_List = new HkdBreakableShapeActionList();
        m_Converted[p_Source] = s_List;
        s_List.Actions = p_Source.Actions.Select(Convert<HkdAction>).OfType<HkdAction>().ToList();
        return s_List;
    }

    private HkdBreakableShapeConnectionList ConnectionList(HkdBreakableShapeConnectionList2012 p_Source)
    {
        var s_List = new HkdBreakableShapeConnectionList();
        m_Converted[p_Source] = s_List;
        s_List.Connections = p_Source.Connections.Select(p_C => new HkdBreakableShapeConnectionList.Connection(p_C.PivotA, p_C.PivotB,
            p_C.SeparatingNormal, p_C.ContactArea, Convert<HkdBreakableShape>(p_C.A), Convert<HkdBreakableShape>(p_C.B))).ToList();
        return s_List;
    }

    private HkdDebrisFracture Fracture(HkdDebrisFracture2012 p_Source)
    {
        var s_Fracture = new HkdDebrisFracture();
        m_Converted[p_Source] = s_Fracture;
        if (p_Source.ControlShapes != null)
            ConversionCount("hkdDebrisFracture.m_controlShapes");

        s_Fracture.RootToLeafRatio = p_Source.RootToLeafRatio;
        s_Fracture.MinimumSize = p_Source.MinimumSize;
        s_Fracture.MaxDistanceForConnection = p_Source.MaxDistanceForConnection;
        s_Fracture.Type = p_Source.Type;
        s_Fracture.RefitPhysicsShapes = p_Source.RefitPhysicsShapes;
        s_Fracture.FlattenHierarchy = p_Source.FlattenHierarchy;
        s_Fracture.ChildFracture = Convert<HkdFracture>(p_Source.ChildFracture);
        s_Fracture.TemplateDebris = Convert<HkdBreakableShape>(p_Source.TemplateDebris);
        s_Fracture.InsertType = p_Source.InsertType;
        s_Fracture.Gap = p_Source.Gap;
        s_Fracture.Density = p_Source.Density;
        s_Fracture.MaxNumPieces = p_Source.MaxNumPieces;
        return s_Fracture;
    }

    private HkdDecorateFractureFaceAction DecorateAction(HkdDecorateFractureFaceAction2012 p_Source)
    {
        var s_Action = new HkdDecorateFractureFaceAction();
        m_Converted[p_Source] = s_Action;

        HkdFractureFaceInfo Face(HkdFractureFaceInfo2012 p_Face) => new(Convert<HkdBreakableShape>(p_Face.Decorations), p_Face.Density, p_Face.Gap,
            p_Face.SpinAngle, p_Face.XShift, p_Face.XRandomShift);

        s_Action.InheritanceType = p_Source.InheritanceType;
        s_Action.ExecutionType = p_Source.ExecutionType;
        s_Action.Padding = p_Source.Padding;
        s_Action.DecorateWhat = p_Source.DecorateWhat;
        s_Action.DecorationPivot = p_Source.DecorationPivot;
        s_Action.UpDir = p_Source.UpDir;
        s_Action.AlignDecorations = p_Source.AlignDecorations;
        s_Action.ControlShapes = Convert<HkdBreakableShape>(p_Source.ControlShapes);
        s_Action.ControlShapesTransform = p_Source.ControlShapesTransform;
        s_Action.MinFractureLength = p_Source.MinFractureLength;
        s_Action.LinearTolerance = p_Source.LinearTolerance;
        s_Action.AngularTolerance = p_Source.AngularTolerance;
        s_Action.DecorationsStorage = p_Source.DecorationsStorage;
        s_Action.KeepFixedDecorations = p_Source.KeepFixedDecorations;
        s_Action.ProtrusionTest = p_Source.ProtrusionTest;
        s_Action.MaxProtrusion = p_Source.MaxProtrusion;
        s_Action.FixupDistance = p_Source.FixupDistance;
        s_Action.EqualizeGaps = p_Source.EqualizeGaps;
        s_Action.VertGridDist = p_Source.VertGridDist;
        s_Action.VertGridOffset = p_Source.VertGridOffset;
        s_Action.HorGridDist = p_Source.HorGridDist;
        s_Action.HorGridOffset = p_Source.HorGridOffset;
        s_Action.Top = Face(p_Source.Top!);
        s_Action.Bottom = Face(p_Source.Bottom!);
        s_Action.Side = Face(p_Source.Side!);
        s_Action.Flat = Face(p_Source.Flat!);
        s_Action.Corner = new HkdDecorateFractureFaceAction.CornerDecorationInfo(Convert<HkdBreakableShape>(p_Source.CornerDecorations),
            p_Source.CornerDensity, p_Source.CornerMinimumDistance, p_Source.CornerMaximumVerticalShift);
        s_Action.NumCornerDecorationAttempts = p_Source.NumCornerDecorationAttempts;
        s_Action.BorderOverlap = p_Source.BorderOverlap;
        return s_Action;
    }

    private HkdDecorateFractureFaceActionShapeDecorationInfo DecorationInfo(HkdDecorateFractureFaceActionShapeDecorationInfo2012 p_Source)
    {
        var s_Info = new HkdDecorateFractureFaceActionShapeDecorationInfo();
        m_Converted[p_Source] = s_Info;
        s_Info.ConnectionDecorations = p_Source.ConnectionDecorations.Select(p_C => new HkdDecorateFractureFaceActionShapeDecorationInfo.ConnectionDecoration(
            Convert<HkdAction>(p_C.OwningAction), Convert<HkdBreakableShape>(p_C.OtherShape), p_C.StartIndex, p_C.NumDecorations)).ToList();
        s_Info.SharedData = Convert<HkdDecorateFractureFaceActionGlobalDecorationData>(p_Source.SharedData);
        return s_Info;
    }

    private HkdDecorateFractureFaceActionGlobalDecorationData DecorationData(HkdDecorateFractureFaceActionGlobalDecorationData2012 p_Source)
    {
        var s_Data = new HkdDecorateFractureFaceActionGlobalDecorationData();
        m_Converted[p_Source] = s_Data;
        s_Data.Templates = p_Source.Templates.Select(Convert<HkdBreakableShape>).OfType<HkdBreakableShape>().ToList();
        s_Data.BoundingBoxes = p_Source.BoundingBoxes;
        s_Data.RawTransforms = p_Source.RawTransforms;
        s_Data.HalfTransforms = p_Source.HalfTransforms;
        s_Data.CompressedPlacements = p_Source.CompressedPlacements;
        s_Data.IndexBuffer = p_Source.IndexBuffer;
        s_Data.GraphicsRanges = p_Source.GraphicsRanges;
        return s_Data;
    }
}
