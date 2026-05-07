using System;

class CircularQueue {
    int[] arr;
    int front = -1, rear = -1, size;

    public CircularQueue(int n) {
        size = n;
        arr = new int[n];
    }

    public void Enqueue(int val) {
        if ((rear + 1) % size == front) return;

        if (front == -1) front = 0;
        rear = (rear + 1) % size;
        arr[rear] = val;
    }

    public void Display() {
        if (front == -1) return;
        int i = front;
        while (true) {
            Console.Write(arr[i] + " ");
            if (i == rear) break;
            i = (i + 1) % size;
        }
    }

    static void Main() {
        CircularQueue q = new CircularQueue(5);
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        q.Display();
    }
}