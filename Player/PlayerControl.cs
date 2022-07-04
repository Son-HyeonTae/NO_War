using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eMOVE_TYPE
{
    FIXED,
    MOVEMENT
}

public class PlayerControl : Entity
{
    [SerializeField] private Camera MainCamera;
//--
    [Range(0.1f, 10.0f)]
    [SerializeField] private float HorizontalSensitivity = 1.0f; //���콺 ���� �ΰ���
    [Range(0.1f, 10.0f)]
    [SerializeField] private float BaseHorizontalSensitivity = 1.0f; //�ʱ� ���콺 ���� �ΰ���
    [SerializeField] private bool MouseRevers = false; //���콺 ����
    private Vector2 Target, Mouse;
    private float Angle;

//--
    [SerializeField] private float PositionYOffset = -0.0f; //Y�� ��ġ ������


//--
    [SerializeField] private eMOVE_TYPE MoveType;

    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GetMouseHorizontalAxis());
        
        switch(MoveType)
        {
            case eMOVE_TYPE.FIXED:
                MoveTypeFixed();
                break;
            case eMOVE_TYPE.MOVEMENT:
                MoveTypeMovement();
                break;
        }

    }




    void MoveTypeFixed()
    {
        Target = transform.position;

        Mouse = MainCamera.ScreenToWorldPoint(Input.mousePosition);
        Angle = Mathf.Atan2(Mouse.y - Target.y, Mouse.x - Target.x) * Mathf.Rad2Deg;
        
        transform.rotation = Quaternion.AngleAxis(Angle - 90, Vector3.forward);
    }
    void MoveTypeMovement()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        float MousePositionX = MainCamera.ScreenToWorldPoint(Input.mousePosition).x;

        transform.position = new Vector3(MousePositionX, transform.position.y);
    }
}
