using System;
using System.Collections.Generic;
using fb;
using RimeLib.Mesh.Frostbite;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

public class ShaderProgramDatabase
{
    public struct ProgramInfo
    {
        public ushort[] PermutationCounts { get; set; }   
        public ushort[] PermutationOffsets { get; set; }   
    }

    public struct Permutation
    {
        public uint Mask { get; set; }
        public uint Index { get; set; }
    }

    public struct ShaderInfo
    {
        public byte[] Data { get; set; }
        public GeometryDeclarationDesc? GeometryDeclarationDesc { get; set; }
    }

    public IEnumerable<Permutation> Permutations { get; set; } = Array.Empty<Permutation>();
    
    private readonly Dictionary<ShaderStageType, Dictionary<string, ShaderInfo>> m_Shaders = new();
    private readonly ProgramInfo[] m_ProgramInfo = new ProgramInfo[(int)ShaderProgram.ShaderProgramCount];

    public bool TryGetShader(ShaderStageType p_Stage, string p_Name, out ShaderInfo p_ShaderInfo)
    {
        lock (m_Shaders)
        {
            if (!m_Shaders.TryGetValue(p_Stage, out var s_Shaders))
            {
                p_ShaderInfo = default;
                return false;
            }

            return s_Shaders.TryGetValue(p_Name, out p_ShaderInfo);
        }
    }

    public bool RemoveShader(ShaderStageType p_Stage, string p_Name)
    {
        lock (m_Shaders)
        {
            if (!m_Shaders.ContainsKey(p_Stage))
                return false;
            
            return m_Shaders[p_Stage].Remove(p_Name);
        }
    }

    public void AddOrUpdateShader(ShaderStageType p_Stage, string p_Name, ShaderInfo p_ShaderInfo)
    {
        lock (m_Shaders)
        {
            if (!m_Shaders.ContainsKey(p_Stage))
                m_Shaders.Add(p_Stage, new Dictionary<string, ShaderInfo>());

            m_Shaders[p_Stage][p_Name] = p_ShaderInfo;
        }
    }

    public IEnumerable<string> GetShaderNames(ShaderStageType p_Stage)
    {
        lock (m_Shaders)
        {
            if (!m_Shaders.TryGetValue(p_Stage, out var s_Shaders))
                return Array.Empty<string>();

            return s_Shaders.Keys;
        }
    }

    public ProgramInfo GetProgramInfo(ShaderProgram p_Program)
    {
        if (p_Program >= ShaderProgram.ShaderProgramCount)
            throw new ArgumentOutOfRangeException(nameof(p_Program), "ShaderProgram parameter was not valid.");

        return m_ProgramInfo[(int)p_Program];
    }

    public void SetProgramInfo(ShaderProgram p_Program, ProgramInfo p_Info)
    {
        if (p_Program >= ShaderProgram.ShaderProgramCount)
            throw new ArgumentOutOfRangeException(nameof(p_Program), "ShaderProgram parameter was not valid.");

        m_ProgramInfo[(int)p_Program] = p_Info;
    }
}

