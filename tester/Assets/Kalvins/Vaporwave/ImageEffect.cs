﻿using UnityEngine;
using System.Collections;

public class ImageEffect : MonoBehaviour 
{
    public Material mat;

    void Start()
    {
        Application.runInBackground = true;
    }

    void OnRenderImage( RenderTexture src, RenderTexture dest ) 
	{
        Graphics.Blit( src, dest, mat );
    }
}