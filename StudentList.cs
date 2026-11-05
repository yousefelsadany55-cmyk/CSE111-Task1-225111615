using System;
using System.Collections.Generic;
using System.Text;
// Name: Yousef mohamed gamal elsaadany
// Student ID: 225111615
namespace Cse111Task1;

public class StudentList
{
    public Student? First { get; private set; }
    public Student? Last { get; private set; }
    public int Count { get; private set; }

    public void AddFront(int id)
    {
        var s = new Student(id);
        s.Next = First;
        First = s;
        if (Last == null) Last = s;
        Count++;
    }

    public void AddEnd(int id)
    {
        var s = new Student(id);
        if (Last == null)
        {
            First = s;
            Last = s;
        }
        else
        {
            Last.Next = s;
            Last = s;
        }
        Count++;
    }

    public bool Remove(int id)
    {
        Student? prev = null;
        Student? cur = First;
        while (cur != null)
        {
            if (cur.Id == id)
            {
                if (prev == null) First = cur.Next;
                else prev.Next = cur.Next;

                if (cur == Last) Last = prev;
                Count--;
                return true;
            }
            prev = cur;
            cur = cur.Next;
        }
        return false;
    }

    public void Reverse()
    {
        Student? prev = null;
        Student? cur = First;
        Last = First;
        while (cur != null)
        {
            Student? next = cur.Next; 
            cur.Next = prev;
            prev = cur;
            cur = next;
        }
        First = prev;
    }

    public void Print()
    {
        Student? cur = First;
        while (cur != null)
        {
            Console.Write(cur.Id);
            if (cur.Next != null) Console.Write(" ");
            cur = cur.Next;
        }
        Console.WriteLine();
    }
}