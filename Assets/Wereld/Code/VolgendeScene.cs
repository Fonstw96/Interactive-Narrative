using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolgendeScene : MonoBehaviour
{
    public int sceneNummer;

	void Start ()
    {
        GetComponent<Button>().onClick.AddListener(delegate () { SceneManager.LoadScene(sceneNummer); });
	}
}
