using UnityEngine;

public class GameplayController : MonoBehaviour{

    public static GameplayController instance;

    public BoxSpawner box_Spawner;

    [HideInInspector] 
    public BoxScripts currentBox;

    public CameraFollow cameraScript;
    private int moveCount;
    private bool lerpCamera;

    void Awake(){
        if(instance == null){
            instance = this;
        }
    }
    void Start(){
        Debug.Log("Gameplay Controller Start");
        box_Spawner.SpawnBox();
    }

    void Update(){

        DetectInput();
        
    }

    void DetectInput(){
        if(Input.GetMouseButtonDown(0)){
            currentBox.DropBox();
        }
    }

    public void SpawnNewBox(){
        Debug.Log("New Box Spawned");

        Invoke("NewBox", 1.5f);
        
    }
    void NewBox(){
        box_Spawner.SpawnBox();
    }

    public void MoveCamera(){
        moveCount++;
        if(moveCount == 3){
            moveCount = 0;
            cameraScript.targetPosition.y += 2f;
        }
    }

    public void RestartGame(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
