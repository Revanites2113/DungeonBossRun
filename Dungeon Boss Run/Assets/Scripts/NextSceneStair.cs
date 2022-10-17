using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneStair : MonoBehaviour
{
    // Start is called before the first frame update
    public int indexOfLevelLoad;
    [SerializeField] private Grid grid;
    void Start()
    {
        DontDestroyOnLoad(grid);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //load scene after collision with player (index of 1 for phase 2, 2 for phase 3);
        if (col.tag == "Player")
        {
            SceneManager.LoadScene(indexOfLevelLoad);
        }
    }
}
