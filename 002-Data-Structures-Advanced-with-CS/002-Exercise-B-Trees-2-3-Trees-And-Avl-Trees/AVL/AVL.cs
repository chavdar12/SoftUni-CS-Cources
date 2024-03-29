﻿namespace AVL;

public class AVL<T> where T : IComparable<T>
{
    public Node<T> Root { get; private set; }

    public bool Contains(T item)
    {
        var node = Search(Root, item);

        return node != null;
    }

    public void Insert(T item)
    {
        Root = Insert(Root, item);
    }

    public void Delete(T v)
    {
        if (Contains(v)) Root = Remove(Root, v);
    }

    public void DeleteMin()
    {
        if (Root != null)
        {
            var smallest = Smallest(Root);
            Delete(smallest.Value);
        }
    }

    public void EachInOrder(Action<T> action)
    {
        EachInOrder(Root, action);
    }

    private Node<T> Insert(Node<T> node, T item)
    {
        if (node == null) return new Node<T>(item);

        var cmp = item.CompareTo(node.Value);
        if (cmp < 0)
            node.Left = Insert(node.Left, item);
        else if (cmp > 0) node.Right = Insert(node.Right, item);

        node = Balance(node);
        UpdateHeight(node);

        return node;
    }

    private Node<T> Balance(Node<T> node)
    {
        var balance = Height(node.Left) - Height(node.Right);
        if (balance > 1)
        {
            var childBalance = Height(node.Left.Left) - Height(node.Left.Right);
            if (childBalance < 0) node.Left = RotateLeft(node.Left);

            node = RotateRight(node);
        }
        else if (balance < -1)
        {
            var childBalance = Height(node.Right.Left) - Height(node.Right.Right);
            if (childBalance > 0) node.Right = RotateRight(node.Right);

            node = RotateLeft(node);
        }

        return node;
    }

    private void UpdateHeight(Node<T> node)
    {
        if (node != null) node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;
    }

    private Node<T> Search(Node<T> node, T item)
    {
        if (node == null) return null;

        var cmp = item.CompareTo(node.Value);
        if (cmp < 0)
            return Search(node.Left, item);
        else if (cmp > 0) return Search(node.Right, item);

        return node;
    }

    private void EachInOrder(Node<T> node, Action<T> action)
    {
        if (node == null) return;

        EachInOrder(node.Left, action);
        action(node.Value);
        EachInOrder(node.Right, action);
    }

    private int Height(Node<T> node)
    {
        if (node == null) return 0;

        return node.Height;
    }

    private Node<T> RotateRight(Node<T> node)
    {
        var left = node.Left;
        node.Left = left.Right;
        left.Right = node;

        UpdateHeight(node);

        return left;
    }

    private Node<T> RotateLeft(Node<T> node)
    {
        var right = node.Right;
        node.Right = right.Left;
        right.Left = node;

        UpdateHeight(node);

        return right;
    }

    private Node<T> Smallest(Node<T> node)
    {
        if (node == null) return null;

        if (node.Left != null)
            return Smallest(node.Left);

        else
            return node;
    }

    private Node<T> Greatest(Node<T> node)
    {
        if (node == null) return null;

        if (node.Right != null)
            return Greatest(node.Right);

        else
            return node;
    }

    private Node<T> Remove(Node<T> node, T item)
    {
        if (node == null) return null;

        var cmp = item.CompareTo(node.Value);
        if (cmp < 0)
            node.Left = Remove(node.Left, item);
        else if (cmp > 0) node.Right = Remove(node.Right, item);

        if (cmp == 0)
        {
            // no children
            if (node.Left == null && node.Right == null) return null;
            // only left child
            if (node.Left != null && node.Right == null) return node.Left;
            //only right child
            if (node.Left == null && node.Right != null) return node.Right;

            if (node.Left.Height > node.Right.Height)
            {
                var replacement = Greatest(node.Left);
                node.Value = replacement.Value;
                node.Left = Remove(node.Left, replacement.Value);

                UpdateHeight(node.Left);
                UpdateHeight(node);
            }
            else
            {
                var replacement = Smallest(node.Right);
                node.Value = replacement.Value;
                node.Right = Remove(node.Right, replacement.Value);

                UpdateHeight(node.Right);
                UpdateHeight(node);
            }
        }

        node = Balance(node);
        UpdateHeight(node);

        return node;
    }
}