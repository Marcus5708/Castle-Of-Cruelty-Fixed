using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenDoor : MonoBehaviour
{
    public int currentSceneIndex; 
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenCorrectDoor()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void OpenWrongDoor()
    {
        Debug.Log("WrongDoorOpened");
    }
}
