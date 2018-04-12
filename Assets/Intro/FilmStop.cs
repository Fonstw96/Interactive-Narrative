using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class FilmStop : MonoBehaviour
{
    void Start()
    {
        GetComponent<VideoPlayer>().loopPointReached += Volgende;
    }

    void Volgende(VideoPlayer vp)
    {
        SceneManager.LoadScene("Wereld");
    }
}
