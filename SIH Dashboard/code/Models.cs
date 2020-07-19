﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIH_Dashboard
{
    public static class GlobalUser
    {
        public static string Name { get; set; }
        public static string UID { get; set; }
        public static bool IsVerified { get; set; }
        public static string Email { get; set; }
    }
    public class UserData
    {
        public string Name { get; set; }
        public long Phone { get; set; }
        public Roles Role { get; set; }
        public string DOB { get; set; }
        public bool Male { get; set; }
        public string Email { get; set; }
        public bool RoleVerified { get; set; }
    }

    public enum Roles
    {
        Admin,VisitingOfficial,Teacher,Student
    }

    public class Schools
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Feedbacks
    {
        public string Date { get; set; }
        public string SchoolId { get; set; }
        public string Feedback { get; set; }
    }
    public class StudentRecord
    {
        public int Session { get; set; }
        public int Class { get; set; }
        public int SchoolCode { get; set; }
        public int RollNumber { get; set; }
    }
    public class StudentAttendence
    {
        SubjectAttendence[] SubjectAttendence { get; set; }
    }
    public class SubjectAttendence
    {
        public string SubjectName { get; set; }
        public int TotalClasses { get; set; }
        public int TotalPresent { get; set; }
    }
}
