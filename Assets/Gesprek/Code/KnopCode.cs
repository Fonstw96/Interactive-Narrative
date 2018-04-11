using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnopCode : MonoBehaviour
{
    public Text spreekVak;
    public string reactie;

    public GameObject gameController;
    public float blijheid;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(delegate()
        {
            spreekVak.text = reactie;
            gameController.GetComponent<Progres>().VeranderBlijheid(blijheid);
            gameController.GetComponent<Vragen>().VolgendeRonde();
        });
    }
}
