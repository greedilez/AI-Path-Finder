using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(int index) => SceneManager.LoadScene(index);

    public void LoadNextScene() => LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    public void Reload() => LoadScene(SceneManager.GetActiveScene().buildIndex);
}
