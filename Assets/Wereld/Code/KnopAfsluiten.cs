using UnityEngine;
using UnityEngine.UI;

public class KnopAfsluiten : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(delegate () { Application.Quit(); });
    }
}
