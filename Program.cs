using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//events
//event is something which is going to happen
//event is notification sent by object to signal to take action
//class which send event -publisher (only +=, -= operations allowed)
//class which recieves event- subscriber
//events is dependent on deligate
//event handler takes 2 parameter-input, returns void
//Syntax - public event EventHandler CellEvent;
//Invokation of the Event-if (CellEvent != null) CellEvent(this, e);
// Hooking up the Event- OurEventClass.OurEvent += new ChangedEventHandler(OurEventChanged);
//Detach the Event- OurEventClass.OurEvent -= new ChangedEventHandler(OurEventChanged);
//easiest way to declare event is to put event keyword infront of delegate


/*Syntax for the declaration of Event=
public event EventHandler MyEvent; */

/*To declare an event inside a class, first a Delegate type for the Event must be declared=
public delegate void MyEventHandler(object sender, EventArgs e);*/

/*Invoking an Event=
if (MyEvent != null) MyEvent(this, e);*/

/*Hooking up Event
MyEventClass.MyEvent += new ChangedEventHandler(MyEventChanged);  */

/*Detach the event
MyEventClass.MyEvent -= new ChangedEventHandler(MyEventChanged);*/

namespace events
{

    //make delegate first
    public delegate string Mydelegate(string s1, string s2);
class Myevent
    {
        //declare  event syntax =public event EventHandler MyEvent; 
        public event Mydelegate Eventdeclare;

        //make method
        public Myevent()             
        {
            //hooking up event
            //syntax = MyEventClass.MyEvent += new ChangedEventHandler(MyEventChanged);  
            Eventdeclare += new Mydelegate(Display);   //made method below as Display
        }
        public string Display(string name, string sub)
        {
            return name + sub;
        }

        static void Main()
        {
            //instatntiating class event
            Myevent me = new Myevent();
            string result = me.Eventdeclare("roshi", "maths");
            Console.WriteLine(result);
            Console.ReadLine();
        }

       //output = roshi maths
    }
    
        }



