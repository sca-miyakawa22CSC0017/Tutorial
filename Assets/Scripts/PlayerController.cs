using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI���g����悤�ɂ���

public class PlayerController : MonoBehaviour
{
    public int score = 0;
    [SerializeField]Text scoreText;//�X�R�A�\���pText
    float horizontalInput;
    [SerializeField] float speed;
    [SerializeField] float xRange;
    [SerializeField] GameObject projectilePrefab;//�H�ו��v���n�u�i���Ƃŕ����j

    private void Start() { 
        SetCountText(0);//������    
        }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput 
                * Time.deltaTime * speed);
        if(transform.position.x < -xRange) {
            transform.position = new Vector3(   -xRange, 
                                                transform.position.y,
                                                transform.position.z);
        }
        if(xRange < transform.position.x ) {
            transform.position = new Vector3(   xRange,
                                                transform.position.y,
                                                transform.position.z);
        }
        //�X�y�[�X�L�[�������ꂽ��
        if(Input.GetKeyDown(KeyCode.Space)) {
            //�����ŐH�ו��𕡐�����i���̎g�����A�Ƃ��������\�b�h���o���āI�j
            Instantiate(    projectilePrefab, 
                            transform.position,
                            projectilePrefab.transform.rotation);
        }

    }

    //SetCountText��������ӂɏ���

    public void SetCountText(int point) { 
        score += point;

        scoreText.text = "Score:" + score.ToString();//�y�d�v�zUI�X�V
        }
    }
