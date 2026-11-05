using RimeLib.Frostbite;
using RimeLib.Shader;
using RimeLib.Content.Mounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RimeLib.Shader.Frostbite2_0.Frostbite;
using RimeLib.Content.Frostbite;

namespace RimeLib.Shader.Frostbite2_0
{
    public class ShaderResolver : IShaderResolver
    {
        public ShaderDatabaseContainer? ShaderDatabaseContainer { get; private set; }

        public EngineType[] GetSupportedEngines()
        {
            return new[] { EngineType.Frostbite2_0 };
        }

        public ISet<string> GetTextureNames()
        {
            var textureNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            var shaderDatabase = ShaderDatabaseContainer?.Databases.First().Value;
            if (shaderDatabase == null)
                return textureNames;

            foreach (var constant in shaderDatabase.Constants)
            {
                foreach(var texture in constant.Textures)
                {
                    textureNames.Add(texture.Name);
                }
            }


            return textureNames;
        }

        public ISet<string> GetShaderNames()
        {
            var shaderNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            if (ShaderDatabaseContainer == null)
                return shaderNames;

            foreach (var database in ShaderDatabaseContainer.Databases.Values)
                shaderNames.UnionWith(database.Shaders.Keys);

            return shaderNames;
        }

        public IReadOnlyDictionary<string, ISet<string>> GetTexturesByShader()
        {
            var s_Result = new Dictionary<string, ISet<string>>(StringComparer.OrdinalIgnoreCase);
            if (ShaderDatabaseContainer == null)
                return s_Result;

            // A shader's streamable textures, and the textures its solutions' constants bind.
            foreach (var s_Database in ShaderDatabaseContainer.Databases.Values)
            foreach (var (s_Name, s_Shader) in s_Database.Shaders)
            {
                if (!s_Result.TryGetValue(s_Name, out var s_Textures))
                    s_Result[s_Name] = s_Textures = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                foreach (var s_Texture in s_Shader.StreamableTextures)
                    s_Textures.Add(s_Texture.Name);

                foreach (var s_Solution in s_Shader.Solutions)
                foreach (var s_Constants in new[] { s_Solution.VertexConstants, s_Solution.PixelConstants })
                {
                    foreach (var s_Texture in s_Constants?.Textures ?? Array.Empty<Frostbite.ShaderConstants.TextureConstant>())
                        s_Textures.Add(s_Texture.Name);
                }
            }

            return s_Result;
        }

        public void Initialize(IResourceObject resource, IEngineMounter mounter)
        {
            if (resource == null)
                return;

            if (resource.GetResourceType() != ResourceType.DxShaderDatabase && resource.GetResourceType() != ResourceType.IShaderDatabase)
                return;

            ShaderDatabaseContainer = new ShaderDatabaseContainer(resource.GetReader(), mounter);
        }
    }
}
