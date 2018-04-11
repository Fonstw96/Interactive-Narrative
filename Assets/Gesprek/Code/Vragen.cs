using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class StringList
{
    public string[] antwoorden;
}

[System.Serializable]
public class FloatList
{
    public float[] waarde;
}

public class Vragen : MonoBehaviour
{
    public StringList[] teksten;
    public FloatList[] reactieBlijheid;
    public string[] vragen;
    public StringList[] opties;

    public Text spreekVak;
    public Text dialoogVak;
    public Button[] dialoogKnoppen;

    private int progres = -1;

    private void Start()
    {
        VolgendeRonde();
    }

    public void VolgendeRonde()
    {
        progres++;
        if (progres < vragen.Length)
            VulElementen(progres);
    }

    private void VulElementen(int p)
    {
        dialoogVak.text = vragen[p];

        int index = 0;
        foreach (Button knop in dialoogKnoppen)
        {
            // Ik ben niet trots op deze clusterf---
            knop.GetComponentInChildren<Text>().text = opties[p].antwoorden[index];
            knop.GetComponent<KnopCode>().reactie = teksten[p].antwoorden[index];
            knop.GetComponent<KnopCode>().blijheid = reactieBlijheid[p].waarde[index];

            index++;
        }
    }
}
