using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceManager : MonoBehaviour
{
    [SerializeField]
    private GameObject sequencePoolCont;
    [SerializeField]
    private List<GameObject> sequencePool;
    
    public List<GameObject> sequences = new List<GameObject>();

    private List<GameObject> GenerateSequence(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject sequenceHolder = Instantiate(sequences[i]);
            sequenceHolder.transform.parent = sequencePoolCont.transform;
            sequenceHolder.SetActive(false);

            sequencePool.Add(sequenceHolder);
        }
        return sequencePool;
    }

    public GameObject requestSequence()
    {
        
        while (true)
        {
            int randomNum = Random.Range(0, sequencePool.Count);
            if(sequencePool[randomNum].activeInHierarchy == false)
            {
                sequencePool[randomNum].SetActive(true);
                return sequencePool[randomNum];
                break;
            }
        }
        return null;
    }


    // Start is called before the first frame update
    void Start()
    {
        sequencePool = GenerateSequence(3);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < sequencePool.Count; i++)
        {
            if(sequencePool[i].transform.position.y < -105)
            {
                sequencePool[i].SetActive(false);
            }
            if(sequencePool[i].activeInHierarchy == false)
            {
                sequencePool[i].transform.position = new Vector3(-9.989263f, 50f, 0);
            }
        }
    }





}
