using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearReset : MonoBehaviour
{
    [SerializeField]
    GameObject resetCanvas;


    string sceneName;

    private void Start()
    {
        resetCanvas.SetActive(false);
        sceneName = SceneManager.GetActiveScene().name;
    }
    

    public void SceneReset()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ResetCansel()
    {
        resetCanvas.SetActive(false);
    }
}
