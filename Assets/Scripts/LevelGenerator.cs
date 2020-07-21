using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour{

    public static LevelGenerator sharedInstance;

    public List<LevelBlock> allTheLevelBlocks = new List<LevelBlock>();

    public Transform levelStartPoint;

    public List<LevelBlock> currentBlocks = new List<LevelBlock>();

    private void Awake()
    {
        sharedInstance = this;
    }

    public void AddLevelBlock()
    {
        
    }

    public void RemoveOldestLevelBlock()
    {

    }

    public void RemoveAllTheBlocks()
    {

    }

    public void GeneratorInitialBlocks()
    {

    }

        
}
