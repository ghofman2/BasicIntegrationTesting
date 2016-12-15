using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Data.Models
{
  public class XmlFieldDictionaryModel
  {
    public string FileName { get; set; }

    public string FileNameShort { get { return FileName.Split('\\')[7]; } }

    public Dictionary<string, int> FieldDictionary { get; set; }

    public string FieldNames { get; set; }
  }
}
