using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum ServiceState { MENU, HALL, LOADING }
public delegate void OnStateChangeHandler();

public class ServiceWorker : MonoBehaviour
{
    public static ServiceWorker instance = null;

    public string keyWord;
    public string[] results;
    public int current_page;
    public int multiplic_page = 20;

    public GameObject hallPrefab;
    public GameObject playerPrefab;

    // Called when the Object is initialized
    void Awake()
    {
        // if it doesn't exists
        if (instance == null)
        {
            instance = this;
        }

        // There can only be a single instance of the game manager
        else if (instance != this)
        {
            // destroy the current object, so there is just one manager
            Destroy(gameObject);
        }

        // dont destroy this object when loading scenes
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector3 size = hallPrefab.GetComponent<Collider>().bounds.size;
        Debug.Log("length=" + size);

        Instantiate(playerPrefab, new Vector3(0, 1, 0), Quaternion.identity);
        for ( int i = 1; i <= 5; i++)
        {
            Instantiate(hallPrefab, new Vector3(5 * i, 1, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void loadScene(int page_idx)
    {
        //TODO: Neu Szene aus vorhandenem Material dynamisch erstellen. Prefab HallElement
        SceneManager.LoadScene("Level");
    }
}
