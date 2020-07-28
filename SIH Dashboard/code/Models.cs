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
        public static Roles Role { get; set; }
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
        Admin,VisitingOfficial,Teacher,Student,Parent
    }

    public class Schools
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Feedbacks
    {
        public string Id { get; set; }
        public string Date { get; set; }
        public int SchoolCode { get; set; }
        public string SubmitterId { get; set; }
        public string Notes { get; set; }
        public string Feedback { get; set; }
    }
    public class StudentRecord
    {
        public int Session { get; set; }
        public int Class { get; set; }
        public int SchoolCode { get; set; }
        public int RollNumber { get; set; }
    }
    public class TeacherRecord
    {
        public int Session { get; set; }
        public int Class { get; set; }
        public int SchoolCode { get; set; }
        public int TeacherId { get; set; }
        public DateTime UploadedTodays { get; set; }
    }
    public class StudentAttendance
    {
        public List<SubjectAttendance> SubjectAttendance { get; set; }
    }
    public class SubjectAttendance
    {
        public string SubjectName { get; set; }
        public int TotalClasses { get; set; }
        public int TotalPresent { get; set; }
        public int RollNumber { get; set; }
        public bool Todays { get; set; }
    }
}
