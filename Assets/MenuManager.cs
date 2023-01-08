using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToStage1()
    {
        SceneManager.LoadScene("Stage 1");
    }
    public void goToStage2()
    {
        SceneManager.LoadScene("Stage 2");
    }public void goToStage3()
    {
        SceneManager.LoadScene("Stage 3");
    }
    public void goToStage4()
    {
        SceneManager.LoadScene("Stage 4");
    }
}
