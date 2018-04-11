using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class StringList
{
    public string[] antwoorden;
}

public class Vragen : MonoBehaviour
{
    public string[] teksten;
    public string[] vragen;
    public StringList[] opties;

    public Text spreekVak;
    public Text dialoogVak;
    public Text[] dialoogKnoppen;

    private int progres = 0;

    private void Start()
    {
        VolgendeRonde();
    }

    public void VolgendeRonde()
    {
        VulElementen(progres);
        progres++;
    }

    private void VulElementen(int p)
    {
        spreekVak.text = teksten[p];
        dialoogVak.text = vragen[p];

        int index = 0;
        foreach (Text knop in dialoogKnoppen)
        {
            knop.text = opties[p].antwoorden[index];
            index++;
        }
    }
}
