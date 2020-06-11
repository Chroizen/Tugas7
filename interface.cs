using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       Console.WriteLine();
       
       Console.WriteLine("==== Hero DOTA ====");
       
       Console.WriteLine();
       
       IHero hero;
       
       hero = new strength();
       hero.name();
       hero.abilities();
       hero.difficulty();
       
       Console.WriteLine();
       
       hero = new agility();
       hero.name();
       hero.abilities();
       hero.difficulty();
	   
	   Console.WriteLine();
       
       hero = new intelligence();
       hero.name();
       hero.abilities();
       hero.difficulty();
     }
     
     
     public interface IHero{
     void name();
     void abilities();
     void difficulty();
   }
   
  public class strength : IHero {
     public void name() {
       Console.WriteLine("Name : Earthshaker ");
     }
   
     public void abilities() {
       Console.WriteLine("Abilities : Fissure, Enchant Totem, Aftershock, Echo Slam ");
     }
     public void difficulty() {
       Console.WriteLine("Difficulty : Easy");
     }
     
   } 
   
   
   public class agility : IHero {
     public void name() {
       Console.WriteLine("Name : Clinkz");
     }
     public void abilities() {
       Console.WriteLine("Abilities : Death Pact, Searing Arrows, Skeleton Walk, Burning Army ");
     }
     public void difficulty() {
       Console.WriteLine("Difficulty : Normal");
     }
     
   }

   public class intelligence : IHero {
     public void name() {
       Console.WriteLine("Name : Necrophos");
     }
     public void abilities() {
       Console.WriteLine("Abilities : Death Pulse, Ghost Shroud, Heartstopper Aura, Reaper's Scythe ");
     }
     public void difficulty() {
       Console.WriteLine("Difficulty : Easy");
     }
     
   }
  
 }
}