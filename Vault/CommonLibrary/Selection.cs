using System;

namespace CommonLibrary
{
  [Flags]
  public enum SelectionType
  {
    IDENTITY = 1,
    NAME = 2,
    DATERANGE = 4
  }
  public class Selection
  {
    public Selection()
    {
    }
    public Selection(SelectionType t, DateTimeOffset? sd, DateTimeOffset? ed, string f, string l, string id)
    {
      Type = t;
      StartDate = sd;
      EndDate = ed;
      First = f;
      Last = l;
      Identity = id;
    }


    public SelectionType Type { get; set; }
    public DateTimeOffset? StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }
    public string First { get; set; }
    public string Last { get; set; }
    public string Identity { get; set; }
  }
}
