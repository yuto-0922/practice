using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    private bool isGrounded;

    // 接地状態を取得するプロパティ
    public bool IsGrounded
    {
        get { return isGrounded; }
    }

    // コライダーが接触した瞬間
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("地面に接触しました");
        }
    }

    // コライダーが接触を維持している間
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("地面に接触中です");
        }
    }

    // コライダーが接触を離れた瞬間
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            Debug.Log("地面から離れました");
        }
    }
}
