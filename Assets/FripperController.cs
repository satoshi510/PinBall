using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;

    //�����̌X��
    private float defaultAngle = 20;
    //�͂��������̌X��
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        //HingeJoint�R���|�[�l���g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {
        //�����L�[�������������t���b�p�[�𓮂���
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S)) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //�E���L�[�����������E�t���b�p�[�𓮂���
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S)) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //���L�[�b���ꂽ���t���b�p�[�����ɖ߂�
        if((Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S)) && tag == "LeftFripperTag")
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) == true)
            { }
            else
            {
                SetAngle(this.defaultAngle);
            }
        }
        if ((Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.S)) && tag == "RightFripperTag")
        {
            if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S)) == true)
                { }
            else
            {
                SetAngle(this.defaultAngle);
            }
        }

    }
    //�t���b�p�[�̌X����ݒ�
    public void SetAngle (float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}
