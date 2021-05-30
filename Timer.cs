using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public GameObject textDispaly;
  public  int time = 60;
    public int secondsleft = 60;
    public int min, seconds = 00;
    public bool takingAway = false;
   public IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsleft -= 1;
        textDispaly.GetComponent<Text>().text = min + ":" + secondsleft;
        seconds += 1;
        takingAway = false;



    }
    // Start is called before the first frame update
    public void Start()
    {
        textDispaly.GetComponent<Text>().text = "0" + min + ":" + "0" + seconds;
    }

    // Update is called once per frame
    void Update()
    {

        if (takingAway == false && secondsleft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }


}
