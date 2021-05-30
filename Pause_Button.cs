using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Pause_Button : MonoBehaviour
{
    public GameObject pause;
    public GameObject loading;
    
    public bool isgamepaused = false;
    
    IEnumerator loadAsync(int sceneIndex)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneIndex);
        
        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
           
            yield return null;
        }
    }
    public void restart()
    {
        loading.SetActive(true);
        PlayerPrefs.DeleteAll();
        Time.timeScale = 1f;
        StartCoroutine(loadAsync((SceneManager.GetActiveScene().buildIndex)));

    }
    public void paused()
    {
        if (!isgamepaused)
        {
            pause.SetActive(true);
            Time.timeScale = 0f;
            isgamepaused = true;
        }
    }
    public void quit()
    {
        
    }
    public void yes()
    {
        Application.Quit();
    }
    public void no()
    {
        
    }
    public void resume()
    {
        if (isgamepaused)
        {
            pause.SetActive(false);
            Time.timeScale = 1f;
            isgamepaused = false;
        }
    }
    public void menu()
    {
        loading.SetActive(true);
        PlayerPrefs.DeleteAll();
        StartCoroutine(loadAsync((0)));

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            paused();
        }        
    }
}
