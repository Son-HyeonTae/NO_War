using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� �ֻ��� Ŭ����
/// �⺻���� ��� ���� �� �� Ŭ������ ���� ���� Ŭ���� Ȯ�� ����
/// 
/// 
/// Class TypeExplosion - Cooltime
/// Class Projectile - FireDelay, Velocity
/// </summary>

public abstract class Weapon : MonoBehaviour
{
    public abstract void Fire(); //������ ����
    public virtual void Init() { } //�ʿ信 ���� ����

    //--
    [SerializeField]    public float Damage;
    [SerializeField]    public float Amount;
    [SerializeField]    public float Cooltime;
                        public bool bReady;
}
