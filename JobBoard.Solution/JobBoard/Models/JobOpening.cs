using System.Collections.Generic;

namespace JobBoard.Models

{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    private static List<JobOpening> _instances = new List<JobOpening> { };

    public JobOpening(string title, string description, string name, string email, string phone)
    {
      Title = title;
      Description = description;
      Name = name;
      Email = email;
      Phone = phone;
      _instances.Add(this);
    }

    public static List<JobOpening> GetAll()
    {
      return _instances;
    }
  }
}