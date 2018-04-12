using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToonTekst : MonoBehaviour
{
    public float aantalSeconden;

    private Image ik;
    public Text mijnKind;
    private bool hetMag = false;
    private float startTijd = 0;

    void Start()
    {
        ik = GetComponent<Image>();
        GetComponent<Button>().onClick.AddListener(delegate () { if (hetMag) SceneManager.LoadScene("Wereld"); });
    }

    void Update()
    {
        if (hetMag)
        {
            float doorzichtigheid = (Time.time - startTijd) /aantalSeconden;

            if (doorzichtigheid > 0)
            {
                ik.color = new Color(1, 1, 1, doorzichtigheid);
                mijnKind.color = new Color(0.9176f, 0.0706f, 0.0706f, doorzichtigheid);
            }
        }
    }

    public void SESAMSLUITU()
    {
        hetMag = true;
        startTijd = Time.time;
    }
}
