using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      public void next()
    {
        StartCoroutine(loadAsync((SceneManager.GetActiveScene().buildIndex) + 1));
    }

    public void restart()
    {
        StartCoroutine(loadAsync((SceneManager.GetActiveScene().buildIndex) ));
    }
    public void Menu()
    {
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
}
