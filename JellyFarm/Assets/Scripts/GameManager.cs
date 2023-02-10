using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Sprite[] jellySpriteList;
    public string[] jellyNameList;
    public int[] jellyJelatinList;
    public int[] jellyGoldList;

    public Vector3[] PointList;

    public RuntimeAnimatorController[] LevelAc;

    public void ChangeAc(Animator anim, int level)
    {
        // level�� 1���� �����ϹǷ� 1�� ���־�� index�� ����
        anim.runtimeAnimatorController = LevelAc[level - 1];
    }
}