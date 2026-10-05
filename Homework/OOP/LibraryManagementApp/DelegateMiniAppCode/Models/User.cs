using System;
using DelegateMiniAppCode.Intefaces;
using Utils.Enums;

namespace DelegateMiniAppCode.Models;

internal class User : IEntity
{
    public int Id { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public Roles Role { get; set; }

    private static int _id;
    public User(string name, string email, Roles role)
    {
        _id++;
        Id = _id;
        Name = name;
        Email = email;
        Role = role;
    }

    public override string ToString()
    {
       return $"Id: {Id}, Name: {Name}, Email: {Email}, Role: {Role}";
    }
}
