using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ZombieType { small, meduim, big}

public class Zombie
{
    public int HP;
    public int Attack;
    public float attackRange;

    public Zombie(ZombieData zombieData)
    {
        HP = zombieData.HP;
        Attack = zombieData.Attack;
        attackRange = zombieData.attackRange;
    }



}

public class SpawnZombieData : MonoBehaviour
{
    [SerializeField] private ZombieData zombieData;
    public ZombieType zombieType;

    private void Update()
    {
        // �ð����� .... �� �ʸ��� ���� ������

        SpawnRandomZombie(zombieData);


    }

    public void SpawnRandomZombie(ZombieData zombieData)
    {
        Zombie newZombie = new Zombie(zombieData);

        Debug.Log("������ ü��" + newZombie.HP);
        Debug.Log("������ ���ݷ�" + newZombie.Attack);
        Debug.Log("������ ���ݹ���" + newZombie.attackRange);
    }
}
