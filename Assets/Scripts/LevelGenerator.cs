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

    private void Start()
    {
        AddLevelBlock();
        AddLevelBlock();
        AddLevelBlock();
    }

    public void AddLevelBlock()
    {
        int randomIndex = Random.Range(0, allTheLevelBlocks.Count);

        LevelBlock currentBlock = (LevelBlock)Instantiate(allTheLevelBlocks[randomIndex]);
        currentBlock.transform.SetParent(this.transform, false);

        Vector3 spawPosition = Vector3.zero;

        if (currentBlocks.Count == 0)
        {
            spawPosition = levelStartPoint.position;
        }else
        {
            spawPosition = currentBlocks[currentBlocks.Count - 1].exitPoint.position;
        }

        Vector3 correction = new Vector3(spawPosition.x-currentBlock.startPoint.position.x, spawPosition.y-currentBlock.startPoint.position.y, 0);
        
        currentBlock.transform.position = correction;
        currentBlocks.Add(currentBlock);
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
