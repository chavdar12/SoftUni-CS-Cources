﻿namespace TopView;

public interface IAbstractBinaryTree<T>
    where T : IComparable<T>
{
    T Value { get; }

    BinaryTree<T> LeftChild { get; }

    BinaryTree<T> RightChild { get; }


    List<T> TopView();
}