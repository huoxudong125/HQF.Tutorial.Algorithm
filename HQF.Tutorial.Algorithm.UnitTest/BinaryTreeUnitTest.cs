using System;
using Xunit;

namespace HQF.Tutorial.Algorithm.UnitTest
{
    public class BinaryTreeUnitTest
    {
        #region 构造一棵已知的二叉树

        private static BinaryTree.Nodes<string> BinTree()
        {
            BinaryTree.Nodes<string>[]
        binTree = new BinaryTree.Nodes<string>[8];
            //创建结点
            binTree[0] = new  BinaryTree.Nodes<string>("A");
            binTree[1] = new  BinaryTree.Nodes<string>("B");
            binTree[2] = new  BinaryTree.Nodes<string>("C");
            binTree[3] = new  BinaryTree.Nodes<string>("D");
            binTree[4] = new  BinaryTree.Nodes<string>("E");
            binTree[5] = new  BinaryTree.Nodes<string>("F");
            binTree[6] = new  BinaryTree.Nodes<string>("G");
            binTree[7] = new BinaryTree.Nodes<string>("H");
            //使用层次遍历二叉树的思想，构造一个已知的二叉树

            binTree[0].LNode = binTree[1];
            binTree[0].RNode = binTree[2];
            binTree[1].RNode = binTree[3];
            binTree[2].LNode = binTree[4];
            binTree[2].RNode = binTree[5];
            binTree[3].LNode = binTree[6];
            binTree[3].RNode = binTree[7];
            //返回二叉树的根结点
            return binTree[0];
        }

        #endregion 构造一棵已知的二叉树
        [Fact]
        public void TestBinaryTreeTraverse()
        {
            BinaryTree.Nodes<string> rootNode = BinTree();

            Console.WriteLine("先序遍历方法遍历二叉树：");
            BinaryTree.PreOrder<string>(rootNode);

            Console.WriteLine("中序遍历方法遍历二叉树：");
            BinaryTree.MidOrder<string>(rootNode);

            Console.WriteLine("后序遍历方法遍历二叉树：");
            BinaryTree.AfterOrder<string>(rootNode);

            Console.WriteLine("层次遍历方法遍历二叉树：");
            BinaryTree.LayerOrder<string>(rootNode);
        }
    }
}
