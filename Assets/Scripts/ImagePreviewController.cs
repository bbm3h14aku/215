using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagePreviewController : MonoBehaviour
{
    MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        Debug.Log("mouse over detected");
    }
}
