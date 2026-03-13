using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodienwin
{
    public enum Gender { Male, Female, Other }
    public enum Relationship { None, Spouse, Child, Parent, Sibling }

    public class HouseholdHead
    {
        public string Name { get; set; }
        public Date Dob { get; set; }
        public string Id { get; set; }
        public Gender Gender { get; set; }

        public HouseholdHead(string name, Date dob, string id, Gender gender)
        {
            Name = name;
            Dob = dob;
            Id = id;
            Gender = gender;
        }

        public void Display()
        {
            Console.WriteLine($"Tên: {Name}, Ngày sinh: {Dob}, ID: {Id}, Giới tính: {Gender}");
        }
    }

    public class FamilyMember
    {
        public string Name { get; set; }
        public Date Dob { get; set; }
        public string Id { get; set; }
        public Gender Gender { get; set; }
        public Relationship Relationship { get; set; }
        public string HeadId { get; set; }
        public static class Person
        {
            public static List<string> usedIds = new List<string>();
        }
        public FamilyMember(string name, Date dob, string id, Gender gender, Relationship relationship, string headId)
        {
            Name = name;
            Dob = dob;
            Id = id;
            Gender = gender;
            Relationship = relationship;
            HeadId = headId;
        }

        public void Display()
        {
            Console.WriteLine($"Tên: {Name}, Ngày sinh: {Dob}, ID: {Id}, Giới tính: {Gender}, Quan hệ: {Relationship}, Chủ hộ ID: {HeadId}");
        }
    }
}
