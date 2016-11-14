﻿using System.Collections.Generic;
using Whoville.Data.Models;

namespace Whoville.Data.Interfaces
{
  public interface IStoryRepository
  {
    List<Story> GetAll();

    Story Save(Story entity);
  }
}
