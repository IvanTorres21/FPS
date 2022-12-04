using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.GetComponent<PlayableDirector>() != null)
        {
            if (!FindObjectOfType<ResetTimeController>().hasPlayedLevel)
            {
                gameObject.GetComponent<PlayableDirector>().Play();

            }
            else
            {
                GiveWeaponsBack();
            }
        }
    }

    

    public static void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);

    }

    

    public void GiveWeaponsBack()
    {
        Debug.Log("Hey");
        GameObject.Find("Player").transform.GetChild(1).localPosition = new Vector3(0, 0.800000012f, 0.400000006f);
        GameObject.Find("Player").transform.GetChild(1).localRotation = Quaternion.Euler(0, 0, 0);
        GameObject.Find("Player").transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
        Destroy(GameObject.Find("CM vcam1"));
        FindObjectOfType<ResetTimeController>().hasPlayedLevel = true;
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
