using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    void OnMouseDown()
    {
        Debug.Log("mouse click detected");
        Resources.Load("SphereView");
        //SceneManager.LoadScene("HallScene");
    }

    void OnMouseOver()
    {
        Debug.Log("mouse over detected");
    }
}
