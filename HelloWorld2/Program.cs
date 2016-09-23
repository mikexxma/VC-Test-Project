using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{

    enum Day { am, pm };
    class Program
    {
        private static void TestThrow()
        {
            MyException me = new MyException("lalallala error");
            throw me;
        }

        private void testCatch()
        {
            try
            {
                TestThrow();
            }
            catch(MyException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static IEnumerable office_perple_id(int i, int j)
        {
            for (int num = i; num <= j; num++)
            {
                yield return num;
            }
        }
        static void Main(string[] args)
        {
            //Hello world
            Console.WriteLine("hello world");
            //Enum Test
            string s = Enum.GetName(typeof(Day), 1);
            Array i = Enum.GetValues(typeof(Day));
            Console.WriteLine(s + i.GetValue(1));
            Day now = Day.am;
            int Now = (int)now;
            Console.WriteLine("{0}---{1}", now, Now);
            
            
            //Arrary Test
            int[][] arrayTest = new int[6][];
            arrayTest[0] = new int[]{ 1,23,3,4,5};
            arrayTest[1] = new int[] { 1, 3, 4 };
            int[] arrayTest2 = new int[] { 1, 2, 3, 4, 5 };
            foreach (int j in arrayTest[0])
            {
                Console.WriteLine(j);
                
            }


            //Class Test
            People p1 = new People(27,175,63,"mike");
            p1.mage = 23;
            Animal animal1 = new Animal();
            animal1.sayhello("hello");
            p1.eat();
            p1.sayhello("hello1111");
            Console.ReadKey();


            //iterators
            Office_people op = new Office_people();
            foreach (string people in op)
            {
                Console.WriteLine(people);
            }


            foreach (int number in office_perple_id(1, 3))
            {
                Console.WriteLine(number);
            }
        }
    }

    abstract class Behavior
    {
        public abstract void eat();
    }

    class Animal : Behavior 
    {
        protected int age;
        protected int weight;
        protected int height;

        public virtual int mage
        {
            get { return age; }
            set { age = value; }
        }

        public int getWeight()
        {
            return weight;
        }

        public void setWeight(int mweight)
        {
            weight = mweight;
        }
        public override void eat()
        {
            Console.WriteLine("eat something");
        }

        public virtual void sayhello(String hello)

        {
            Console.WriteLine("animal say: " + hello);
        }
    }

    sealed class People : Animal
    {
        private string name;
        public People(int mage,int mweight,int mheight,string mname)
        {
            age = mage;
            weight = mweight;
            height = mheight;
            name = mname;
        }
        public People() { }
        ~People()
        {
            Console.WriteLine("object has been deleted");
        }

        public int needToEat(int mweight, int mheight)
        {
            return mheight * mweight;
        }
        public override void eat() {
            Console.WriteLine("eat everything");
        }

        public override void sayhello(string hello)
        {
            Console.WriteLine("people say hello"+ hello);
        }

    }

    public class Office_people: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return "mike";
            yield return "berry";
            yield return "tom";
        }
    }

    class MyException : Exception
    {
        public MyException(String msg) {
        }
    }

 

}
