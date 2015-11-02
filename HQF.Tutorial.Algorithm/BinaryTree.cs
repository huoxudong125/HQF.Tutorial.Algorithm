using System;

namespace HQF.Tutorial.Algorithm
{
    public class BinaryTree
    {
        #region 先序编历二叉树

        public static void PreOrder<T>(Nodes<T> rootNode)
        {
            if (rootNode != null)
            {
                Console.WriteLine(rootNode.Data);
                PreOrder(rootNode.LNode);
                PreOrder(rootNode.RNode);
            }
        }

        #endregion 先序编历二叉树

        #region 中序遍历二叉树

        public static void MidOrder<T>(Nodes<T> rootNode)
        {
            if (rootNode != null)
            {
                MidOrder(rootNode.LNode);
                Console.WriteLine(rootNode.Data);
                MidOrder(rootNode.RNode);
            }
        }

        #endregion 中序遍历二叉树

        #region 后序遍历二叉树

        public static void AfterOrder<T>(Nodes<T> rootNode)
        {
            if (rootNode != null)
            {
                AfterOrder(rootNode.LNode);
                AfterOrder(rootNode.RNode);
                Console.WriteLine(rootNode.Data);
            }
        }

        #endregion 后序遍历二叉树

        #region 层次遍历二叉树

        public static void LayerOrder<T>(Nodes<T> rootNode)
        {
            var
                Nodes = new Nodes<T>[20];
            var front = -1;
            var rear = -1;
            if (rootNode != null)
            {
                rear++;
                Nodes[rear] = rootNode;
            }

            while (front != rear)
            {
                front++;
                rootNode = Nodes[front];
                Console.WriteLine(rootNode.Data);
                if (rootNode.LNode != null)
                {
                    rear++;
                    Nodes[rear] = rootNode.LNode;
                }
                if (rootNode.RNode != null)
                {
                    rear++;
                    Nodes[rear] = rootNode.RNode;
                }
            }
        }

        #endregion 层次遍历二叉树

        #region 二叉树结点数据结构的定义

        //二叉树结点数据结构包括数据域，左右结点以及父结点成员；
        public class Nodes<T>
        {
            public Nodes()
            {
            }

            public Nodes(T data)
            {
                Data = data;
            }

            public T Data { set; get; }

            public Nodes<T> LNode { set; get; }

            public Nodes<T> RNode { set; get; }

            public Nodes<T> PNode { set; get; }
        }

        #endregion 二叉树结点数据结构的定义
    }
}