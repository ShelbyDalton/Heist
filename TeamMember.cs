using System;
using System.Collections.Generic;

namespace bankHeist
{
    class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }

        public double Courage { get; set; }

        public void GetMemberDetails()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"Team Member: {Name}");
            Console.WriteLine($"Member Skill Level: {SkillLevel}");
            Console.WriteLine($"Courage Level: {Courage}");
            Console.WriteLine("-----------------");
        }

        

    }

}