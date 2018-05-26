using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shader : MonoBehaviour {
    bool enable;
    public Material mat;

    public static Shader instance;

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (enable)
            Graphics.Blit(src, dest, mat);
        else
            Graphics.Blit(src, dest);
    }
    public void EnableShader()
    {
        enable = true;
        CancelInvoke();
        Invoke("DisableShader", 0.01f);
    }
    private void DisableShader()
    {
        enable = false;
    }
    void Start()
    {
        instance = this;
        enable = false;
    }
}
