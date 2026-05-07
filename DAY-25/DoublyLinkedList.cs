using System;

class DNode {
    public int data;
    public DNode next, prev;

    public DNode(int d) {
        data = d;
    }
}

class DoublyLinkedList {
    static void Main() {
        DNode head = new DNode(1);
        DNode second = new DNode(2);
        head.next = second;
        second.prev = head;

        Console.WriteLine(head.data + " <-> " + second.data);
    }
}