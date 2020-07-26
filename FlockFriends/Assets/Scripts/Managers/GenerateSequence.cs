using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSequence : MonoBehaviour
{
    GameObject gameManager;
    SequenceManager sqm;
    LevelManager levelManager;
    PlayerManager playerManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        sqm = gameManager.GetComponent<SequenceManager>();
        levelManager = gameManager.GetComponent<LevelManager>();
        playerManager = gameManager.GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //Switch statement for level and number
            // choices are Forest Level, Mountain Level, City Level, or transitions level

            if(levelManager.AmountSequencesPassed == levelManager.NumberOfSequences)
            {
                GameObject sequencesHolder;
                switch (levelManager.Level)
                {
                    case "Forest":
                        //switch level to next level
                        levelManager.Level = "Mountain";

                        //AmountSquencesPassed set back to 0
                        levelManager.AmountSequencesPassed = 0;

                        //Generate the transition Sequence
                        sequencesHolder = sqm.RequestSequence(sqm.TransitionSequencePool);
                        sequencesHolder.GetComponent<Rigidbody2D>().position = new Vector2(-9.989263f, 70f);

                        break;
                    case "Mountain":
                        //switch level to next level
                        levelManager.Level = "City";

                        //AmountSquencesPassed set back to 0
                        levelManager.AmountSequencesPassed = 0;

                        //Generate the transition Sequence
                        sequencesHolder = sqm.RequestSequence(sqm.TransitionSequencePool);
                        sequencesHolder.GetComponent<Rigidbody2D>().position = new Vector2(-9.989263f, 70f);
                        break;
                    case "City":
                        //switch level to next level
                        levelManager.Level = "Forest";

                        //AmountSquencesPassed set back to 0
                        levelManager.AmountSequencesPassed = 0;

                        //Generate the transition Sequence
                        sequencesHolder = sqm.RequestSequence(sqm.TransitionSequencePool);
                        sequencesHolder.GetComponent<Rigidbody2D>().position = new Vector2(-9.989263f, 70f);

                        //If Side Character is set inactive then set active
                        playerManager.AddCharacter();

                        //Add 5 to Number of Sequences
                        levelManager.NumberOfSequences += 5;
                        break;
                }
            }
            else
            {
                GameObject sequencesHolder;
                switch (levelManager.Level)
                {
                    case "Forest":
                        //Request sequence for forest
                        sequencesHolder = sqm.RequestSequence(sqm.ForestSequencePool);

                        //set loaction
                        sequencesHolder.GetComponent<Rigidbody2D>().position = new Vector2(-9.989263f, 70f);
                        break;
                    case "Mountain":
                        //request sequence for mountain
                        sequencesHolder = sqm.RequestSequence(sqm.MountainSequencePool);

                        //Set location
                        sequencesHolder.GetComponent<Rigidbody2D>().position = new Vector2(-9.989263f, 70f);
                        break;
                    case "City":
                        //RequestSequence for city
                        sequencesHolder = sqm.RequestSequence(sqm.CitySequencePool);

                        //Set Location
                        sequencesHolder.GetComponent<Rigidbody2D>().position = new Vector2(-9.989263f, 70f);
                        break;
                }
                levelManager.AmountSequencesPassed++;
            }
        }
    }
}
