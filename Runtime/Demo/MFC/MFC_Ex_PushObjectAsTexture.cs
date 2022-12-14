using MemoryFileConnectionUtility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MFC_Ex_PushObjectAsTexture : MonoBehaviour
{


    public MemoryFileConnectionDLLMono m_connection;
    public Color m_coloredTextureToPush;
    public Texture2D m_textureToPush;
    public Texture2D m_textureRecovered;

    [ContextMenu("Push and recover")]
    public void PushAndRecoverDonjon()
    {

        m_textureToPush = new Texture2D(4, 4, TextureFormat.RGBA32, true);
        Color[] c = m_textureToPush.GetPixels();
        for (int i = 0; i <c.Length; i++)
        {
            c[i] = m_coloredTextureToPush;
        }
        m_textureToPush.SetPixels(c);
        m_textureToPush.Apply();
        m_connection.SetAsTextureWithDefault(m_textureToPush);
        m_connection.GetAstexture2DWithDefault(out m_textureRecovered);   
    }
}
