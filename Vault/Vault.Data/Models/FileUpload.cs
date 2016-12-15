﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vault.Data.Models.Base;

namespace Vault.Data.Models
{
  public class FileUpload : Entity
  {
    public string FileName { get; set; }

    public string Path { get; set; }

    public string Extension { get; set; }

    public int ProjectId { get; set; }
  }
}
