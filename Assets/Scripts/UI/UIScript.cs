using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text timeText;
    public Text speedText;
    public Text scoreText;
    public GeneralInfo generalInfo;
    public GameObject car;
    public CarMovement carMovement;
    private int minutes;
    private float timecheck;
    private float timesecs;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateTime());
    }

    IEnumerator UpdateTime()
    {
        while (true)
        {
            timecheck += 1;
            timeText.text = minutes + " : " + timecheck.ToString();
            //Debug.Log(timecheck);
            if (Mathf.RoundToInt(timecheck) > 59)
            {
                timecheck = 0;
                minutes++;
            }

            yield return new WaitForSeconds(1);
        }
    }

    //public void ChangeTime(int seconds)
    //{
    //timeAlter -= seconds;
    //}

    void Update()
    {
        // Vector3 lastPosition = car.transform.position;
        speedText.text = Mathf.RoundToInt(carMovement.currentSpeed) + " MPH";
        scoreText.text = ("Score " + Mathf.RoundToInt(generalInfo.Score));
    }
}

