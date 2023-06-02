using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCookie : MonoBehaviour
{
    //�ϐ�
    Rigidbody rb;
    Vector3 _move,_moveRight,_moveLeft;
    bool flag=false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _move = new Vector3(0,0,2.0f);
        _moveRight = new Vector3(0.4f,0,0);
        _moveLeft = new Vector3(-0.4f,0,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(_move);
    }

    private void Update()
    {
        //�X���C�v�ňړ�
        flag = Swipe.MoveControll();
        if(flag ==true)
        {
            rb.position += _moveRight;
            flag=false;
        }
    }
}

public static class Swipe
{
    public static bool MoveControll()
    {
        Vector3 startPos = new Vector3();
        Vector3 endPos = new Vector3();
        Vector3 delPos = new Vector3();
        bool ans=false;
        bool click =false;

        //�N���b�N���Ɏn�_���W����
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            startPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            click = true;
        }

        //�N���b�N�b�����ۂɏI�_���W����
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            endPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        }

        //�X���C�v�������v�Z
        if(click == true)
        {
            delPos = endPos -startPos;
            if(delPos.sqrMagnitude > 1.0f)
            {
                ans = true;
            }
        }
        

        return ans;
    }
}
