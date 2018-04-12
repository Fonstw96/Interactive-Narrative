using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolgendeScene : MonoBehaviour
{
    public string sceneNaam;

	void Start ()
    {
        GetComponent<Button>().onClick.AddListener(delegate () { SceneManager.LoadScene(sceneNaam); });
	}
}
