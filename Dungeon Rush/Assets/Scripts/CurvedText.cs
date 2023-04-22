using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurvedText : MonoBehaviour
{
    public float curveIntensity = 1.0f; // Intensity of the curve
    public float curveSpeed = 1.0f; // Speed of the curve
    public float curveOffset = 0.0f; // Offset of the curve
    public float curvePeriod = 2.0f; // Period of the curve
    public bool useRandomOffset = false; // Use random offset for the curve

    public TextMeshProUGUI tmp; // Reference to TextMeshProUGUI component
    private Vector3 originalPosition; // Original position of the TMP object

    void Start()
    {
        //tmp = GetComponent<TextMeshProUGUI>();
        originalPosition = tmp.rectTransform.localPosition;

        if (useRandomOffset)
        {
            curveOffset = Random.Range(0.0f, 1.0f);
        }
    }

    void Update()
    {
        // Calculate the curve position
        float curveTime = Time.time * curveSpeed + curveOffset;
        float curveX = Mathf.Sin(curveTime * Mathf.PI * 2.0f / curvePeriod) * curveIntensity;
        Vector3 curvePosition = originalPosition + new Vector3(curveX, 0.0f, 0.0f);

        // Apply the curve position to the TMP object
        tmp.rectTransform.localPosition = curvePosition;
        
    }
}
