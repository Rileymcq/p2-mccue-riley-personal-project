using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    public GameObject[] lanePrefabs;
    public int laneIndex;
    public GameObject[] treePrefabs;
    public int treeIndex;
    public float spawnRangez = 1;
    public float spawnRangey =0;
    public float spawnRangex =0;
    private float startDelay = 2; 
    private float spawnInterval = 1.8f;
    public float spawnRangez2 = 240;
    public float spawnRangey2 =20;
    public float spawnRangex2 =15;
    public float spawnRangex3 =240;
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private float startDelay2 = 0; 
    private float spawnInterval2 = 0.5f;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleCard;
    
    
    // Start is called before the first frame update
    void Start()
    {

        
       //InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
       //InvokeRepeating("SpawnRandomLane", startDelay2, spawnInterval2);
       //InvokeRepeating("SpawnRandomTree", startDelay2, spawnInterval2);
       //InvokeRepeating("SpawnRandomTreee", startDelay2, spawnInterval2);
       
       //InvokeRepeating("spawnObjects", startDelay2, spawnInterval2);
    }




public void spawnObjects() {
    if (isGameActive) {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomLane", startDelay2, spawnInterval2);
        InvokeRepeating("SpawnRandomTree", startDelay2, spawnInterval2);
        InvokeRepeating("SpawnRandomTreee", startDelay2, spawnInterval2);
    } //else if (isGameActive) {



    //}
    }


    public void StartGame() {
        
        //starts the score at 0
        score = 0;
        UpdateScore(0);
        isGameActive = true;
        InvokeRepeating("spawnObjects", 0, 0);
        titleCard.gameObject.SetActive(false);
    }

    public void GameOver() {
       gameOverText.gameObject.SetActive(true);
       restartButton.gameObject.SetActive(true);
       isGameActive = false;
       CancelInvoke();
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    // Update is called once per frame
    void Update()
    {

        
        
    }

    //public void spawnObjects() {
    //if (isGameActive) {
        void SpawnRandomAnimal(){
            Vector3 spawnpos = new Vector3(Random.Range(-spawnRangex, spawnRangex), spawnRangey, spawnRangez);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
            UpdateScore(3);
        }
        void SpawnRandomLane(){
            Vector3 spawnpos = new Vector3(0, 3.5f, 200);
            int laneIndex = Random.Range(0, lanePrefabs.Length);
            Instantiate(lanePrefabs[laneIndex], spawnpos, lanePrefabs[laneIndex].transform.rotation);
        }
        void SpawnRandomTree(){
            Vector3 spawnpos = new Vector3(Random.Range(-spawnRangex2, -spawnRangex3), spawnRangey2, spawnRangez2);
            int laneIndex = Random.Range(0, treePrefabs.Length);
            Instantiate(treePrefabs[laneIndex], spawnpos, treePrefabs[laneIndex].transform.rotation);
        }
        void SpawnRandomTreee(){
            Vector3 spawnpos = new Vector3(Random.Range(spawnRangex2, spawnRangex3), spawnRangey2, spawnRangez2);
            int laneIndex = Random.Range(0, treePrefabs.Length);
            Instantiate(treePrefabs[laneIndex], spawnpos, treePrefabs[laneIndex].transform.rotation);
        }
    //}  }

    public void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = "Score: " + score; 
    }
}
