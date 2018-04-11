using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progres : MonoBehaviour
{
    public float blijheid = .5f;
    public Image ontevredenBalk;

	public void VeranderBlijheid(float nieuweBlijheid)
    {
        blijheid = nieuweBlijheid;

        ontevredenBalk.fillAmount = blijheid;
    }
}
