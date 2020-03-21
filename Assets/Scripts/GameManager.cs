using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // static instance of the game manager so that can access from everyware
    public static GameManager instance = null;

    // player score
    public int score = 0;

    // high score
    public int high_score = 0;

    // level, starting in level 1
    public int current_level = 1;

    // highest possible level
    public int max_level = 2;
    
    // increase score 
    public void increaseScore(int amount)
    {
        // increase score by the given amount
        score += amount;

        // show the new score in the console
        print("New Score: " + score.ToString());

        if (score > high_score)
        {
            high_score = score;
        }

        print("New HighScore: " + high_score.ToString());
    }

    // Called when the Object is initialized
    void Awake()
    {
        // if it doesn't exists
        if ( instance == null )
        {
            instance = this;
        }

        // There can only be a single instance of the game manager
        else if ( instance != this )
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Reset()
    {
        score = 0;
        current_level = 1;
        SceneManager.LoadScene("Level" + current_level);
    }

    public void increaseLevel()
    {
        if ( current_level < max_level )
        {
            current_level++;
        }
        else
        {
            current_level = 1;
        }
        SceneManager.LoadScene("Level" + current_level);
    }
}
