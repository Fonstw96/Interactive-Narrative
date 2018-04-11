using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vervagen : MonoBehaviour
{
    public float aantalSeconden;
    private Image ik;

    void Start()
    {
        ik = GetComponent<Image>();
    }

    void Update ()
    {
        float doorzichtigheid = 1.0f - Time.time / aantalSeconden;

        if (doorzichtigheid > 0)
            ik.color = new Color(1, 1, 1, doorzichtigheid);
        else
            gameObject.SetActive(false);
    }
}
