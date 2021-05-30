using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI_Manager : MonoBehaviour
{
    public GameObject loading;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void level1()
    {
        loading.SetActive(true);
        StartCoroutine(loadAsync((SceneManager.GetActiveScene().buildIndex)+1));
    }
    public void level2()
    {
        loading.SetActive(true);
        StartCoroutine(loadAsync((SceneManager.GetActiveScene().buildIndex) + 2));
    }
    public void quit_yes()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
