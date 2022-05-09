using System;
using System.Collections.Generic;

class Player
{
    private int attack; //Making sure the attack is within encapsulation
    List<int> attackList = new List<int>(); //Create a list
    Queue<int> attackQueue = new Queue<int>(); //Create a queue
    HashSet<int> attackSet = new HashSet<int>(); //Create a set
    public void setAttack(int newAttackPower) //Method to set the attack
    {
        attack = Math.Max(newAttackPower, 0); //Math.Max ensures 0 is the minimum number that can be given as it takes the bigger of the two
    }

    public void addAttack(int attack) //Adds the attack to the list
    {
        attackList.Add(attack);
    }

    public int getAttack() //Returns the attack
    {
        return attack;
    }

    public void ReadAttackList() //Writes out the attack list
    {
        for (int i = 0; i < attackList.Count; i++)
        {
            Console.WriteLine(attackList[i]);
        }
    }

    public void QueueAttack(int attack) //Queues the attack
    {
        attackQueue.Enqueue(attack);
    }

    public int TakeQueue() //Takes the first place in the queue and removes it forwarding the line
    {
        return attackQueue.Dequeue();
    }

    public void addAttackSet(int attack) //add the attack to the set
    {
        attackSet.Add(attack);
    }

    public void checkAttackSet(int checker) //Check if the set contains the given number
    {
        if (attackSet.Contains(checker))
        {
            Console.WriteLine("The set contained " + checker);
        }
        else
        {
            Console.WriteLine("The set did not contain " + checker);
        }
    }

}