using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// © 2017 TheFlyingKeyboard and released under MIT License 
// theflyingkeyboard.net 
public class LerpText : MonoBehaviour
{
    [SerializeField] private float lerpSpeed = 0.25f;
    private Text myText;
    private float maxValue = 0.0f;
    private float previousValue = 0.0f;
    private float t = 0.0f;

    private void Start()
    {
        myText = GetComponent<Text>();
    }
    private void Update()
    {
        if (t < 1.0f)
        {
            t += lerpSpeed * Time.deltaTime;
            myText.text = Mathf.Lerp(previousValue, maxValue, t).ToString("0.");
            //myText.text = Mathf.SmoothStep(previousValue, maxValue, t).ToString("0.");
        }
    }
    public void AddValue(float amount)
    {
        previousValue = maxValue;
        maxValue += amount;
        t = 0.0f;
    }
    public void SubtractValue(float amount)
    {
        previousValue = maxValue;
        maxValue -= amount;
        t = 0.0f;
    }
}