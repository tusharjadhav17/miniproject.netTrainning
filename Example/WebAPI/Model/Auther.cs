using System;
using System.Collections.Generic;

namespace WebAPI.Model;

public partial class Auther
{
    public long Id { get; set; }

    public DateTime AddedDate { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public int Ipaddress { get; set; }

    public string? LastName { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
