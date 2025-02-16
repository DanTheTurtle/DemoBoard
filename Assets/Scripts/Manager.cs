using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public static Manager instance;
	private static int lastScene = 0;
    private static float volume = 1f;
	private Manager() { }
    // Life scale display, where a selectable human body shows three or more selectable exercises for each muscle group. Each exercise, once selected, will play a video demonstration across the touch panel. 
    // While the system is not in use a rotating selection of potential exercise examples plays
    void Start()
    {
        if (instance == null)
		{
			instance = this;
		}
			//If an instance already exists, destroy whatever this object is to enforce the singleton.
		else if (instance != this)
		{
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
    }
    public static void loadSplash() {
        Scene scene = SceneManager.GetActiveScene();
        lastScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("splash",  LoadSceneMode.Single);
        }
    public static void loadMainMenuFront() {
        Scene scene = SceneManager.GetActiveScene();
        lastScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("mainmenufront", LoadSceneMode.Single);
        }
    public static void loadMainMenuBack() {
        Scene scene = SceneManager.GetActiveScene();
        lastScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("mainmenuback", LoadSceneMode.Single);
        }
    public static void loadLastScene() {
        int a = lastScene;
        Scene scene = SceneManager.GetActiveScene();
        lastScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(a, LoadSceneMode.Single);
        }
    public static void loadVideo(int video) { // placeholder
        Scene scene = SceneManager.GetActiveScene();
        lastScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("video"+video, LoadSceneMode.Single);
        }
    public static void loadWorkout(int workout) { // placeholder
        Scene scene = SceneManager.GetActiveScene();
        lastScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("workout"+workout, LoadSceneMode.Single);
    }
    public static void loadGlossary(int workout) { // placeholder
        Scene scene = SceneManager.GetActiveScene();
        lastScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("glossary", LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
