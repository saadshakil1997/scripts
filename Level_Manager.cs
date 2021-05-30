using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level_Manager : MonoBehaviour
{
    public GameObject loading;
    
    // Start is called before the first frame update
    public void next()
    {
        loading.SetActive(true);
        PlayerPrefs.DeleteAll();
        StartCoroutine(loadAsync((SceneManager.GetActiveScene().buildIndex) + 1));

    }
    public void restart()
    {
        loading.SetActive(true);
        PlayerPrefs.DeleteAll();
        StartCoroutine(loadAsync((SceneManager.GetActiveScene().buildIndex)));

    }
    public void menu()
    {
        loading.SetActive(true);
        PlayerPrefs.DeleteAll();
        StartCoroutine(loadAsync((0)));

    }
    IEnumerator loadAsync(int sceneIndex)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneIndex);
        
        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            
            yield return null;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
