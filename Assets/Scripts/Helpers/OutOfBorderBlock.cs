using UnityEngine;
using System.Collections;
using  Utility;


public class OutOfBorderBlock : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _representation;

    void LateUpdate()
    {
        GameAreaHelper.BlockInGameplayArea(transform,_representation.bounds);
    }
}
