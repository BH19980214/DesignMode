using System;

namespace _02简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("你想要什么品牌的电脑");
            string note = Console.ReadLine();
            NoteBook nb = GetNoteBook(note);
            nb.Say();
            Console.ReadKey();
        }
        public abstract class NoteBook
        {
            public abstract void Say();
        }
        public class Acer : NoteBook
        {
            public override void Say()
            {
                Console.WriteLine("我是鸿基");
            }
        }
        public class IBM : NoteBook
        {
            public override void Say()
            {
                Console.WriteLine("我是IBM");
            }
        }
        public class DELL : NoteBook
        {
            public override void Say()
            {
                Console.WriteLine("我是戴尔");
            }
        }
        public class Lenovo : NoteBook
        {
            public override void Say()
            {
                Console.WriteLine("我是联想");
            }
        }
        //简单工厂最核心的地方
        public static NoteBook GetNoteBook(string note)
        {
            NoteBook nb = null;
            switch (note)
            {
                case "Acer": nb = new Acer(); break;
                case "IBM": nb = new IBM(); break;
                case "DELL": nb = new DELL(); break;
                case "Lenovo": nb = new Lenovo(); break;
            }
            return nb;
        }
    }
}
