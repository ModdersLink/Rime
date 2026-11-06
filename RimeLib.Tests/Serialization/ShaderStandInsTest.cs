using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;
using RimeLib.Serialization.Frostbite2_0;
using Xunit;

namespace RimeLib.Tests.Serialization;

public class ShaderStandInsTest
{
    private static InstanceRef Shader(int p_Id) => new(new GUID(new Guid(p_Id, 0, 0, new byte[8])), new GUID(new Guid(p_Id, 1, 0, new byte[8])));

    private static ShaderParameters Textures(params string[] p_Names) => ShaderParameters.Of(p_Names, [], []);

    [Fact]
    public void WeighsTexturesOverOtherParameters()
    {
        var s_Source = ShaderParameters.Of(["Diffuse", "Normal"], ["Tint"], []);

        // Shares both textures but not the vector: 6 of 7.
        Assert.Equal(6.0 / 7, s_Source.Similarity(Textures("Diffuse", "Normal")), 6);
        // Shares the vector and one texture: 4 of 7.
        Assert.Equal(4.0 / 7, s_Source.Similarity(ShaderParameters.Of(["Diffuse"], ["Tint"], [])), 6);
    }

    [Fact]
    public void ChoosesTheMostAlikeShaderThenTheMostUsed()
    {
        var s_StandIns = new ShaderStandIns(new Dictionary<InstanceRef, (ShaderParameters, int)>
        {
            [Shader(1)] = (Textures("Diffuse"), 50),
            [Shader(2)] = (Textures("Diffuse", "Normal"), 3),
            [Shader(3)] = (Textures("Diffuse", "Normal"), 9),
        });

        var s_Pick = s_StandIns.Choose(Textures("Diffuse", "Normal"));

        Assert.Equal(Shader(3), s_Pick!.Shader);
        Assert.Equal(1, s_Pick.Similarity);
    }

    [Fact]
    public void TakesANearlyAsAlikeShaderThatDrawsMoreButNotAnUnalikeOne()
    {
        var s_StandIns = new ShaderStandIns(new Dictionary<InstanceRef, (ShaderParameters, int)>
        {
            [Shader(1)] = (Textures("Diffuse", "Normal", "Specular"), 9),
            [Shader(2)] = (Textures("Diffuse", "Normal", "Specular", "Detail"), 1),
            [Shader(3)] = (Textures("Diffuse"), 1),
        });

        // Shader 2 is 3/4 as alike as shader 1, shader 3 a third.
        Assert.Equal(Shader(2), s_StandIns.Choose(Textures("Diffuse", "Normal", "Specular"), p_S => p_S == Shader(1) ? 0 : 5)!.Shader);
        Assert.Equal(Shader(1), s_StandIns.Choose(Textures("Diffuse", "Normal", "Specular"), p_S => p_S == Shader(3) ? 5 : 0)!.Shader);
    }

    [Fact]
    public void ChoosesNoneWhenNoParameterNameIsShared()
    {
        var s_StandIns = new ShaderStandIns(new Dictionary<InstanceRef, (ShaderParameters, int)> { [Shader(1)] = (Textures("Diffuse"), 1) });

        Assert.Null(s_StandIns.Choose(Textures("_CS")));
        Assert.Null(s_StandIns.Choose(Textures()));
    }

    [Fact]
    public void RebindsMaterialsAndDropsWhatTheStandInDoesNotTake()
    {
        var s_Partition = new RimeLib.Serialization.Frostbite2_0.Ebx.DatabasePartition
        {
            PartitionGuid = Shader(9).Partition,
            PrimaryInstanceGuid = Shader(9).Instance,
        };
        var s_Material = new fb.MeshMaterial { InstanceId = new DataContainerId.Guid(Shader(9).Instance) };
        s_Material.Shader.Shader.SetValue(Shader(1).Partition, new DataContainerId.Guid(Shader(1).Instance));
        s_Material.Shader.TextureParameters.Add(new fb.TextureShaderParameter { ParameterName = "Diffuse" });
        s_Material.Shader.TextureParameters.Add(new fb.TextureShaderParameter { ParameterName = "Detail" });
        s_Partition.InstanceMap.Add(Shader(9).Instance, s_Material);

        var s_Dropped = new ShaderBindings().Rebind(s_Partition, new Dictionary<InstanceRef, ShaderStandIn>
        {
            [Shader(1)] = new(Shader(2), Textures("Diffuse", "Normal"), 0.5),
        });

        Assert.Equal(["Detail"], s_Dropped);
        Assert.Equal(["Diffuse"], s_Material.Shader.TextureParameters.Select(p_P => p_P.ParameterName));
        Assert.Equal(Shader(2), new ShaderBindings().Materials(s_Partition).Single().Shader);
    }
}
