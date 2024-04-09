using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    private string _sceneNameSaved;

    private readonly LevelName _levelNameSaved = new LevelName();

    private void Start()
    {
        
    }

    public void Load()
    {
        if(!string.IsNullOrEmpty(_sceneNameSaved)) 
        {
           StartCoroutine(ScenesController(_levelNameSaved.GetName()));
        }

    }

    private IEnumerator ScenesController(string name)
    {
        if (string.IsNullOrEmpty(_sceneNameSaved)) { 
        
            yield return StartCoroutine(RemoveOldScene());
            yield return StartCoroutine(UnloadResources());
        }
        yield return StartCoroutine(AddScene((name)));
    }

    private IEnumerator AddScene(string sceneName)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
        _sceneNameSaved = sceneName;
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
    }

    private IEnumerator RemoveOldScene()
    {
        AsyncOperation asyncOperation = SceneManager.UnloadSceneAsync(_sceneNameSaved);
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
    }
    private IEnumerator UnloadResources()
    {
        AsyncOperation asyncOperation = Resources.UnloadUnusedAssets();
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
    }

}
