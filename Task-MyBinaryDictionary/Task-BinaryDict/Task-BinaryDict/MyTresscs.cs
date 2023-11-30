using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task_BinaryDict
{
    internal class MyTresscs<Tkey, Tvalue> where Tkey : IComparable<Tkey> where Tvalue : IComparable<Tvalue>
    {
        private TreeNode<Tkey, Tvalue> root;
        public void Add(Tvalue value, Tkey key)
        {
            if (!ContainsKey(key) && !ContainsValue(value))
            {
                root = Add(value, key, root);
            }
        }
        private TreeNode<Tkey, Tvalue> Add(Tvalue value, Tkey key, TreeNode<Tkey, Tvalue> node)
        {
            if (node == null)
            {
                return new TreeNode<Tkey, Tvalue>(value, key);
            }

            
            int comparison = value.CompareTo(node.Value);
            if (comparison < 0)
            {
                node.Left = Add(value, key, node.Left);
            }
            else if (comparison > 0)
            {
                node.Right = Add(value, key, node.Right);
            }
            

            return node;
        }
    
    
        /*Contains
        public bool Contains(Tvalue value)
        {
            TreeNode<Tkey,Tvalue> current = root;
            while (current != null)
            {
                int comparison = value.CompareTo(current.Value);
                if (comparison == 0)
                {
                    return true;
                }
                else if (comparison < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return false;
        }
        */
        public bool ContainsKey(Tkey key)
        {
            return ContainsKey(key, root);

        }
        private bool ContainsKey(Tkey key,TreeNode<Tkey, Tvalue> node)
        {
            if (node == null)
            {
                return false;
            }

            if (node.Key.Equals(key))
            {
                return true;
            }

            bool left = ContainsKey(key, node.Left);
            bool right = ContainsKey(key, node.Right);

            return left || right;
        }
        public void Clear()
        {
            root = null;
        }
        public bool ContainsValue(Tvalue value)
        {
            TreeNode<Tkey, Tvalue> current = root;
            while (current != null)
            {
                int comparison = value.CompareTo(current.Value);
                if (comparison == 0)
                {
                    return true;
                }
                else if (comparison < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return false;
        }
     
        private List<Tvalue> CLRvalue()
        {
            List<Tvalue> result = new List<Tvalue>();
            CLRvalue(root, result);
            return result;
        }
        private void CLRvalue(TreeNode<Tkey,Tvalue> node, List<Tvalue> result)
        {
            if (node != null)
            {
                result.Add(node.Value);
                CLRvalue(node.Left, result);
                CLRvalue(node.Right, result);
            }
        }
        private List<Tkey> CLRkey()
        {
            List<Tkey> result = new List<Tkey>();
            CLRkey(root, result);
            return result;
        }
        private void CLRkey(TreeNode<Tkey, Tvalue> node, List<Tkey> result)
        {
            if (node != null)
            {
                result.Add(node.Key);
                CLRkey(node.Left, result);
                CLRkey(node.Right, result);
            }
        }
        /* Обходы дерева
     public List<T> LCR()
     {
         List<T> result = new List<T>();
         LCR(root, result);
         return result;
     }
     private void LCR(TreeNode<T> node, List<T> result)
     {
         if (node != null)
         {
             LCR(node.Right, result);
             result.Add(node.Value);
             LCR(node.Left, result);

         }
     }

     public List<T> RCL()
     {
         List<T> result = new List<T>();
         RLC(root, result);
         return result;
     }
     private void RLC(TreeNode<T> node, List<T> result)
     {
         if (node != null)
         {
             RLC(node.Left, result);
             RLC(node.Right, result);
             result.Add(node.Value);
         }
     }
     public List<T> Across()
     {
         List<T> result = new List<T>();
         if (root == null)
             return result;

         Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
         queue.Enqueue(root);
         while (queue.Count > 0)
         {
             TreeNode<T> current = queue.Dequeue();
             result.Add(current.Value);
             if (current.Left != null)
                 queue.Enqueue(current.Left);
             if (current.Right != null)
                 queue.Enqueue(current.Right);
         }

         return result;
     }
     public List<T> ToList()
     {
         return LCR();
     }
     */
        public void Remove(Tvalue value)
        {
            root = RemoveRecursive(root, value);
        }
        private TreeNode<Tkey,Tvalue> RemoveRecursive(TreeNode<Tkey,Tvalue> current, Tvalue value)
        {
            if (current == null)
            {
                return null;
            }
            int comparison = value.CompareTo(current.Value);
            if (comparison<0)
            {
                current.Left = RemoveRecursive(current.Left, value);
            }
            else if (comparison>0)
            {
                current.Right = RemoveRecursive(current.Right, value);
            }
            else
            {
                if (current.Left == null && current.Right == null)
                {
                    return null;
                }
                else if (current.Left == null)
                {
                    return current.Right;
                }
                else if (current.Right == null)
                {
                    return current.Left;
                }
                else
                {
                    Tvalue minValue = FindMinValue(current.Right);
                    current.Value = minValue;
                    current.Right = RemoveRecursive(current.Right, minValue);
                }
            }

            return current;
        }
        private Tvalue FindMinValue(TreeNode<Tkey, Tvalue> node)
        {
            Tvalue minValue = node.Value;
            while (node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }
        public Tvalue FindValue(Tkey key)
        {

            TreeNode<Tkey, Tvalue> node = FindNode(root, key);
            if (node != null)
            {
                return node.Value;
            }
            else
            {
                return default(Tvalue);
            }
        }
        private TreeNode<Tkey, Tvalue> FindNode(TreeNode<Tkey, Tvalue> node, Tkey key)
        {

            if (node != null)
            {
                if (key.CompareTo(node.Key) == 0)
                {
                    return node;
                }

                TreeNode<Tkey, Tvalue> leftNode = FindNode(node.Left, key);
                if (leftNode != null)
                    return leftNode;

                TreeNode<Tkey, Tvalue> rightNode = FindNode(node.Right, key);
                if (rightNode != null)
                    return rightNode;
            }

            return null;


        }
        public Tkey FindKey(Tvalue value)
        {
            
            TreeNode<Tkey, Tvalue> node = FindNodeValue(root, value);
            return node != null ? node.Key : default(Tkey);
        }
        private TreeNode<Tkey, Tvalue> FindNodeValue(TreeNode<Tkey, Tvalue> node, Tvalue value)
        {
            if (node == null || value.CompareTo(node.Value) == 0)
            {
                return node;
            }
            else if (value.CompareTo(node.Value) < 0)
            {
                return FindNodeValue(node.Left, value);
            }
            else
            {
                return FindNodeValue(node.Right, value);
            }
        }
        public List<Tvalue> Values
        {
            get
            {
                
                return CLRvalue();
            }
        }
        public List<Tkey> Key
        {
            get
            {

                return CLRkey();
            }
        }
        public Tvalue this[Tkey key]
        {
            get
            {
                return FindValue(key);
            }

        }
        class TreeNode<Tkey,Tvalue>
        {
            public Tvalue Value { get; set; }
            public Tkey Key { get; set; }
            public TreeNode<Tkey, Tvalue> Left { get; set; }
            public TreeNode<Tkey, Tvalue> Right { get; set; }
            public TreeNode<Tkey, Tvalue> Parent { get; set; }

            public TreeNode(Tvalue value,Tkey key)
            {
                Value = value;
                Key = key;
                Left = null;
                Right = null;
                Parent = null;
            }

        }
    }
}
