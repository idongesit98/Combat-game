﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int playerHp = 40;
int enemyHp = 20;

int playerAttack = 5;
int enemyAttack = 7;

int healAmount = 5;
Random random = new Random();

while(playerAttack > 0 && enemyHp > 0)
{
    //Player turn
    Console.WriteLine("--Player turn");
    Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp);
    Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

    string choice = Console.ReadLine();

    if(choice == "a")
    {
      enemyHp -= playerAttack;
      Console.WriteLine("Player attack and deals " + playerAttack + " damage!");  
    }
    else
    {
      playerHp += healAmount;
      Console.WriteLine("Player restores " + healAmount + " health points!");
    }

    //Enemy turn
    if (enemyHp >0)
    {
      Console.WriteLine("-- Enemy Turn --");
      int enemyChoice = random.Next(0,2);
      if (enemyChoice == 0)
      {
        playerHp -= enemyAttack;
        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!");
      }
      else
      {
        enemyHp += healAmount;
        Console.WriteLine("Enemy restores " + healAmount + " health points!");
      }
      
    }
 }

 if (playerHp > 0)
 {
  Console.WriteLine("Congratulations");
   
 }
 else
 {
  Console.WriteLine("You lose");
 }