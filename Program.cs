﻿using System;
using System.Collections.Generic;

namespace bankHeist
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TeamMember> TeamMemberList = new List<TeamMember>();

            Console.WriteLine("Choose the bank difficulty: Easy, Moderate, or Difficult");

            string bankDifficultyInput = Console.ReadLine();

            int bankDifficulty = 0;

            if (bankDifficultyInput == "Easy")
            {
                bankDifficulty = 25;
            }
            else if (bankDifficultyInput == "Moderate")
            {
                bankDifficulty = 50;
            }
            else if (bankDifficultyInput == "Difficult")
            {
                bankDifficulty = 75;
            }

            Console.WriteLine("Plan your Heist!!");
            Console.WriteLine("How many members are on your team?");
            int TeamMemberCount = int.Parse(Console.ReadLine());

            while (TeamMemberCount > 0)
            {
                Console.Write("Enter Team Member Name: ");
                string TeamMemberName = Console.ReadLine();

                if (TeamMemberName == "")
                {
                    TeamMemberCount = 0;
                    break;
                }

                Console.Write("Enter team member skill level 1 - 50: ");
                int TeamMemberSkillLevel = int.Parse(Console.ReadLine());

                Console.Write("Enter team member courage level 0.0 - 2.0: ");
                double TeamMemberCourage = double.Parse(Console.ReadLine());
                TeamMember newMember = new TeamMember()
                {
                    Name = TeamMemberName,
                    SkillLevel = TeamMemberSkillLevel,
                    Courage = TeamMemberCourage

                };

                TeamMemberList.Add(newMember);
                newMember.GetMemberDetails();
                TeamMemberCount--;
            }
            Console.Write("How many trial do you want to run?  ");
            int trailRuns = Convert.ToInt32(Console.ReadLine());

            int successes = 0;
            int failures = 0;

            while (TeamMemberCount == 0 && trailRuns > 0)
            {

                Random rnd = new Random();
                int LuckValue = rnd.Next(-10, 11);
                int bankDifficultyLevel = LuckValue + bankDifficulty;

                Console.WriteLine($"You have {TeamMemberList.Count} members on your team");
                int skillMemberSum = 0;
                foreach (TeamMember member in TeamMemberList)
                {
                    skillMemberSum += member.SkillLevel;
                }
                if (skillMemberSum >= bankDifficultyLevel)
                {
                    Console.WriteLine("SkillLevel- " + skillMemberSum);
                    Console.WriteLine("DifficultyLevel- " + bankDifficultyLevel);
                    Console.WriteLine("Success!");
                    Console.WriteLine("---------------------");
                    successes++;
                }
                else
                {
                    Console.WriteLine("SkillLevel- " + skillMemberSum);
                    Console.WriteLine("DifficultyLevel- " + bankDifficultyLevel);
                    Console.WriteLine("Fail!");
                    Console.WriteLine("---------------------");
                    failures++;
                }
                trailRuns--;
            }
            Console.WriteLine($"{successes} successful attempts, {failures} failed attempts");

        }
    }
}