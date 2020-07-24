using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequenceManager : MonoBehaviour
{
    public int SequenceSpeed;

    Canvas pauseMenu;

    [SerializeField]
    private GameObject ForestSequencePoolCont;
    [SerializeField]
    private GameObject MountainSequencePoolCont;
    [SerializeField]
    private GameObject CitySequencePoolCont;
    [SerializeField]
    private GameObject TransitionSequencePoolCont;

    [SerializeField]
    public List<GameObject> ForestSequencePool;
    [SerializeField]
    public List<GameObject> MountainSequencePool;
    [SerializeField]
    public List<GameObject> CitySequencePool;
    [SerializeField]
    public List<GameObject> TransitionSequencePool;

    public List<GameObject> ForestSequences = new List<GameObject>();
    public List<GameObject> MountainSequences = new List<GameObject>();
    public List<GameObject> CitySequences = new List<GameObject>();
    public List<GameObject> TransitionSequences = new List<GameObject>();

    private List<GameObject> GenerateForestSequence(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject sequenceHolder = Instantiate(ForestSequences[i]);
            sequenceHolder.transform.parent = ForestSequencePoolCont.transform;
            sequenceHolder.SetActive(false);

            ForestSequencePool.Add(sequenceHolder);
        }
        return ForestSequencePool;
    }

    private List<GameObject> GenerateMountainSequence(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject sequenceHolder = Instantiate(MountainSequences[i]);
            sequenceHolder.transform.parent = MountainSequencePoolCont.transform;
            sequenceHolder.SetActive(false);

            MountainSequencePool.Add(sequenceHolder);
        }
        return MountainSequencePool;
    }

    private List<GameObject> GenerateCitySequence(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject sequenceHolder = Instantiate(CitySequences[i]);
            sequenceHolder.transform.parent = CitySequencePoolCont.transform;
            sequenceHolder.SetActive(false);

            CitySequencePool.Add(sequenceHolder);
        }
        return CitySequencePool;
    }

    private List<GameObject> GenerateTransitionSequence(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject sequenceHolder = Instantiate(TransitionSequences[i]);
            sequenceHolder.transform.parent = TransitionSequencePoolCont.transform;
            sequenceHolder.SetActive(false);

            TransitionSequencePool.Add(sequenceHolder);
        }
        return TransitionSequencePool;
    }

    // Start is called before the first frame update
    void Start()
    {
        ForestSequencePool = GenerateForestSequence(6);
        MountainSequencePool = GenerateMountainSequence(6);
        CitySequencePool = GenerateCitySequence(6);
        TransitionSequencePool = GenerateTransitionSequence(3);
    }

    // Update is called once per frame
    void Update()
    {
        SetSequenceInactiveMove(ForestSequencePool);
        SetSequenceInactiveMove(MountainSequencePool);
        SetSequenceInactiveMove(CitySequencePool);
        SetSequenceInactiveMove(TransitionSequencePool);
    }

    void SetSequenceInactiveMove(List<GameObject> sequencePool)
    {
        for (int i = 0; i < sequencePool.Count; i++)
        {
            if (sequencePool[i].transform.position.y < -105)
            {
                sequencePool[i].SetActive(false);
            }
            if (sequencePool[i].activeInHierarchy == false)
            {
                sequencePool[i].transform.position = new Vector3(-9.989263f, 50f, 0);
            }
        }
    }

    public GameObject RequestSequence(List<GameObject> sequencePool)
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


}
