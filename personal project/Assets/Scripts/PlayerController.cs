using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
public float horizontalInput;
public float speed = 40.0f;
public float xRange = 10;
public SpawnManager spawnManager;
//public bool gameOver = false;
public TextMeshProUGUI gameOverText;



    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
       horizontalInput = Input.GetAxis("Horizontal"); 
       transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other) {
        if (!gameObject.CompareTag("Animal")) {spawnManager.GameOver();}
        Destroy(gameObject);
        //gameOverText.gameObject.SetActive(true);
    }

   //private void GameOver() {
   //    gameOverText.gameObject.SetActive(true);
   // }
}