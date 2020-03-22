using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTable : MonoBehaviour
{
    public string text;
    public int textSize;
    public int spacesTillReturn;
    public TextMesh mech;
    
    private Rect windowRect = new Rect (20, 20, 300, 200);
    private bool showInfo = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        /*mech.fontSize = textSize;

        

        string modifiedLine="";
        int spaces=0;
        foreach (char value in text)
        {
            if (value == ' ')
            {
                spaces++;
                if (spaces == spacesTillReturn) //To insert \n after every 9th word: if((spaces%9)==0)
                {
                    modifiedLine += "\n";
                    spaces = 0;
                }
                else
                    modifiedLine += value;
            }
            else
            {
                modifiedLine += value;
            }                
        }



        mech.text = modifiedLine;*/
    }

    

     void OnMouseDown()
    {
        showInfo = true;
    }

    void OnGUI()
    {
        

        if(showInfo)
            windowRect = GUI.Window(0, windowRect, DoMyWindow, "My Window");
    }

    // Make the contents of the window
    void DoMyWindow(int windowID)
    {
        GUI.Label(new Rect(10, 10, 200, 200), text);

        if (GUI.Button(new Rect(10, 20, 100, 20), "Close"))
        {
            showInfo = false;
        }
    }
}
