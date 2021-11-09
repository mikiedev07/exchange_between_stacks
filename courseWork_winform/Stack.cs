using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace courseWork_winform
{
    class Stack
    {
        public class Node
        {
            public double data;
            public Node link;
        }

        public int ID { get; set; }
        public bool IsReciever { get; set; }
        public bool IsSourse { get; set; }
        public int Count { get; set; }

        public Node top;
        public List<Stack> array = new List<Stack>();

        public int id_of_source;
        public int id_of_reciever;

        public Stack()
        {
            this.top = null;
        }

        public Stack(int id, int count, bool is_sourse, bool is_reciever)
        {
            this.ID = id;
            this.top = null;
            this.Count = count;
            this.IsSourse = is_sourse;
            this.IsReciever = is_reciever;
        }

        public void readData()
        {
            //string path = @"C:/Users/Михаил\Documents/4 семестр/курсовая/courseWork_winform/courseWork_winform/copy.txt";
            string path = @"copy.txt";
            int i = 1;

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] nums = line.Split(' ');
                    if (i == 1) {
                        var new_stack = new Stack(i, nums.Length, true, false);
                        id_of_source = i-1;
                        foreach (var elem in nums)
                        {
                            new_stack.Push(Convert.ToDouble(elem));
                        }
                        array.Add(new_stack);
                    }
                    else if (i == 2)
                    {
                        var new_stack = new Stack(i, nums.Length, false, true);
                        id_of_reciever = i-1;
                        foreach (var elem in nums)
                        {
                            new_stack.Push(Convert.ToDouble(elem));
                        }
                        array.Add(new_stack);
                    }
                    else
                    {
                        var new_stack = new Stack(i, nums.Length, false, false);
                        foreach (var elem in nums)
                        {
                            new_stack.Push(Convert.ToDouble(elem));
                        }
                        array.Add(new_stack);
                    }
                    i++;
                }
            }
        }

        public void writeData()
        {
            string path = @"changedData.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var elem in array)
                {
                    List<string> lst = new List<string>();
                    for (int i = 0; i < elem.Count; i++)
                    {
                        Node temp = elem.top;

                        lst.Clear();
                        while (temp != null)
                        {
                            lst.Add(temp.data.ToString());
                            temp = temp.link;
                        }
                    }
                    lst.Reverse();
                    string line = string.Join(" ", lst.ToArray());
                    sw.WriteLine(line);
                }
            }
        }

        public void Push(double x)
        {
            Node temp = new Node();

            if (temp == null)
            {
                Console.WriteLine("\nHeap Overflow");
                return;
            }

            temp.data = x;
            temp.link = top;
            top = temp;
        }

        public bool isEmpty()
        {
            return top == null;
        }

        public double Peek()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("\nStack Underflow");
                return;
            }

            top = (top).link;
        }

        public void display()
        {

            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }

            else
            {
                Node temp = top;

                while (temp != null)
                {
                    Console.Write("{0}->", temp.data);
                    temp = temp.link;
                }
            }
        }
    }
}
