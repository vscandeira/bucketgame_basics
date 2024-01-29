using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    public float gameWidth = 27;
    public float offset = 2f;
    [HideInInspector] public int score=0;

    void Awake()
    {
        if(Instance!=null && Instance!=this) {
            Destroy(this);
        } else {
            Instance = this;
        }
    }
}
