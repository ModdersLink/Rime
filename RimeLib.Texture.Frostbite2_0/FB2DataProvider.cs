using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Texture.Frostbite2_0
{
    public class FB2DataProvider : ITextureDataProvider
    {
        public FB2DataProvider(IEngineMounter p_Engine, FB2Texture? p_Texture)
        {
            m_Engine = p_Engine;
            m_Texture = p_Texture;
        }
        protected IEngineMounter m_Engine;
        protected FB2Texture? m_Texture;


        protected Stream? GetStream(object? p_Data)
        {
            var s_ChunkId = m_Texture?.m_Texture.StreamingChunkId;

            if (s_ChunkId == null)
                return null;

            if (!m_Engine.TryGetChunk(s_ChunkId, out var s_Chunk))
                return null;

            return s_Chunk?.FirstVariant.GetReader();
        }

        public RimeReader? GetReader(object? p_Data)
        {
            return GetStream(p_Data) as RimeReader;
        }

        public RimeWriter? GetWriter(object? p_Data)
        {
            throw new NotSupportedException("Writing textures straight from game is not supported! Create a new texture, and write a copy there.");
            return null;
        }
    }
}
