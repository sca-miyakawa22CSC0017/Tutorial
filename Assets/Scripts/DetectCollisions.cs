using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    private GameObject player;
    private PlayerController pc;
   [SerializeField] int point;

    private void OnTriggerEnter(Collider other) {
        player = GameObject.Find("Player");//プレイヤーを見つける
        pc = player.GetComponent<PlayerController>();//PlayerControllerを保存
        pc.SetCountText(point);//Playerにスコア更新を依頼
        Destroy(gameObject);//アタッチされている自分自身を消す
        Destroy(other.gameObject);//ぶつかった相手（other）を消す
    }


}
