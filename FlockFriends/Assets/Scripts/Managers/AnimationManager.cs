using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator PengoAnimator;
    public Animator OstarAnimator;
    public Animator TurtsAnimator;

    private void Start()
    {
        for (int i = 0; i < ItemManager.TurtsWearable.Count; i++)
        {
            if (ItemManager.TurtsWearable[i].wearing)
            {
                TurtsAnimator.SetBool(i.ToString(), true);
            }
            else
            {
                TurtsAnimator.SetBool(i.ToString(), false);
            }
        }
    }

}