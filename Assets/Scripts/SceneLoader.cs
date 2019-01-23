using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    AudioSource m_buttonAudio;

    void Start()
    {
        m_buttonAudio = GetComponent<AudioSource>();
    }

	public void SceneLoadButton(string sceneName)
    {
        m_buttonAudio.Play();
        SceneManager.LoadScene(sceneName);
    }

    public void QuitApp()
    {
        m_buttonAudio.Play();
        Application.Quit();
        Debug.Log("QUIT !!");
    }

    public void OpenPanel(GameObject panelGO)
    {
        m_buttonAudio.Play();
        panelGO.SetActive(true);
    }

    public void ClosePanel(GameObject panelGO)
    {
        m_buttonAudio.Play();
        panelGO.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("QUIT !!");
        }
    }
}
