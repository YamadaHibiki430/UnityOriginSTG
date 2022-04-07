using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private PlayerStatusAsset playerStatus = null;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(GetPlayerInputDirection(), InputManager.Instance.IsLShiftKey);
    }

    /// <summary>
    /// プレイヤーのインプット方向
    /// </summary>
    private Vector3 GetPlayerInputDirection()
    {

        var moveDirection = Vector3.zero;

        if (InputManager.Instance.IsUpMoveKey)
        {
            moveDirection += Vector3.forward;
        }
        else if (InputManager.Instance.IsDownMoveKey)
        {
            moveDirection += Vector3.back;
        }

        if (InputManager.Instance.IsRightMoveKey)
        {
            moveDirection += Vector3.right;
        }
        else if (InputManager.Instance.IsLeftMoveKey)
        {
            moveDirection += Vector3.left;
        }

        return moveDirection.normalized;
    }
    /// <summary>
    /// キャラクターの移動関数
    /// </summary>
    /// <param name="moveDirection"></param>
    /// <param name="isLeftShiftKey"></param>
    private void MovePlayer(Vector3 moveDirection, bool isLeftShiftKey)
    {
        transform.position += moveDirection * playerStatus.GetMoveSpeed * Time.deltaTime;
    }

}