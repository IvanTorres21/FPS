using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetTimeController : MonoBehaviour
{

    private static ResetTimeController instance;

    public bool hasPlayedLevel = false;

    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this);
        instance = this;
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F9))
        {
            StartCoroutine(ResetTime());
        }
        if (Input.GetKeyDown(KeyCode.F12))
        {
            GameObject.Find("Player").GetComponent<PlayerTimeController>().MagicCheat();
        }
    }

    public void TryAgain()
    {
        GameObject.Find("Canvas").transform.GetChild(GameObject.Find("Canvas").transform.childCount - 2).gameObject.SetActive(false);
        StartCoroutine(ResetTime());
    }

    IEnumerator ResetTime()
    {
        try
        {
            GameObject.Find("MusicManager").SetActive(false);
        }
        catch { }
        GameObject.Find("Canvas").transform.GetChild(GameObject.Find("Canvas").transform.childCount - 1).gameObject.SetActive(true);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
