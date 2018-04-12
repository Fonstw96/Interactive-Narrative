using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToonKaart : MonoBehaviour
{
    public float aantalSeconden;

    private Image ik;
    private bool hetMag = false;
    private float startTijd = 0;

    void Start()
    {
        ik = GetComponent<Image>();
        GetComponent<Button>().onClick.AddListener(delegate () { if (hetMag) SceneManager.LoadScene(0); });
    }

    void Update()
    {
        if (hetMag)
        {
            float doorzichtigheid = (Time.time - startTijd) /aantalSeconden;

            if (doorzichtigheid > 0)
                ik.color = new Color(1, 1, 1, doorzichtigheid);
            else
                gameObject.SetActive(false);
        }
    }

    public void SESAMOPENU()
    {
        hetMag = true;
        startTijd = Time.time;
    }
}
