using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereButtonEvent : MonoBehaviour
{

    public GameObject buttonPrefab;

    private double lastButtonSetTime = System.DateTime.Now.TimeOfDay.TotalMilliseconds;

    private Rect windowRect = new Rect(Screen.width, Screen.height, Screen.width + 100, Screen.height + 100);

    // Start is called before the first frame update
    void Start()
    {
        
        //buttonPrefab = GameObject.Find("Sphere");
        
    }

    // Update is called once per frame
    void Update()
    {
        handleCreateButton();
        //windowRect = GUI.Window(0, windowRect, createWindowContent, "Zieltextur eingeben: ");
        
    }


    void createWindowContent(int windowID)
    {
        /*GUI.Label(new Rect(10, 10, 250, 250), text);

        if (GUI.Button(new Rect(10, 250, 100, 20), "Close"))
        {
            showInfo = false;
        }*/
    }

    private void handleCreateButton()
    {
        //get current Time
        double time = System.DateTime.Now.TimeOfDay.TotalMilliseconds;
        //check if the last run isi 1000 ms ago and the right mouse button is pressed
        if(time - lastButtonSetTime > 1000 &&
            Input.GetMouseButton(1))
        {
            //get the direction Vector(Ray) betreen camera and mouse
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

            //calc the position of the new button
            //position = camera position + skalierung der sphere(durchmesser) / 2 um den radius zu bekommen * direction of the camera mouse vector(ray)
            Vector3 buttonPosition = Camera.main.transform.position + transform.localScale.x / 2f * ray.direction;

            //create a new instance of the buttonPrefab
            GameObject newButton = (GameObject) Instantiate(buttonPrefab, buttonPosition, Quaternion.identity);

            //save the creation time to wait until the next butten can be made
            lastButtonSetTime = System.DateTime.Now.TimeOfDay.TotalMilliseconds;
        } 
    }

}
