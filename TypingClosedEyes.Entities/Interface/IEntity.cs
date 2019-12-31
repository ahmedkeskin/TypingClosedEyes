using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TypingClosedEyes.Entities.Interface
{
    public interface IEntity
    {
      public int EntityId { get; set; }
    }
}
