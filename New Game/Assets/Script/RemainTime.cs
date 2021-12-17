using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainTime : MonoBehaviour
{
    Text text;
    public static float rTime = 30f;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        rTime -= Time.deltaTime;
        if (rTime < 0)
            rTime = 0;
            text.text = "Time : " + Mathf.Round(rTime);
    }
}
