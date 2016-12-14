using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Interface
{
  public interface License
  {
    void setLicense();
    string getLicense();
    void validateLicense();
    bool isLicensed();
  }
}
