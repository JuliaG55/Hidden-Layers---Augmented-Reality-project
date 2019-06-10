using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HideImage : MonoBehaviour {
    public GameObject OriginalImage;
    private int moving;
    private float step;
    private readonly float stepCount = 100F;

    public void Update()
    {
        if (moving == 1 && step < stepCount)
        {
            step++;
            float stepsLeft = stepCount - step;
            float opacity = stepsLeft / stepCount;
            if (OriginalImage.transform.rotation.x < 180)
            {
                Debug.Log(OriginalImage.transform.rotation.x);
                OriginalImage.transform.Rotate(5, 0, 0);
            }
            OriginalImage.transform.position += new Vector3(1f, 0f, 0f);
        }
    }

    public void OnMouseDown()
    {
        moving = 1;
    }

    public void OnEnable()
    {
        Debug.Log("Enabled");
    }
}
