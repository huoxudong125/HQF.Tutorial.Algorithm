C#算法实现了二叉树的定义，怎么构造一颗已知的二叉树，用几种常规的算法（先序，中序，后序，层次）进行C#二叉树遍历。希望能给有需要人带来帮助，也希望能得到大家的指点。有关C#数据结构的书在书店里找到，网上也是极少，如果你有好的学习资源别忘了告诉我。先谢了。数据结构对一个程序员来说，现在是太重要了，数据结构学得好的人，逻辑思维一定很强，在程序设计的时候，就不会觉得太费劲了。而且是在设计多层应用程序的时候，真是让人绞尽脑汁啊。趁自己还年轻，赶紧练练脑子。哈哈，咱们尽快进入主题吧。

本程序中将用到一棵已知的二叉树如图（二叉树图）所示。

```
          A
         /  \
        /     \  
       /        \
   R              C
     \           /  \
        D       E    F
      /   \
    G       H
```

下面简单介绍一下几种算法和思路：

◆C#二叉树遍历算法之先序遍历：

1.访问根结点

2.按先序遍历左子树;

3.按先序遍历右子树；

4.例如：遍历已知二叉树结果为：A->B->D->G->H->C->E->F

◆C#二叉树遍历算法之中序遍历：

1.按中序遍历左子树;

2.访问根结点；

3.按中序遍历右子树；

4.例如遍历已知二叉树的结果：B->G->D->H->A->E->C->F

◆C#二叉树遍历算法之后序遍历：

1.按后序遍历左子树；

2.按后序遍历右子树；

3.访问根结点；

4.例如遍历已知二叉树的结果：G->H->D->B->E->F->C->A

◆C#二叉树遍历算法之层次遍历：

1.从上到下，从左到右遍历二叉树的各个结点(实现时需要借辅助容器)；

2.例如遍历已知二叉树的结果：A->B->C->D->E->F->G->H

以下是整个二叉遍历算法解决方案的代码：

``` c#
using System;  
using System.Collections.Generic;  
using System.Text;  
 
namespace structure  
{  
    class Program  
    {  
        #region 二叉树结点数据结构的定义   
        //二叉树结点数据结构包括数据域，左右结点以及父结点成员；  
      class nodes<T>  
        {  
            T data;  
            nodes<T> Lnode, Rnode, Pnode;  
            public T Data  
            {  
                set { data = value; }  
                get { return data; }  
 
            }  
            public nodes<T> LNode  
            {  
                set { Lnode = value; }  
                get { return Lnode; }  
            }  
            public nodes<T> RNode  
            {  
                set { Rnode = value; }  
                get { return Rnode; }  
 
            }  
 
            public nodes<T> PNode  
            {  
                set { Pnode = value; }  
                get { return Pnode; }  
 
            }  
          public nodes()  
          { }  
          public nodes(T data)  
          {  
              this.data = data;  
          }  
 
        }   
        #endregion  
 
        #region 先序编历二叉树  
        static void PreOrder<T>(nodes<T> rootNode)  
        {  
            if (rootNode != null)  
            {  
                Console.WriteLine(rootNode.Data);  
                PreOrder<T>(rootNode.LNode);  
                PreOrder<T>(rootNode.RNode);  
 
            }  
        }  
          
        #endregion  
 
        #region 构造一棵已知的二叉树  
 
        static nodes<string> BinTree()  
        {  
            nodes<string>[] binTree = new nodes<string>[8];  
            //创建结点  
            binTree[0] = new nodes<string>("A");  
            binTree[1] = new nodes<string>("B");  
            binTree[2] = new nodes<string>("C");  
            binTree[3] = new nodes<string>("D");  
            binTree[4] = new nodes<string>("E");  
            binTree[5] = new nodes<string>("F");  
            binTree[6] = new nodes<string>("G");  
            binTree[7] = new nodes<string>("H");  
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
        #endregion  
 
        #region 中序遍历二叉树  
        static void MidOrder<T>(nodes<T> rootNode)  
        {  
            if (rootNode != null)  
            {  
                MidOrder<T>(rootNode.LNode);  
                Console.WriteLine(rootNode.Data);  
                MidOrder<T>(rootNode.RNode);  
            }  
        }   
        #endregion  
        后序遍历二叉树#region 后序遍历二叉树  
        static void AfterOrder<T>(nodes<T> rootNode)  
        {  
            if (rootNode != null)  
            {  
                AfterOrder<T>(rootNode.LNode);  
                AfterOrder<T>(rootNode.RNode);  
                Console.WriteLine(rootNode.Data);  
            }  
 
        }   
        #endregion  
 
       #region 层次遍历二叉树  
        static void LayerOrder<T>(nodes<T> rootNode)  
        {  
            nodes<T>[] Nodes = new nodes<T>[20];  
            int front = -1;  
            int rear = -1;  
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
          
        #endregion  
 
      #region 测试的主方法  
        static void Main(string[] args)  
        {  
            nodes<string> rootNode = BinTree();  
 
            Console.WriteLine("先序遍历方法遍历二叉树：");  
            PreOrder<string>(rootNode);  
             
            Console.WriteLine("中序遍历方法遍历二叉树：");  
            MidOrder<string>(rootNode);  
              
            Console.WriteLine("后序遍历方法遍历二叉树：");  
            AfterOrder<string>(rootNode);  
 
 
            Console.WriteLine("层次遍历方法遍历二叉树：");  
            LayerOrder<string>(rootNode);  
 
 
            Console.Read();  
 
        }   
        #endregion  
    }  
} 
```

C#二叉树遍历算法实现就向你介绍到这里，希望通过对C#二叉树遍历算法实现的讲解使你对C#算法有了一些认识。