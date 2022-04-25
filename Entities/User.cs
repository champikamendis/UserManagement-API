﻿namespace WebApi.Entities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Dob { get; set; }
    public string Age { get; set; }
    public string Salary { get; set; }
    public string Department { get; set; }
}