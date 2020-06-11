using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace AbstractClass
 {
   public class Program
   {
     public static void Main(string[] args)
     {
      
       
       Console.WriteLine();
       
       Console.WriteLine("==== Hero DOTA ====");
       
       Console.WriteLine();
       
       Hero hero;
       
       hero = new Strength();
       hero.name();
       hero.abilities();
       hero.difficulty();
       
       Console.WriteLine();
       
       hero = new Agility();
       hero.name();
       hero.abilities();
       hero.difficulty();
       
	   Console.WriteLine();
       
       hero = new Intelligence();
       hero.name();
       hero.abilities();
       hero.difficulty();
       }
       
   
   public abstract class Hero {
     public abstract void name();
     public abstract void abilities();
     public abstract void difficulty();
   }
   
   public class Strength : Hero {
     public override void name() {
       Console.WriteLine("Name  : Abaddon ");
     }
     
     public override void abilities() {
       Console.WriteLine("Abilities : Mist Coil, Aphotic Shield, Curse of Avernus, Borrowed Time ");
     }
     
     public override void difficulty() {
       Console.WriteLine("Difficulty : Normal ");
     }
   }
   
   public class Agility : Hero {
     public override void name() {
       Console.WriteLine("Name : Ursa ");
     }
     
     public override void abilities() {
       Console.WriteLine("Abilities : Earthshock, Overpower, Fury Swipes, Enrage ");
     }
     
     public override void difficulty() {
       Console.WriteLine("Difficulty : Easy ");
     }
   }

   public class Intelligence : Hero {
     public override void name() {
       Console.WriteLine("Name : Invoker ");
     }
     
     public override void abilities() {
       Console.WriteLine("Abilities : Quas, Wex, Exort, Invoke ");
     }
     
     public override void difficulty() {
       Console.WriteLine("Difficulty : Hard ");
     }
   }
 
   
   
   } 
   
 }
    