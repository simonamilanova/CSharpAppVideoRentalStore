using SEDC.CSharpAdv.VideoRentalData.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.VideoRentalData.Database
{
    public interface IFileDatabase<T>
        where T : BaseEntity
    {
        int Id { get; set; }
        List<T> Read();
        bool Write(List<T> entities);
        void Seed(List<T> seedData);
    }
}
