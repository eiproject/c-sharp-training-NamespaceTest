using System;
using static System.Console;
//using CustomNameSpace;

namespace Tutlane
{
  class Program
  {
    static void Main(string[] args)
    {
      // Welcome w = new Welcome();
      CustomNameSpace.Welcome w = new CustomNameSpace.Welcome();
      w.GreetMessage();
      WriteLine("Press Any Key to Exit..");
    }
  }
}

namespace CustomNameSpace
{
  class Welcome
  {
    public void GreetMessage()
    {
      Console.WriteLine("Welcome to Tutlane");
    }
  }
}