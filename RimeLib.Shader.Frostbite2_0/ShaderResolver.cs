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
