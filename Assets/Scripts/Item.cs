using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Item : MonoBehaviour
{
    MeshRenderer meshRenderer;
    [SerializeField] Color[] myColours = new Color[3];

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        ModifyItem();
    }

    public void ModifyItem()
    {
        if (meshRenderer != null)
        {
            meshRenderer.material.color = Random.ColorHSV();
        }
        else
        {
            Debug.Log("MeshRenderererer don't exist...");
        }

        float xRotation = Random.Range(0, 360f);
        float yRotation = Random.Range(0, 360f);
        float zRotation = Random.Range(0, 360f);

        transform.rotation = Quaternion.Euler(xRotation, xRotation, yRotation);
    }
}

