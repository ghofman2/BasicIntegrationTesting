using System;
using System.Security;

namespace CommonLibrary
{
  public enum ParameterType
  {
    SECURE,
    STRING,
    NUMERIC,
    FILE,
    FOLDER
  }
  public class Parameter : ICloneable
  {
    public Parameter(string name, ParameterType type, string displayName)
    {
      Name = name;
      Type = type;
      DisplayName = displayName;
      Value = string.Empty;
      SecureValue = null;
    }
    public Parameter()
    {
    }

    public string Name { get; set; }
    public ParameterType Type { get; set; }
    public string DisplayName { get; set; }
    public string Value { get; set; }
    public SecureString SecureValue { get; set; }

    public object Clone()
    {
      var tmp = new Parameter()
      {
        Name = this.Name,
        Type = this.Type,
        DisplayName = this.DisplayName,
        Value = this.Value,
      };
      if (this.SecureValue != null)
      {
        tmp.SecureValue = this.SecureValue.Copy();
      }
      return tmp;
    }
  }
}
