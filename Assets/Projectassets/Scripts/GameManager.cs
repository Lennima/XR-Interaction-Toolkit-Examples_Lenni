using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public enum GameStates
    {
        NONE,
        Ingame,
        GameOver
    }
    
    public GameStates CurrentState;

    public static GameManager Instance;

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (Instance == null)
        { 
            Instance = this;
        }
        else
        {
            Debug.LogWarning($"There was more than one instance of { this.GetType().Name} deleting additional");
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        GoToDefaultState();
    }

    public void GoToDefaultState()
    {
        SwitchGameState(GameStates.Ingame);
    }

    public void SwitchGameState(GameStates newState)
    {
        if (CurrentState == newState)
        {
            return;
        }

        CurrentState = newState;
    }
}
