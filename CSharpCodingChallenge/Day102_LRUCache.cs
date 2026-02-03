using System;
using System.Collections.Generic;

namespace CSharpCodingChallenge
{
    internal class Day102_LRUCache
    {
        private int capacity;
        private Dictionary<int, Node> cache;
        private Node head;
        private Node tail;

        private class Node
        {
            public int key;
            public int value;
            public Node prev;
            public Node next;

            public Node(int k, int v)
            {
                key = k;
                value = v;
            }
        }

        public Day104_LRUCache(int capacity)
        {
            this.capacity = capacity;
            cache = new Dictionary<int, Node>();

            head = new Node(0, 0);
            tail = new Node(0, 0);

            head.next = tail;
            tail.prev = head;
        }

        public int Get(int key)
        {
            if (!cache.ContainsKey(key))
                return -1;

            Node node = cache[key];
            Remove(node);
            AddToFront(node);

            return node.value;
        }

        public void Put(int key, int value)
        {
            if (cache.ContainsKey(key))
            {
                Node node = cache[key];
                node.value = value;
                Remove(node);
                AddToFront(node);
            }
            else
            {
                if (cache.Count == capacity)
                {
                    Node lru = tail.prev;
                    Remove(lru);
                    cache.Remove(lru.key);
                }

                Node newNode = new Node(key, value);
                cache.Add(key, newNode);
                AddToFront(newNode);
            }
        }

        private void Remove(Node node)
        {
            node.prev.next = node.next;
            node.next.prev = node.prev;
        }

        private void AddToFront(Node node)
        {
            node.next = head.next;
            node.prev = head;

            head.next.prev = node;
            head.next = node;
        }
    }
}
