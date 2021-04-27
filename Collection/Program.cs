using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Collection Programs");
            Dictionary(); //Call Dictionary method
            List();  //Call List method
            Stack(); //Call Stack method
            Queue();  //Call Queue method
            Set();   //Call Set method
            ArrayList();   //Call ArrayList method


            Console.ReadLine();
        }
        private static void Dictionary()
        {
            //Hashtable dictionary;
            //dictionary = new Hashtable();
            Console.WriteLine("*** Dictionary ***");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Omprakash"); //Adding element using Add method 
            dictionary.Add(2, "Khawshi");
            dictionary.Add(3, "Ekta");
            dictionary.Add(4, "Vishal");            

            foreach (var element in dictionary) // iterate read element
            {
             
                Console.WriteLine($"Key {element.Key} and value {element.Value}"); //print element
            }
            KeyValuePair<int, string> firstPairOfDictionary = dictionary.FirstOrDefault();  //get first keyvaluepair from dictionary.
            Console.WriteLine($"Dictionary of Top:-{firstPairOfDictionary}"); //print
            int count = dictionary.Count();  //count dictionary element
            Console.WriteLine($"Dictionary Element Count is:- {count}"); //print count
            Console.WriteLine("Access value using key(key=2):" + dictionary[2]); //print element using key value 
            dictionary.Remove(1);//Remove dictionary element using key value
             
            foreach (var element in dictionary)  // iterate read element
            {
                Console.WriteLine($"Key {element.Key} and value {element.Value}");  //print element
            }
            Console.WriteLine($"Dictionary Element Count is:- {dictionary.Count}"); //print count
            KeyValuePair<int, string> SecondPairOfDictionary = dictionary.FirstOrDefault();  //get first keyvaluepair from dictionary.
            Console.WriteLine($"Dictionary of Top:-{SecondPairOfDictionary}");

        }
        private static void List()
        {
            Console.WriteLine("\n*** List ***");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Pratik");
            list.Add("Rahul");
            list.Sort();
            foreach(var element in list)
            {
                Console.WriteLine(element);
            }

        }
        private static void Stack()
        {          
            
            Console.WriteLine("\n*** Stack *** \n");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush"); //add elements in stack using add method
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Suchita");       
                        
            foreach (var element in stack) // iterate read elements from stack
            {
                Console.WriteLine(element); // print element Stack

            }
            object Top = stack.Peek(); // Peek method read top element in stack
            Console.WriteLine($"Top most element in Stack is:-{Top}"); //Print Top Element
            Console.WriteLine($"Stack Count is {stack.Count}"); //print count of stack using Count method
            string pop = stack.Pop(); //Pop topmost Element in stack            
            Console.WriteLine($"Pop elememt in Stack (Last in First Out):-{pop}\n"); //Print 
            foreach (var element in stack) //Read Element is Stack
            {
                Console.WriteLine($"{element}"); //Print Element

            }
            object sTop = stack.Peek(); //Peek method read top element in stack
            Console.WriteLine($"Top most element in Stack is:-{sTop}\n"); //Print Top element

        }

        private static void Set()
        {
            Console.WriteLine("*** HashSet ***\n");
            var set= new HashSet<string>();
            set.Add("Omprakash");
            set.Add("Vishal");
            set.Add("Pratik");
            set.Add("Ekta");
            foreach (var element in set) //iterate
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("\n");
            

        }
        private static void Queue()
        {
            Console.WriteLine("*** Queue ***");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Omprakash "); //Enqueue Adding Element in Queue
            queue.Enqueue("Ekta ");
            queue.Enqueue("Dada");
            queue.Enqueue("Vishal");            
            
            foreach (var element in queue) //iterate Read Element in Queue
            {
                Console.WriteLine(element); //Print Element
            }
            int count = queue.Count(); // Count Queue Element
            Console.WriteLine($"Queue Element Count is :-{count}"); //print Queue count
            Console.WriteLine($"Queue of Top:-{queue.Peek()}"); //Peek method read Top most element or First element in Queue
            string dequeue = queue.Dequeue(); // Dequeue remove element First-In-First-Out
            Console.WriteLine($"Dequeue of element(First-In-First-Out):-{dequeue}\n"); //Print Remove Element

            foreach (var element in queue) // iterate Read Element in Queue
            {
                Console.WriteLine(element); //Print Element
               
            }
            Console.WriteLine($"Queue of Top:- {queue.Peek()}"); //Peek method read First element in Queue
            Console.WriteLine($"Queue Element Count is :- {queue.Count()}"); //print count of element
        }

        private static void ArrayList()
        {
            Console.WriteLine( "*** Array List ***\n" );
            ArrayList list; //instance of arraylist
            
            list = new ArrayList(); //Initilise list  //list is object
            list.Add("Omprakash");  // add elements using add method
            list.Add("Rahul");
            list.Add("Pooja");
            list.Add("RamRam");
            foreach (var element in list)  // iterate read elements 
            {
                Console.WriteLine(element);  //print element arrayList
            }
            int Count = list.Count; //Count List Element
            Console.WriteLine($"Array List Element Count is {Count}\n");
           
             list.Remove("Pooja"); // Remove list Element using name

            // list.RemoveAt(2); //Remove element using position or [index]

            // list.RemoveRange(0, 1); //Remove element using Range [index] to index

            //list.Sort(); //sort Asc order
            // list.Reverse(); // Sort Desc Order

            foreach (var element in list)  // iterate print element arrayList
            {
                Console.WriteLine(element);               

            }
            int Newcount = list.Count; //Count List Element
            Console.WriteLine($"Array List Element Count is {Newcount}");
          
            int ncapacity = list.Capacity; //Check capacity of list
            Console.WriteLine($"Capacity of Array List {ncapacity}");
            
        }

    }
}
