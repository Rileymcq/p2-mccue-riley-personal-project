using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    public SpawnManager spawnManager;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        spawnManager =  GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        button.onClick.AddListener(Poptart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
//congrats you found The Poptart Easter Egg
    void Poptart() {
        Debug.Log(gameObject.name + " was clicked");
        spawnManager.StartGame();
    }
}
