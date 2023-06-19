using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SonarEffect: MonoBehaviour
{
    [SerializeField] float minScale = 0.1f;
    [SerializeField] float maxScale = 5f;
    [SerializeField] float scaleSpeed = 0.01f;
    float currentT;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(minScale, minScale, minScale);
        StartCoroutine(ScaleObject());
    }

    IEnumerator ScaleObject()
    {
        while (this.gameObject.activeSelf)
        {
            currentT += scaleSpeed;
            if (currentT >= 1)
            {
                currentT = 0;
            }
            transform.localScale = Vector3.Lerp(new Vector3(minScale, minScale, minScale), new Vector3(maxScale, maxScale, maxScale), currentT);
            yield return null;
        }
    }

}
