using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadScreen : MonoBehaviour
{
    [SerializeField] private GameObject _loadingScreen;
    [SerializeField] private Image _progressBar;

    public void LoadingProcess()
    {
        _loadingScreen.SetActive(true);
        StartCoroutine(AsyncLoading());
    }

    IEnumerator AsyncLoading()
    {
        AsyncOperation _asyncLoad = SceneManager.LoadSceneAsync(0);

        _asyncLoad.allowSceneActivation = false;
        
        while (!_asyncLoad.isDone)
        {
            _progressBar.fillAmount += _asyncLoad.progress;

            if (_asyncLoad.progress >= .9f && !_asyncLoad.allowSceneActivation)
            {
                _asyncLoad.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
