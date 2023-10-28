using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMyList
{
    internal class MyList<T>:IEnumerable
    {
        ListNode first;
        ListNode last;
        int size=0;
    public T this[ int  index]
    {
        get { if (Math.Abs(index) >= size) throw new Exception("Не корректрный индекс");
                return GetItem(index).value;
            }
        set
            {
                SetValue(index, value);
            }

    }
    class ListNode
        {
            public T value { get;  set; }
            public ListNode next { get; set; } 
            public ListNode prev { get;  set; }

            public ListNode(ListNode next=null,ListNode first=null,T value=default ) {
                this.next = next;
                this.prev = first;
                this.value = value;
            }
            public bool Equals(T value)
            {
                return this.value.Equals(value);
            }
            
        }
        public IEnumerator GetEnumerator()
        {
            return new MyListEnumerator(first, size);
        }
        class MyListEnumerator : IEnumerator
        {
            ListNode current;
            int index=0;
            int size;
            public object Current { get { return current.value; } }
            public MyListEnumerator(ListNode first, int size) 
            { 
                current = first;
                this.size = size;
            }

            public bool MoveNext()
            {
                if (index == size)
                {
                    return false;
                }
                if (index > 0)
                {
                    current = current.next;
                }
                index++;
                return true;
            }

            public void Reset()
            {
                index = 0;
                current = null;
            }
        }
        public Boolean Append(T value) {
            size++;
            if (first == null) { first = new ListNode(value:value); return true; }
            if (last == null)
            {
                    last = new ListNode(value:value);
                    first.next = last;
                    last.prev = first;
                    return true;
            }
            var new_item = new ListNode(value: value);
            last.next = new_item;
            new_item.prev = last;
            last = new_item;
            return true;
        }
        public T  At(int index)
        {
            return this[index];
        }
        public Boolean Prepend(T value)
        {

            size++;
            if (last == null) { last = new ListNode(value: value); return true; }
            if (first == null)
            {
                    first = new ListNode(value: value);
                    last.prev = first;
                    first.next = last;
                    return true;
            }
            var new_item = new ListNode(value: value);
            first.prev = new_item;
            new_item.next = first;
            first = new_item;
            return true;
        }
        public T[] ToArray()
        {
            var index = 0;
            T[] array=new T[size]; 
            foreach(T value in this)
            {
                array[index] = value;
                index++;    
            }
            return array;
        }
        public int Find(T value)
        {
            ListNode currentListNode = first;
            for (int i = 0; i < size; i++)
            {
                if (currentListNode.Equals(value)) { return i; }
                currentListNode = currentListNode.next;
            }
            return -1;
        }
        public Boolean Contains(T value)
        {
            ListNode currentListNode = first;
            for (int i = 0; i < size; i++)
            {
                if (currentListNode.Equals(value)) { return true; }
                currentListNode = currentListNode.next;
            }
            return false;
        }
        public void Remove(T value)
        {
            

            RemoveItem(Find(value));
           
        }
        private ListNode GetItem(int index)
        {
            ListNode currentListNode = first;
            for (int i = 0; i < size; i++)
            {
                if (i == Math.Abs(index)) { break; }
                currentListNode = currentListNode.next;
            }
            return currentListNode;
        }
        private Boolean RemoveItem(int index)
        {
            if (index != -1 && size != 0)
            {
                
                var currentItem = GetItem(index);
            
                if (size > 2)
                {
                    
                    if (index == 0) 
                    { 
                        first = first.next; first.prev = null; 
                    }
                    if (index == size - 1) 
                    { 
                        last = last.prev; last.next = null;
                    }
                    if (index != 0 && index != size - 1) 
                    { 
                        currentItem.next.prev = currentItem.prev; currentItem.prev.next = currentItem.next; 
                    }
                    size--; return true;
                }
                if (size == 2) 
                { if (index == 0) 
                    { 
                        first = first.next; first.prev = null; last = null; 
                    } 
                  else 
                    { 
                        last = null; first.next = null;  
                    }
                    size--; return true; 
                }
                if(size==1) 
                {
                    last = null; first = null; size--; return true;
                }
            }
            return false;   
        }
        public void RemoveAt(int index)
        {
            
            if (Math.Abs(index) >= size) throw new Exception("Не корректрный индекс");
            RemoveItem(Math.Abs(index));
        }
        public void SetValue(int index,T value)
        {
            if (Math.Abs(index) >= size) throw new Exception("Не корректрный индекс");
            GetItem(Math.Abs(index)).value= value;

        }
    }
}
