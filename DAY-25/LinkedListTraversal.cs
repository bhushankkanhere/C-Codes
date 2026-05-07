using System;

class Node {
    public int data;
    public Node next;

    public Node(int d) {
        data = d;
        next = null;
    }
}

class LinkedListTraversal {
    static void Main() {
        Node head = new Node(1);
        head.next = new Node(2);
        head.next.next = new Node(3);

        Node temp = head;
        while (temp != null) {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
    }
}