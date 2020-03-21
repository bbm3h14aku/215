using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTable : MonoBehaviour
{
    public string text;
    public TextMesh mech;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    { 
        mech.text = text;
    }
}
