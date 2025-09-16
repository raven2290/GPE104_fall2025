using UnityEngine;


public class TheQuitter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this quits the program
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("You pressed escape, so the program will quit if it is a build");
            Application.Quit();
        }
    }
}
