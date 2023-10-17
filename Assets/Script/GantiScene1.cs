using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GantiScene1 : MonoBehaviour
{
    public string targetSceneName; // Nama scene yang akan diganti
    public float delayTime = 5.0f; // Waktu tunda sebelum pergantian scene

    void Start()
    {
        // Menjalankan fungsi ChangeScene setelah waktu tunda
        Invoke("ChangeScene", delayTime);
    }

    void ChangeScene()
    {
        // Ganti scene ke targetSceneName
        SceneManager.LoadScene(targetSceneName);
    }
    public void ChangeMyScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
}
