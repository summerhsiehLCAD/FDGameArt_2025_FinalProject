using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private float fadeDuration;

    private SceneFader sceneFade;

    private void Awake()
    {
        sceneFade = GetComponentInChildren<SceneFader>();
    }

    private IEnumerator Start()
    {
        yield return sceneFade.FadeIn(fadeDuration);
    }

    public void LoadingScene(string TestDemo_SP24)
    {
        StartCoroutine(LoadScene(TestDemo_SP24));
    }

    public IEnumerator LoadScene(string TestDemo_SP24)
    {
        yield return sceneFade.FadeOut(fadeDuration);
        yield return SceneManager.LoadSceneAsync(TestDemo_SP24);
    }
}
