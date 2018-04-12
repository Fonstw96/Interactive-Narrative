using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KnopTerug : MonoBehaviour
{
	void Start ()
    {
        GetComponent<Button>().onClick.AddListener(delegate () { SceneManager.LoadScene("Wereld"); });
	}
}
