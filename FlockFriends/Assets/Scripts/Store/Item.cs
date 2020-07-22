using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WearableItem", menuName = "WearableItem")]
public class Item : ScriptableObject
{
    public new string name;
    public string Owner;
    public bool own;

    public bool wearing;

    public Sprite image;

    public int cost;
}
