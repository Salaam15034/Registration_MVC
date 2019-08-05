using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login_Registration.Models
{
     public class Members
     {
          public int Id { get; set; }
          public string Name { get; set; }
          public string Contact { get; set; }
          public string JoiningDate { get; set; }
          public string Plan { get; set; }
          public int TrainerId { get; set; }
     }
}