using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F9))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(Input.GetKeyDown(KeyCode.F12))
        {
            GameObject.Find("Player").GetComponent<PlayerTimeController>().MagicCheat();
        }
    }

    public static void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);

    }

}
