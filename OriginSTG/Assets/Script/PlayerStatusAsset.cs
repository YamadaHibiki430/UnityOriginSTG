using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStatusAsset", menuName = "ScriptableObjects/CreatePlayerStatusAsset")]
public class PlayerStatusAsset : ScriptableObject
{
    [SerializeField, Header("最大ライフポイント")]
    private int maxLifePoint = 5;

    [SerializeField, Header("ライフポイント")]
    private int lifePoint = 5;

    [SerializeField, Header("移動速度")]
    private float moveSpeed = 50.0f;

    #region プレイヤーの移動制限

    [SerializeField]
    private float maxLimitPositionZ = 5.0f;

    [SerializeField]
    private float minLimitPositionZ = -5.0f;

    [SerializeField]
    private float maxLimitPositionX = 5.0f;

    [SerializeField]
    private float minLimitPositionX = -5.0f;

    #endregion

    public int GetMaxLifePoint => maxLifePoint;

    public float GetMoveSpeed => moveSpeed;

    public int LifePoint
    {
        get { return lifePoint; }
        set { lifePoint = value; }
    }
}
