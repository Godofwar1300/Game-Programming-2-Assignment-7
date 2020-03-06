using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTwo : MonoBehaviour
{
    private Vector3 originalScale;
    private Vector3 scaleChange;
    private Vector3 maxSize;
    private Vector3 minSize;

    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale;
        maxSize = new Vector3(originalScale.x + 3f, originalScale.y + 3f, originalScale.z + 3f);
        minSize = new Vector3(originalScale.x - 1f, originalScale.y - 1f, originalScale.z - 1f);
    }

    public void Grow()
    {
        if(!gameObject.transform.localScale.Equals(maxSize))
        {
            scaleChange = new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.transform.localScale += scaleChange;
        }
        else
        {
            scaleChange = Vector3.zero;
            gameObject.transform.localScale += scaleChange;
            Debug.Log("You can't grow anymore!");
        }
    }

    public void Shrink()
    {
        if (!gameObject.transform.localScale.Equals(minSize))
        {
            scaleChange = new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.transform.localScale -= scaleChange;
        }
        else
        {
            scaleChange = Vector3.zero;
            gameObject.transform.localScale -= scaleChange;
            Debug.Log("You can't shrink anymore!");
        }
    }

}
