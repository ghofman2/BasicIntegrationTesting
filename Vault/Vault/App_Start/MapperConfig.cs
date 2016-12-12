using AutoMapper;
using System;
using Vault.Data.Models;
using Vault.Data.ViewModels;

namespace Vault.App_Start
{
  public static class MapperConfig
  {
    public static void RegisterMaps()
    {
      Mapper.Initialize(x =>
      {
        x.CreateMap<Folder, FolderModel>().PreserveReferences().ReverseMap().PreserveReferences();

        x.CreateMap<Cabinet, CabinetModel>().PreserveReferences().ReverseMap().PreserveReferences();

        x.CreateMap<FileModel, File>().PreserveReferences().ReverseMap().PreserveReferences();
      });
    }
  }
  
}
