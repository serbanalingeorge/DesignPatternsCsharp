using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        //Caretaker
        static void Main(string[] args)
        {
            IList<Memento> undos = new List<Memento>();
            Notepad notepad = new Notepad();
            Memento undo;

            //First Revision
            undo = notepad.SetText("cool");
            undos.Add(undo);

            Console.WriteLine("Currently in the notepad:");
            Console.WriteLine(notepad.GetText());

            //Second Revision
            undo = notepad.SetText("Something cool, but not cool enough to impress you!");
            undos.Add(undo);

            Console.WriteLine("\nCurrently in the notepad:");
            Console.WriteLine(notepad.GetText());

            Console.WriteLine("\nIssue Undo command");
            notepad.Undo(undos[1]);

            Console.WriteLine("\nCurrently in the notepad <after undo>:");
            Console.WriteLine(notepad.GetText());

            Console.Read();
        }
    }
}
