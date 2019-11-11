using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_FAMILY
{
    class Family
    {
        private List<Member> members;

        public Family(List<Member> members)
        {
            this.members = members;
        }

        public void Info(string name)
        {
            var names = FindMemberBy(name);
             names.Info();
        }

        private Member FindMemberBy(string name)
        {
            foreach (var member in members)
            {
                if (member.Name.ToLower() == name.ToLower())
                {
                    return member;
                }
            }

            return null;
        }




    }
}
