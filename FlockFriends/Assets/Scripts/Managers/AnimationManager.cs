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
        AnimateTheWearable(ItemManager.PengoWearable, PengoAnimator);
        AnimateTheWearable(ItemManager.OstarWearable, OstarAnimator);
        AnimateTheWearable(ItemManager.TurtsWearable, TurtsAnimator);
    }

    void AnimateTheWearable(List<Item> List, Animator animator)
    {
        for (int i = 0; i < List.Count; i++)
        {
            if (List[i].wearing)
            {
                animator.SetBool(i.ToString(), true);
            }
            else
            {
                animator.SetBool(i.ToString(), false);
            }
        }
    }

}