using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text timeText;
    public Text speedText;
    public GameObject car;
    private int minutes;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateTime());
    }

    IEnumerator UpdateTime()
    {
        while (true)
        {
            timeText.text = minutes + " : " + Mathf.RoundToInt(Time.time).ToString();

            if (Mathf.RoundToInt(Time.time) > 59)
            {
                minutes++;
            }

            yield return new WaitForSeconds(1);
        }
    }

    void Update()
    {
        // Vector3 lastPosition = car.transform.position;
        // speedText.text = Mathf.RoundToInt((car.transform.position - lastPosition).magnitude * 2.23693629f * 400) + " MPH";
    }
}
